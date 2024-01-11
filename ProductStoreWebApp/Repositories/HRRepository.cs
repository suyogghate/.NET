using ProductStoreWebApp.Models;
namespace ProductStoreWebApp.Repositories;

using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class RepositoryManager{
    public void Serialize(List<Product> Products,string fileName){

    var options=new JsonSerializerOptions {IncludeFields=true};
    var ProductsJson=JsonSerializer.Serialize<List<Product>>(Products,options);
    File.WriteAllText(fileName,ProductsJson);
   
    }
    public List<Product> DeSerialize(string fileName){
   
         //Deserialize from JSON file
            string jsonString = File.ReadAllText(fileName);
            List<Product> jsonProducts = JsonSerializer.Deserialize<List<Product>>(jsonString);
           /* Console.WriteLine("\n JSON :Deserializing data from json file\n \n");
            foreach( Product emp in jsonProducts)
            {
                Console.WriteLine($"{emp.Id} : {emp .Name}");   
            }*/      
        return jsonProducts;
    }
}