using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProductStoreWebApp.Models;
using   ProductStoreWebApp.Services;
namespace ProductStoreWebApp.Controllers;
public class ProductController : Controller
{
    private readonly IProductService _svc;
    public ProductController(IProductService svc){
        this._svc=svc;
    }

    [HttpGet]
    public IActionResult Index()
    {
        List<Product> products=_svc.GetAll();
        ViewData["products"]=products;
        return View();
    }

    public IActionResult List(){
        List<Product> products = _svc.GetAll();
        return View(products);
    }

    public IActionResult Details(int id){
        Product prd = _svc.GetById(id);
        return View(prd);
    }
}
