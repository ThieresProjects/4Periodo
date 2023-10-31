namespace _2L1.Application.ViewModels
{
    public class ProdutoViewModel
    {
        public Guid CodigoId { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public decimal Valor { get; set; }
        public int Estoque { get; set; }
    }
}
