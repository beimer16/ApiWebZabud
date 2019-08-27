using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiWebZabud.Core.Models;
using ApiWebZabud.Core.Repositories.ClientRepository;

namespace ApiWebZabud.Core.Services.ClientService
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<Client> GetByIdClientService(long id)
        {
            var repo = await _clientRepository.GetByIdClient(id);
            return repo;
        }

        public async Task<List<Client>> GetClientsServiceAll()
        {
            var repo = await _clientRepository.GetClientsAll();
            return repo;
        }

        public async Task<Client> SaveClientService(Client client)
        {
           var repo= await  _clientRepository.SaveClient(client);
            return repo;
        }

        public Task<Client> UpdateClientService(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
