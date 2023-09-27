using Prova.Domain.Entities;
using Prova.Domain.Interfaces.Repository;
using System.ComponentModel.DataAnnotations;

namespace Prova.Application.Services
{
    public class PapaiNoelService
    {
        private readonly IPapaiNoelRepository _papaiNoelRepository;
        public PapaiNoelService(IPapaiNoelRepository papaiNoelRepository)
        {
            _papaiNoelRepository = papaiNoelRepository;
        }
        public IEnumerable<PapaiNoel> GetCartinhas()
        {
            return _papaiNoelRepository.GetCartinhas();
        }
        public ValidationResult CreateCartinha(PapaiNoel cartinha)
        {
            return _papaiNoelRepository.CreateCartinha(cartinha);
        }
    }
}
