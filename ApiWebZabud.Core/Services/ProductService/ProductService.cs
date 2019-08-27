using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiWebZabud.Core.Models;
using ApiWebZabud.Core.Repositories.ProductRepository;

namespace ApiWebZabud.Core.Services.ProductService
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> GetByIdProductService(long id)
        {
            var repo = await _productRepository.GetByIdProduct(id);
            return repo;
        }

        public async  Task<List<Product>> GetProductsServiceAll()
        {
            var repo = await _productRepository.GetProductsAll();
            return repo;
        }

        public async Task<Product> SaveProductService(Product product)
        {
            var repo = await _productRepository.SaveProduct(product);
            return repo;
        }

        public async  Task<Product> UpdateProductService(Product product)
        {
            var repo = await _productRepository.UpdateProduct(product);
            return repo;
        }
    }
}
