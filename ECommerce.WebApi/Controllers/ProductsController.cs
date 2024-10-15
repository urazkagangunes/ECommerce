using ECommerce.WebApi.Contexts;
using ECommerce.WebApi.Dtos.Products.Request;
using ECommerce.WebApi.Dtos.Products.Responses;
using ECommerce.WebApi.Models;
using ECommerce.WebApi.Service.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    //static List<Product> Products = new List<Product>()
    //{
    //    new Product {Id = 1, Name = "Dyson", Price = 20000, Stock = 100},
    //    new Product {Id = 2, Name = "İphone 16 Pro", Price = 87000, Stock = 10},
    //    new Product {Id = 3, Name = "Piyano", Price = 100000, Stock = 300},
    //    new Product {Id = 4, Name = "Steel Serises Alpha 7", Price = 25000, Stock = 700},
    //    new Product {Id = 5, Name = "Forma", Price = 3000, Stock = 5000}
    //};

    //[HttpGet]
    //public List<Product> GetAll()
    //{
    //    return Products; 
    //}

    //[HttpGet("getbyid")]
    //public Product GetById(int id)
    //{
    //    Product product = Products.SingleOrDefault(x => x.Id == id);
    //    return product;
    //}

    //MsSqlContext context = new MsSqlContext();

    //[HttpPost("add")]
    //public IActionResult Add( [FromBody] Product product)
    //{
    //    //insert into Products(kolonlar) values(değerler)
    //    context.Products.Add(product);
    //    context.SaveChanges();

    //    return Ok(product);
    //}

    //[HttpGet("getall")]
    //public List<Product> GetAll()
    //{
    //    //Select * from products
    //    return context.Products.ToList();
    //}

    //[HttpGet("getbyid/{id:int}")]
    //public IActionResult GetById([FromRoute]int id)
    //{
    //    Product product = context.Products.SingleOrDefault(x => x.Id == id);
    //    //==
    //    if (product is null)
    //    {
    //        return NotFound("Aradığınız ürün bulunamadı.");
    //    }
    //    return Ok(product);
    //}

    private IProductService _productService;
    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        List<ProductResponseDto> products = _productService.GetAll();
        return Ok(products);
    }

    [HttpPost("add")]
    public IActionResult Add([FromBody] CreateProductRequest product)
    {
         var added = _productService.Add(product);

        return Ok(added);
    }

    [HttpGet("getbyid")]
    public IActionResult GetById([FromQuery] int id)
    {
        var product = _productService.GetById(id);

        return Ok(product);
    }
}
