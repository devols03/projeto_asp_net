using ProjetoModeloDDD.Application.Interfaces;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application
{
    public class ClientAppService : AppServiceBase<Client>, IClientAppService
    {

        private readonly IClientService _clientService;
        public ClientAppService(IClientService clientService)
            : base(clientService)
        {
            _clientService = clientService;
        }

        public IEnumerable<Client> GetSpecialClients()
        {
            return _clientService.GetSpecialClients(_clientService.GetAll());
        }

    }
}
