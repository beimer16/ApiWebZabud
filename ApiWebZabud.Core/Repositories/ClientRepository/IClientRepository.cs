using ApiWebZabud.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWebZabud.Core.Repositories.ClientRepository
{
    public interface IClientRepository
    {
        Task<Client> SaveClient(Client client);
        Task<Client> UpdateClient(Client client);

        Task<List<Client>> GetClientsAll();

        Task<Client> GetByIdClient(long id);
    }
}
