using Prova.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.Domain.Interfaces.Repository
{
    public class IPapaiNoelRepository
    {
        public IEnumerable<PapaiNoel> GetCartinhas();
        public ValidationResult CreateCartinha(PapaiNoel cartinha);
    }
}
