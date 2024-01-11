using ProductStoreWebApp.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProductStoreWebApp.Repositories;

public class MySqlDBManager
{
    public MySqlDBManager() { }

    public List<Product> GetAll()
    {
        List<Product> products = new List<Product>();
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = @"server=localhost; port=3306; user=root; password=root123; database=dotnet";
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "SELECT * FROM products";
        try
        {
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["id"].ToString());
                string? title = reader["title"].ToString();
                double unitPrice = double.Parse(reader["unitPrice"].ToString());
                int qty = int.Parse(reader["qty"].ToString());

                Product p = new Product();
                p.Id = id;
                p.Title = title;
                p.UnitPrice = unitPrice;
                p.Quantity = qty;
                products.Add(p);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
        return products;
    }

    public Product GetById(int id)
    {
        Console.WriteLine(" Getting Product Details");
        Product products = new Product();
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = @"server=localhost; port=3306; user=root; password=root123; database=dotnet";
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "SELECT * from products WHERE id=" + id;
        try
        {
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id1 = int.Parse(reader["id"].ToString());
                string? title = reader["title"].ToString();
                double unitPrice = double.Parse(reader["unitPrice"].ToString());
                int qty = int.Parse(reader["qty"].ToString());

                Product p = new Product();
                products.Id = id1;
                products.Title = title;
                products.UnitPrice = unitPrice;
                products.Quantity = qty;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
        return products;
    }

    public bool InsertProduct(Product p)
    {
        bool status = false;
        Product products = new Product();
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = @"server=localhost; port=3306; user=root; password=root123; database=dotnet";
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "SELECT * FROM products";
        try
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
            da.Fill(ds);
            DataTable dtProducts = ds.Tables[0];
            DataRowCollection rows = dtProducts.Rows;
            DataRow row = dtProducts.NewRow();
            row["id"] = p.Id;
            row["title"] = p.Title;
            row["unitPrice"] = p.UnitPrice;
            row["qty"] = p.Quantity;
            rows.Add(row);
            da.Update(ds);
            status = true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
        return status;
    }

    // public bool Product(Product p)
    // {
    //     bool status = false;
    //     Product products = new Product();
    //     MySqlConnection con = new MySqlConnection();
    //     con.ConnectionString = conString;
    //     MySqlCommand cmd = new MySqlCommand();
    //     cmd.Connection = con;
    //     cmd.CommandText = "SELECT * FROM products";
    //     try
    //     {
    //         DataSet ds = new DataSet();
    //         MySqlDataAdapter da = new MySqlDataAdapter(cmd);
    //         MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
    //         da.Fill(ds);
    //         DataTable dtProducts = ds.Tables[0];
    //         DataRowCollection rows = dtProducts.Rows;
    //         DataRow row = dtProducts.NewRow();
    //         row["id"] = p.Id;
    //         row["title"] = p.Title;
    //         row["unitPrice"] = p.UnitPrice;
    //         row["qty"] = p.Quantity;
    //         rows.Add(row);
    //         da.Update(ds);
    //         status = true;
    //     }
    //     catch (Exception e)
    //     {
    //         Console.WriteLine(e.Message);
    //     }
        
    //     return status;
    // }


    // public void DeleteById(int id){

    //     // Console.WriteLine(" Getting Product Details");

    //     Product products = new Product();
    //     MySqlConnection con=new MySqlConnection();
    //     con.ConnectionString=@"server=localhost; port=3306; user=root; password=root123; database=dotnet";
    //     MySqlCommand cmd=new MySqlCommand();
    //     cmd.Connection=con;
    //     cmd.CommandText="DELETE FROM products WHERE id="+ id;
    //     try{
    //     con.Open();
    //     MySqlDataReader reader = cmd.ExecuteNonQuery();
    //     while(reader.Read()){
    //         int id1 = int.Parse(reader["id"].ToString());
    //         string? title = reader["title"].ToString();
    //         double unitPrice = double.Parse(reader["unitPrice"].ToString());
    //         int qty = int.Parse(reader["qty"].ToString());

    //         Product p = new Product();
    //         products.Id = id1;
    //         products.Title = title;
    //         products.UnitPrice = unitPrice;
    //         products.Quantity = qty;
    //         products.RemoveAt(id);
    //     }
    // }
    // catch(Exception e){
    //     Console.WriteLine(e.Message);
    // }
    // finally{
    //     con.Close();
    // }
    // return products;
    // }
}