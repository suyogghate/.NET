using System.ComponentModel.DataAnnotations;

namespace ProductStoreWebApp.Models;

public class Product{
    [Required]
    public int Id{get;set;}
    [Required]
    public string? Title{get;set;}
    [Required]
    public double UnitPrice{get;set;}
    [Required]
    public int Quantity{get;set;}
}