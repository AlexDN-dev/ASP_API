using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;

namespace DAL.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product? GetById(int id);
        void Addproduct(Product p);
        void RemoveProduct(int id);
        void UpdateProduct(int id,Product p);
    }
}
