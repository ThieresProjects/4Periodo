using Microsoft.AspNetCore.Mvc;
using Prova.Domain.Entities;
using Prova.Domain.Interfaces.Services;
using Prova.WebApi.Models;

namespace Prova.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PapaiNoelController : ControllerBase
    {

        private readonly IPapaiNoelService _papaiNoelService;
        public PapaiNoelController(IPapaiNoelService papaiNoelService)
        {
            _papaiNoelService = papaiNoelService;
        }
        [Route("GetCartinhas")]
        [HttpGet]
        public IEnumerable<PapaiNoelViewModel> GetCartinhas()
        {
            return _papaiNoelService.GetCartinhas() as List<PapaiNoelViewModel>;
        }

        [HttpPost]
        [Route("CreateCartinha")]
        public IActionResult CreateCartinha(PapaiNoelViewModel cartinha)
        {
            return Ok(_papaiNoelService.CreateCartinha(cartinha));
        }
    }
}
