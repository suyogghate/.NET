using CRUDAppUsingADO.Models;
using System.Data;
using System.Data.SqlClient;

namespace CRUDAppUsingADO.DAL
{
    public class EmployeeDAL
    {
        string connStr = ConnectionString.dbcs;

        public List<Employees> GetAllEmployees()
        {
            List<Employees> empList = new List<Employees>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("spGetAllEmployee", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read()) 
                { 
                    Employees emp = new Employees();

                    emp.Id = Convert.ToInt32(reader["Id"]);
                    emp.Name = reader["name"].ToString()??"";
                    emp.Gender = reader["gender"].ToString()??"";
                    emp.Age = Convert.ToInt32(reader["age"]);
                    emp.Designation = reader["designation"].ToString() ?? "";
                    emp.City = reader["city"].ToString() ?? "";

                    empList.Add(emp);
                }
            }

            return empList;
        }

        public void AddEmployee(Employees emp)
        {
            using(SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("spAddEmployee", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@name", emp.Name);
                cmd.Parameters.AddWithValue("@gender", emp.Gender);
                cmd.Parameters.AddWithValue("@age", emp.Age);
                cmd.Parameters.AddWithValue("@designation", emp.Designation);
                cmd.Parameters.AddWithValue("@city", emp.City);

                conn.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public Employees GetEmployeeById(int? id)
        {
            Employees emp = new Employees();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("select * from employees where id=@id");
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id",id);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    emp.Id = Convert.ToInt32(reader["Id"]);
                    emp.Name = reader["name"].ToString() ?? "";
                    emp.Gender = reader["gender"].ToString() ?? "";
                    emp.Age = Convert.ToInt32(reader["age"]);
                    emp.Designation = reader["designation"].ToString() ?? "";
                    emp.City = reader["city"].ToString() ?? "";
                }
            }

            return emp;
        }

        public void UpdateEmployee(Employees emp)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("spUpdateEmployee", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", emp.Id);
                cmd.Parameters.AddWithValue("@name", emp.Name);
                cmd.Parameters.AddWithValue("@gender", emp.Gender);
                cmd.Parameters.AddWithValue("@age", emp.Age);
                cmd.Parameters.AddWithValue("@designation", emp.Designation);
                cmd.Parameters.AddWithValue("@city", emp.City);

                conn.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteEmployee(int? id) 
        {
            using(SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("spDeleteEmployee", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();

                cmd.ExecuteNonQuery();
            }
        }
    }
}
