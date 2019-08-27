using ApiWebZabud.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWebZabud.Core.Repositories.ShoppingRepository
{
    public interface IShoppingRepository
    {
        Task<Shopping> SaveShopping(Shopping shopping);
        //Task<Shopping> UpdateProduct(Shopping shopping);
        Task<List<Shopping>> GetShoppingAll();
        Task<Shopping> GetByIdShopping(long id);
    }
}
