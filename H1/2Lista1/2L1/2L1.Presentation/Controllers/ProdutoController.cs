using Microsoft.AspNetCore.Mvc;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using _2L1.Domain.Interfaces.Services;
using _2L1.Application.ViewModels;

namespace _2L1.Presentation.Controllers
{
    [ApiController]
    [Route("Controller")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }
        //  Reativar -> Faz a reativação de um produto , ou seja, muda Ativo = true.
        //  AlterarPreco -> Faz a alteração do preço de produto, aqui tem uma regra de negócio que você deve fazer na camada de aplicação, o preço de um produto não pode ser zerado.
        //  AtualizarEstoque -> Faz a operação de atualizar o estoque, se for positivo, aumenta se for negativo diminui. Aqui precisa de uma regra de negócio, estoque nunca pode ser negativo.
        //  Atualizar -> Recebe todos os campos do cadastro do produto e atualiza os campos.
        //  ObterPorId -> Buscar os dados de um produto específico pelo CodigoId
        //  ObterPorNome -> Busca todos os produtos que contêm a palavra buscada, exemplo, buscar todos produtos tem no nome a palavra IPHone
        [HttpPatch]
        [Route("Reativar")]
        public IActionResult Reativar(int codProduto)
        {
            ProdutoViewModel result = _produtoService.GetOne(codProduto);
            result.Ativo = true;
            _produtoService.Update(result);
            return Ok();
        }
        [HttpPatch]
        [Route("AlterarPreco")]
        public IActionResult AlterarPreco(int codProduto, decimal preco)
        {
            ProdutoViewModel result = _produtoService.GetOne(codProduto);
            result.Valor = preco;
            _produtoService.Update(result);
            return Ok();
        }
        [HttpPatch]
        [Route("AtualizarEstoque")]
        public IActionResult AtualizarEstoque(int codProduto, int estoque)
        {
            ProdutoViewModel result = _produtoService.GetOne(codProduto);
            result.Estoque = estoque;
            _produtoService.Update(result);
            return Ok();
        }
        [HttpPut]
        [Route("Atualizar")]
        public IActionResult Atualizar(ProdutoViewModel produto)
        {
            _produtoService.Update(produto);
            return Ok();
        }
        [HttpGet]
        [Route("ObterPorId")]
        public ProdutoViewModel ObterPorId(int codProduto)
        {
            ProdutoViewModel result = _produtoService.GetOne(codProduto);
            return result;
        }
        [HttpGet]
        [Route("ObterPorNome")]
        public ProdutoViewModel ObterPorNome(string nome)
        {
            ProdutoViewModel result = _produtoService.GetOneByName(nome);
            return result;
        }
        [HttpGet]
        [Route("")]
        public IEnumerable<ProdutoViewModel> GetAll()
        {
            IEnumerable<ProdutoViewModel> result = _produtoService.GetAll();
            return result;
        }

    }
}
