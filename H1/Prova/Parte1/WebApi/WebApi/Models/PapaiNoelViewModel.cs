using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class PapaiNoelViewModel
    {
        [MaxLength(255)]
        [MinLength(3)]
        public string Nome { get; set; }

        public EnderecoViewModel Endereco { get; set; }
        [Range(0, 15)]
        public int Idade { get; set; }
        [MaxLength(500)]
        public string Texto { get; set; }
    }
}
