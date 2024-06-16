using CRMLeads.Models;
using System.Data;
using System.Data.SqlClient;

namespace CRMLeads.Data
{
    public class LeadRepository
    {
        private SqlConnection _connection;

        public LeadRepository()
        {
            string connStr = "server=LAPTOP-5T9AA23T\\SQLEXPRESS;database=CRMLeads;" +
                "Integrated Security=true;TrustServerCertificate=true;";

            _connection = new SqlConnection(connStr);
        }

        public List<LeadsEntity> GetAllLeads()
        {
            List<LeadsEntity> leadListEntity = new List<LeadsEntity>();

            SqlCommand cmd = new SqlCommand("GetAllLeads", _connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            dataAdapter.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                leadListEntity.Add(
                    new LeadsEntity 
                    { 
                        Id = Convert.ToInt32(dr["id"]),
                        LeadDate = Convert.ToDateTime(dr["LeadDate"]),
                        Name = dr["name"].ToString(),
                        EmailAddress = dr["EmailAddress"].ToString(),
                        Mobile = dr["Mobile"].ToString(),
                        LeadSource = dr["LeadSource"].ToString(),
                        LeadStatus = dr["LeadStatus"].ToString(),
                        NextFollowUpDate = Convert.ToDateTime(dr["NextFollowUpDate"]),
                    }
                );
            }

            return leadListEntity;
        }
        
        public LeadsEntity GetLeadById(int Id)
        {
            LeadsEntity leadListEntity = new LeadsEntity();

            SqlCommand cmd = new SqlCommand("GetLeadDetailsById", _connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter param;

            cmd.Parameters.Add(new SqlParameter("@Id", Id));

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            dataAdapter.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                leadListEntity = new LeadsEntity
                {
                    Id = Convert.ToInt32(dr["id"]),
                    LeadDate = Convert.ToDateTime(dr["LeadDate"]),
                    Name = dr["name"].ToString(),
                    EmailAddress = dr["EmailAddress"].ToString(),
                    Mobile = dr["Mobile"].ToString(),
                    LeadSource = dr["LeadSource"].ToString(),
                    LeadStatus = dr["LeadStatus"].ToString(),
                    NextFollowUpDate = Convert.ToDateTime(dr["NextFollowUpDate"]),
                };
            }

            return leadListEntity;
        }


        public bool AddLead(LeadsEntity lead)
        {
            SqlCommand cmd = new SqlCommand("AddLead", _connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@LeadDate", lead.LeadDate);
            cmd.Parameters.AddWithValue("@Name", lead.Name);
            cmd.Parameters.AddWithValue("@EmailAddress", lead.EmailAddress);
            cmd.Parameters.AddWithValue("@Mobile", lead.Mobile);
            cmd.Parameters.AddWithValue("@LeadSource", lead.LeadSource);
            cmd.Parameters.AddWithValue("@LeadStatus", lead.LeadStatus);
            cmd.Parameters.AddWithValue("@NextFollowUpDate", lead.NextFollowUpDate);

            _connection.Open();

            int i = cmd.ExecuteNonQuery();
            _connection.Close();

            if (i >= 1)
                return true;
            else
                return false;



        }

        public bool EditLeadDetails(int Id, LeadsEntity lead)
        {
            SqlCommand cmd = new SqlCommand("EditLead", _connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", Id);

            cmd.Parameters.AddWithValue("@LeadDate", lead.LeadDate);
            cmd.Parameters.AddWithValue("@Name", lead.Name);
            cmd.Parameters.AddWithValue("@EmailAddress", lead.EmailAddress);
            cmd.Parameters.AddWithValue("@Mobile", lead.Mobile);
            cmd.Parameters.AddWithValue("@LeadSource", lead.LeadSource);
            cmd.Parameters.AddWithValue("@LeadStatus", lead.LeadStatus);
            cmd.Parameters.AddWithValue("@NextFollowUpDate", lead.NextFollowUpDate);

            _connection.Open();

            int i = cmd.ExecuteNonQuery();
            _connection.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }
    }
}
