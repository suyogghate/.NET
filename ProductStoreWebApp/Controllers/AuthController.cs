using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProductStoreWebApp.Models;

namespace ProductStoreWebApp.Controllers;

public class AuthController:Controller{
    [HttpGet]
    public IActionResult SignIn(){
        return View();
    }

    [HttpPost]
    public IActionResult SignIn(IFormCollection form){
        var username = form["UserName"].ToString();
        var password = form["Password"].ToString();
        Console.WriteLine(username+" "+password);
        if(username == "suy123" && password == "1234"){
            return RedirectToAction("Index","Product",null);
        }
        return View();
    }

    // [HttpPost]
    // public IActionResult SignIn(string uname,string psw){
    //  Console.WriteLine(uname+" "+psw);
    //    string uname1=uname;
    //    string psw1=psw;
    //     return RedirectToAction("Index","Product",null);
    //     // return View();
    // }
}
