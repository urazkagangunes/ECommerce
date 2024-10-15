using ECommerce.WebApi.Models;

namespace ECommerce.WebApi.Service.Abstract;

public interface ICategoryService
{
    List<Category> GetAll();
    Category GetById(int id);
    Category Delete(int id);
    Category Add(Category category);
    Category Update(Category category);
}
