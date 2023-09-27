using Prova.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Prova.Domain.Interfaces.Services
{
    public class IPapaiNoelService
    {
        public IEnumerable<PapaiNoel> GetCartinhas();
        public ValidationResult CreateCartinha(PapaiNoel cartinha);
    }
}
