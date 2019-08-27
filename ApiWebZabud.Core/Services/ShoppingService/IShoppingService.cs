using ApiWebZabud.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWebZabud.Core.Services.ShoppingService
{
    public interface IShoppingService
    {
        Task<Shopping> SaveShoppingService(Shopping shopping);
        //Task<Shopping> UpdateProduct(Shopping shopping);
        Task<List<Shopping>> GetShoppingServiceAll();
        Task<Shopping> GetByIdShoppingService(long id);
    }
}
