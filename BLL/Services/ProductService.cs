using System;
using System.Collections.Generic;
using System.Text;
using BLL.Interfaces;
using DAL.Interfaces;
using Domain.Entities;

namespace BLL.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Product> GetAllProducts()
        {
            
            return _productRepository.GetAll();
        }

        public Product? GetProductById(int id)
        {
            return _productRepository.GetById(id);
        }

        public void AddProduct(Product p)
        {
            _productRepository.Addproduct(p);
        }

        public void RemoveProduct(int id)
        {
            _productRepository.RemoveProduct(id);
        }

        public void UpdateProduct(int id, Product p)
        {
            _productRepository.UpdateProduct(id, p);
        }
    }
}
