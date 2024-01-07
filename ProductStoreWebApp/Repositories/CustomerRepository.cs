using ProductStoreWebApp.Models;
namespace ProductStoreWebApp.Repositories;

using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class CustomerRepositoryManager{
    public void Serialize(List<Customer> customers,string fileName){

    var options=new JsonSerializerOptions {IncludeFields=true};
    var CustomerJson=JsonSerializer.Serialize<List<Customer>>(customers,options);
    File.WriteAllText(fileName,CustomerJson);
   
    }
    public List<Customer> DeSerialize(string fileName){
   
         //Deserialize from JSON file
            string jsonString = File.ReadAllText(fileName);
            List<Customer> jsonCustomer = JsonSerializer.Deserialize<List<Customer>>(jsonString);
           /* Console.WriteLine("\n JSON :Deserializing data from json file\n \n");
            foreach( Product emp in jsonProducts)
            {
                Console.WriteLine($"{emp.Id} : {emp .Name}");   
            }*/      
        return jsonCustomer;
    }
}