using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiWebZabud.Core.Models;

namespace ApiWebZabud.Core.Services.ShoppingService
{
    public class ShoppingService : IShoppingService
    {
        public Task<Shopping> GetByIdShoppingService(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Shopping>> GetShoppingServiceAll()
        {
            throw new NotImplementedException();
        }

        public Task<Shopping> SaveShoppingService(Shopping shopping)
        {
            throw new NotImplementedException();
        }
    }
}
