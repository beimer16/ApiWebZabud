using ApiWebZabud.Core.Models;
using ApiWebZabud.Core.Services.ClientService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Newtonsoft.Json;
using System.Web.Http.Results;


namespace ApiWebZabud.Api.Controllers
{
   
    public class ClientsController : ApiController
    {
        private readonly IClientService _clientService;


        public ClientsController(IClientService clientService)
        {
            _clientService = clientService;
        }
       

        public async Task<Client> Post([FromBody] Client client)
        {
            var repo = await _clientService.SaveClientService(client);

            return repo;
        }

        public async Task<Client> GetById(int id)
        {
            
            var repo = await _clientService.GetByIdClientService(id);
           return repo;
        }

        public async Task<List<Client>> Get()
        {

            var repo = await _clientService.GetClientsServiceAll();
            return repo;
        }

        public async Task<Client> Put([FromBody] Client client)
        {
            var repo = await _clientService.UpdateClientService(client);

            return repo;
        }
    }
}
