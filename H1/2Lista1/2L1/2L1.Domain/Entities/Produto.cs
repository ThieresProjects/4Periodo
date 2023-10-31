using static System.Net.Mime.MediaTypeNames;

namespace _2L1.Domain.Entities
{
    public class Produto
    {
        public Produto(string nome, bool ativo, decimal valor, int estoque)
        {
            Nome = nome;
            Ativo = ativo;
            Valor = valor;
            Estoque = estoque;
        }

        public Produto(Guid codigoId, string nome, bool ativo, decimal valor, int estoque)
        {
            CodigoId = codigoId;
            Nome = nome;
            Ativo = ativo;
            Valor = valor;
            Estoque = estoque;
        }
        public Guid CodigoId { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public decimal Valor { get; set; }
        public int Estoque { get; set; }
    }
}