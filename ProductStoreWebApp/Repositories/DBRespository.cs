using ProductStoreWebApp.Models;
using MySql.Data.MySqlClient;

namespace ProductStoreWebApp.Repositories;

public class MySqlDBManager{

    public MySqlDBManager(){}

    public List<Product> GetAll(){
    List<Product> products = new List<Product>();
    MySqlConnection con = new MySqlConnection();
    con.ConnectionString = @"server=localhost; port=3306; user=root; password=root123; database=dotnet";
    MySqlCommand cmd = new MySqlCommand();
    cmd.Connection = con;
    cmd.CommandText = "SELECT * FROM products";
    try{
        con.Open();
        MySqlDataReader reader = cmd.ExecuteReader();
        while(reader.Read()){
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
    }catch(Exception e){
        Console.WriteLine(e.Message);
    }finally{
        con.Close();
    }
    return products;
    }

    public Product GetById(int id){

        Console.WriteLine(" Getting Product Details");
        
        Product products = new Product();
        MySqlConnection con=new MySqlConnection();
        con.ConnectionString=@"server=localhost; port=3306; user=root; password=root123; database=dotnet";
        MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=con;
        cmd.CommandText="SELECT * from products WHERE id="+ id;
        try{
        con.Open();
        MySqlDataReader reader = cmd.ExecuteReader();
        while(reader.Read()){
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
    catch(Exception e){
        Console.WriteLine(e.Message);
    }
    finally{
        con.Close();
    }
    return products;
    }

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