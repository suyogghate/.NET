using ProductStoreWebApp.Models;
using ProductStoreWebApp.Repositories;
namespace ProductStoreWebApp.Services;

public class ProductService:IProductService{
    public List<Product> GetAll(){
       List<Product> Products=new List<Product>();
       RepositoryManager mgr=new RepositoryManager();
       string fileName=@"./products.json";
       Products=mgr.DeSerialize(fileName);
       return Products;
    }
    public Product GetById(int id){
      List<Product> Products=new List<Product>();
      RepositoryManager mgr=new RepositoryManager();
      string fileName=@"./products.json";
      Products=mgr.DeSerialize(fileName);
      Product prod=Products.Find(prod=>prod.Id==id);
      return prod;
    }
    public void Insert(Product emp){}
     public void Update(Product emp){}
     public void Delete(int id){

     }

}