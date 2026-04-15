using Démo_simple_API.DTO;
using Domain.Entities;

namespace Démo_simple_API.Mapping;

public static class ProductMapping
{
    public static GetProductResponse ToResponse(Product product)
    {
        return new GetProductResponse
        {
            Id = product.Id,
            Name = product.Name,
            Price = product.Price
        };
    }

    public static Product ToEntity(CreateProductRequest request)
    {
        return new Product
        {
            Name = request.Name,
            Price = request.Price
        };
    }

    public static Product ToEntity(UpdateProductRequest request)
    {
        return new Product
        {
            Id = request.Id,
            Name = request.Name,
            Price = request.Price
        };
    }
}