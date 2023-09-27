using Prova.Domain.Entities;

namespace Prova.Domain.Interfaces.Repository
{
    public class IPapaiNoelRepositoryBase
    {
        public IEnumerable<PapaiNoel> GetCartinhas();
    }
}