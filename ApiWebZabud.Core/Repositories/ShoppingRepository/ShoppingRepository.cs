using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiWebZabud.Core.Models;

namespace ApiWebZabud.Core.Repositories.ShoppingRepository
{
    public class ShoppingRepository : IShoppingRepository
    {
        public Task<Shopping> GetByIdShopping(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Shopping>> GetShoppingAll()
        {
            throw new NotImplementedException();
        }

        public Task<Shopping> SaveShopping(Shopping shopping)
        {
            throw new NotImplementedException();
        }
    }
}
