using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLL.Interfaces;
using Démo_simple_API.DTO;
using Démo_simple_API.Mapping;
using Domain.Entities;

namespace Démo_simple_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ActionResult<List<GetProductResponse>> GetAll()
        {
            IEnumerable<GetProductResponse> products = _productService.GetAllProducts().Select(ProductMapping.ToResponse);
            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult<GetProductResponse> GetById(int id)
        {
            Product product = _productService.GetProductById(id);

            if (product == null)
            {
                return NotFound("Produit non trouvé");
            }
            return Ok(ProductMapping.ToResponse(product));
        }

        [HttpPost]
        public ActionResult AddProduct(CreateProductRequest p)
        {
            if (p.Name == "" || p.Price < 0.0m)
            {
                return UnprocessableEntity("Erreur dans les données du produit");
            }

            _productService.AddProduct(ProductMapping.ToEntity(p));
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult RemoveProduct(int id)
        {
            _productService.RemoveProduct(id);
            return Ok("Le produit à bien été supprimé");
        }

        [HttpPut("{id}")]
        public ActionResult UpdateProduct(int id,UpdateProductRequest p)
        {
            _productService.UpdateProduct(id, ProductMapping.ToEntity(p));
            return Ok("Le produit à bien été mis à jour.");
        }
    }
}
