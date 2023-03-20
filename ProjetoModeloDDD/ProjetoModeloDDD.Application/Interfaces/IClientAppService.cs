using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Interfaces
{
    public interface IClientAppService : IAppServiceBase<Client>
    {
        IEnumerable<Client> GetSpecialClients();
    }
}
