using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ClientService : ServiceBase<Client>, IClientService
    {
        private readonly IClientService _clientService;

        public ClientService(IClientService clientService)
            : base(clientService) 
        {
            _clientService = clientService;
        }

        public IEnumerable<Client> GetSpecialClients(IEnumerable<Client> clients)
        {
            return _clientService.GetSpecialClients(clients);
        }
    }
}
