using ECommerce.WebApi.Models;
using ECommerce.WebApi.Repository.Abstracts;
using ECommerce.WebApi.Service.Abstract;

namespace ECommerce.WebApi.Service.Concretes;

public class CategoryService : ICategoryService
{
    private ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    public Category Add(Category category)
    {
        Category addedCategory = _categoryRepository.Add(category);

        return addedCategory;
    }

    public Category Delete(int id)
    {
        Category category = _categoryRepository.Delete(id);

        return category;
    }

    public List<Category> GetAll()
    {
        return _categoryRepository.GetAll();
    }

    public Category GetById(int id)
    {
        Category category = _categoryRepository.GetById(id);

        return category;
    }

    public Category Update(Category category)
    {
        Category updatedCategory = _categoryRepository.Update(category);
        
        return updatedCategory;
    }
}
