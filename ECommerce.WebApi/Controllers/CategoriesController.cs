using ECommerce.WebApi.Contexts;
using ECommerce.WebApi.Models;
using ECommerce.WebApi.Service.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        //static List<Category> Categories = new List<Category>()
        //{
        //    new Category {Id = 1, Name = "Süpürge"},
        //    new Category {Id = 2, Name = "Telefon"},
        //    new Category {Id = 3, Name = "Kulaklık"},
        //    new Category {Id = 4, Name = "Müzik Aleti"},
        //    new Category {Id = 5, Name = "Kıyafet"}
        //};

        //[HttpGet]
        //public List<Category> GetAll()
        //{
        //    return Categories; 
        //}

        //[HttpGet("getbyid")]
        //public Category GetById(int id)
        //{
        //    Category category = Categories.SingleOrDefault(c => c.Id == id);
        //    return category;
        //}
        MsSqlContext context;

        private ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            List<Category> categories = _categoryService.GetAll();
            return Ok(categories);
        }

        //[HttpPost("add")]
        //public IActionResult Add([FromBody] Category category)
        //{
        //    //insert into Products(kolonlar) values(değerler)
        //    context.Category.Add(category);
        //    context.SaveChanges();

        //    return Ok(category);
        //}
    }
}
