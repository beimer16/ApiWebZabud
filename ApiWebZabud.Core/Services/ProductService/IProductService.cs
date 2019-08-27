using ApiWebZabud.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWebZabud.Core.Services.ProductService
{
     public  interface IProductService
    {
        Task<Product> SaveProductService(Product product);
        Task<Product> UpdateProductService(Product product);

        Task<List<Product>> GetProductsServiceAll();

        Task<Product> GetByIdProductService(long id);
    }
}
