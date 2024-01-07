using ProductStoreWebApp.Models;

namespace ProductStoreWebApp.Services;

public interface ICustomerService{
    public List<Customer> GetAll();
}