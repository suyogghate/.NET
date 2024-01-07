using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProductStoreWebApp.Models;
using   ProductStoreWebApp.Services;
namespace ProductStoreWebApp.Controllers;
public class CustomerController : Controller
{
    private readonly ICustomerService _svc;
    public CustomerController(ICustomerService svc){
        this._svc=svc;
    }

    [HttpGet]
    public IActionResult Index()
    {
        List<Customer> customers=_svc.GetAll();
        ViewData["products"]=customers;
        return View();
    }
}
