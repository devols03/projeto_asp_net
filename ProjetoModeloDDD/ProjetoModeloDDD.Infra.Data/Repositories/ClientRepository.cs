

using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
    }
}
