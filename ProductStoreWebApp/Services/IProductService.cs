using ProductStoreWebApp.Models;

namespace ProductStoreWebApp.Services;

public interface IProductService{
    public List<Product> GetAll();
    public Product GetById(int id);
    public void Insert(Product prod);
     public void Update(Product prod);
     public void Delete(int id);
}