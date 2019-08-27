using ApiWebZabud.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWebZabud.Core.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<Product> SaveProduct(Product product);
        Task<Product> UpdateProduct(Product product);

        Task<List<Product>> GetProductsAll();

        Task<Product> GetByIdProduct(long id);
    }
}
