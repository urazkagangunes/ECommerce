namespace ECommerce.WebApi.Dtos.Products.Request;

public sealed record CreateProductRequest
    (
        string Name,
        int Stock,
        double Price,
        int CategoryId
    );


