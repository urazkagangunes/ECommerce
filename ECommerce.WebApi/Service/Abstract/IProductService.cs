using ECommerce.WebApi.Dtos.Products.Request;
using ECommerce.WebApi.Dtos.Products.Responses;
using ECommerce.WebApi.Models;

namespace ECommerce.WebApi.Service.Abstract;

public interface IProductService
{
    List<ProductResponseDto> GetAll();
    ProductResponseDto? GetById(int id);
    Product Add(CreateProductRequest product);
    Product Update(Product product);
    Product? Delete(int id);
}
