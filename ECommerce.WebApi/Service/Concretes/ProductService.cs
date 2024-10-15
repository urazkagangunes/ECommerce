using ECommerce.WebApi.Dtos.Products.Request;
using ECommerce.WebApi.Dtos.Products.Responses;
using ECommerce.WebApi.Models;
using ECommerce.WebApi.Repository.Abstracts;
using ECommerce.WebApi.Repository.Concretes;
using ECommerce.WebApi.Service.Abstract;
using ECommerce.WebApi.Service.Mappers;

namespace ECommerce.WebApi.Service.Concretes;

public class ProductService : IProductService
{
    //private EfProductRepository _repository;
    //public ProductService(EfProductRepository efProductRepository)
    //{
    //    _repository = efProductRepository;
    //}

    private ProductMapper _productMapper;
    private IProductRepository _productRepository;
    public ProductService(IProductRepository productRepository, ProductMapper productMapper)
    {
        _productRepository = productRepository;
        _productMapper = productMapper;
    }

    public Product Add(CreateProductRequest dto)
    {
        Product product = _productMapper.ConvertToEntity(dto);

        Product addedProduct = _productRepository.Add(product);

        return addedProduct;
    }

    public Product? Delete(int id)
    {
        Product product = _productRepository.Delete(id);

        return product;
    }

    public List<ProductResponseDto> GetAll()
    {
        List<Product> products = _productRepository.GetAll();
        List<ProductResponseDto> responses = _productMapper.ConvertToResponseList(products);

        return responses;
    }

    public ProductResponseDto? GetById(int id)
    {
        Product product = _productRepository.GetById(id);
        ProductResponseDto dto = _productMapper.ConvertToResponse(product);

        return dto;
    }

    public Product Update(Product product)
    {
        Product updatedProduct = _productRepository.Update(product);

        return updatedProduct;
    }
}
