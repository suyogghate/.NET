using ProductStoreWebApp.Models;
using ProductStoreWebApp.Repositories;
namespace ProductStoreWebApp.Services;

public class ProductService:IProductService{
    public List<Product> GetAll(){
       List<Product> products=new List<Product>();
      //  RepositoryManager mgr=new RepositoryManager();
      //  string fileName=@"./products.json";
      //  Products=mgr.DeSerialize(fileName);
      MySqlDBManager mgr = new MySqlDBManager();
      products = mgr.GetAll();
      return products;
    }
    public Product GetById(int id){
      // List<Product> products=new List<Product>();
      // RepositoryManager mgr=new RepositoryManager();
      // string fileName=@"./products.json";
      // Products=mgr.DeSerialize(fileName);
      // Product prod=Products.Find(prod=>prod.Id==id);
      MySqlDBManager mgr = new MySqlDBManager();
      Product p = mgr.GetById(id);
      return p;
    }
    public void Insert(Product emp){}
     public void Update(Product emp){}
     public void Delete(int id){

     }

}