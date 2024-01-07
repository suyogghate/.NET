using ProductStoreWebApp.Models;
using ProductStoreWebApp.Repositories;
namespace ProductStoreWebApp.Services;

public class CustomerService:ICustomerService{
    List<Customer> customers = new List<Customer>();

    CustomerRepositoryManager mgr = new CustomerRepositoryManager();

    string fileName = @"F:\DotNet\ProductStoreWebApp\customer.json";

    public CustomerService(){
        customers = mgr.DeSerialize(fileName);
    }

    public List<Customer> GetAll(){
        return customers;
    }
}