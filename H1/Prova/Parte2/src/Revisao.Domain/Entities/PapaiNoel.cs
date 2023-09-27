using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.Domain.Entities
{
    public class PapaiNoel
    {
        [MaxLength(255)]
        [MinLength(3)]
        public string Nome { get; set; }

        public Endereco Endereco { get; set; }
        [Range(0, 15)]
        public int Idade { get; set; }
        [MaxLength(500)]
        public string Texto { get; set; }
    }
}
