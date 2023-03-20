

using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Interfaces.Services
{
    public interface IClientService : IServiceBase<Client>
    {
        IEnumerable<Client> GetSpecialClients(IEnumerable<Client> clients);   
    }
}
