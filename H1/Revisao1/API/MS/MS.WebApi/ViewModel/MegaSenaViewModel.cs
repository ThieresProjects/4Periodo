using System.ComponentModel.DataAnnotations;
using System.Data;

namespace MS.WebApi.ViewModel
{
    public class MegaSenaViewModel
    {
        public MegaSenaViewModel(
            string Nome,
            string CPF,
            int PrimeiroNro,
            int SegundoNro,
            int TerceiroNro,
            int QuartoNro,
            int QuintoNro,
            int SextoNro,
            DateTime DataJogo
        ) {
            this.Nome= Nome;
            this.CPF= CPF;
            this.PrimeiroNro = PrimeiroNro;
            this.SegundoNro = SegundoNro;
            this.TerceiroNro = TerceiroNro;
            this.QuartoNro = QuartoNro;
            this.QuintoNro = QuintoNro;
            this.SextoNro = SextoNro;
            this.DataJogo = DataJogo;
        }
        [MaxLength(255)]
        [MinLength(3)]
        public string Nome { get; set; }
        [MaxLength(11)]
        public string CPF { get; set; }
        [Range(1, 60)]
        public int PrimeiroNro { get; set; }
        [Range(1, 60)]
        public int SegundoNro { get; set; }
        [Range(1, 60)]
        public int TerceiroNro { get; set; }
        [Range(1, 60)]
        public int QuartoNro { get; set; }
        [Range(1, 60)]
        public int QuintoNro { get; set; }
        [Range(1, 60)]
        public int SextoNro { get; set; }
        public DateTime DataJogo { get;private set; }

        public void initJogo()
        {
            DataJogo = DateTime.Now;
        }
    }
}
