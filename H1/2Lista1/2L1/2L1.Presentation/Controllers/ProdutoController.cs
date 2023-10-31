using Microsoft.AspNetCore.Mvc;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using _2L1.Domain.Interfaces.Services;

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
        public IActionResult Reativar()
        {
            return Ok();
        }
        [HttpPatch]
        public IActionResult AlterarPreco()
        {
            return Ok();
        }
        [HttpPatch]
        public IActionResult AtualizarEstoque()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult Atualizar()
        {
            return Ok();
        }
        [HttpGet]
        public IActionResult ObterPorId()
        {
            return Ok();
        }
        [HttpGet]
        public IActionResult ObterPorNome()
        {
            return Ok();
        }
        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            return Ok();
        }

    }
}
