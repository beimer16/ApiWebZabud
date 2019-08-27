using ApiWebZabud.Core.Models;
using ApiWebZabud.Core.Services.ProductService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ApiWebZabud.Api.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly IProductService _productService;


        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }


        public async Task<Product> Post([FromBody] Product product)
        {
            var repo = await _productService.SaveProductService(product);

            return repo;
        }

        public async Task<Product> GetById(int id)
        {

            var repo = await _productService.GetByIdProductService(id);
            return repo;
        }

        public async Task<List<Product>> Get()
        {

            var repo = await _productService.GetProductsServiceAll();
            return repo;
        }

        public async Task<Product> Put([FromBody] Product product)
        {
            var repo = await _productService.UpdateProductService(product);

            return repo;
        }
    }
}
