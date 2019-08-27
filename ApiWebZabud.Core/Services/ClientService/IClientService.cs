using ApiWebZabud.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWebZabud.Core.Services.ClientService
{
    public  interface IClientService
    {
        Task<Client> SaveClientService(Client client);

        Task<Client> UpdateClientService(Client client);


        Task<List<Client>> GetClientsServiceAll();

        Task<Client> GetByIdClientService(long id);
    }
}
