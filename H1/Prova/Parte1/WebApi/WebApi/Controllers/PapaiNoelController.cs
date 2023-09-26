using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using WebApi.Models;
using Newtonsoft.Json;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PapaiNoelController : ControllerBase
    {

        private string _caminho = @"./Data/PapaiNoel.json";


        [Route("GetCartinhas")]
        [HttpGet]
        public IEnumerable<PapaiNoelViewModel> GetCartinhas()
        {
            string json = System.IO.File.ReadAllText(_caminho);
            var result = JsonConvert.DeserializeObject<IEnumerable<PapaiNoelViewModel>>(json);
            return result;
        }

        [HttpPost]
        [Route("CreateCartinha")]
        public IActionResult CreateCartinha(PapaiNoelViewModel cartinha)
        {
            string json = System.IO.File.ReadAllText(_caminho);
            var result = JsonConvert.DeserializeObject<IEnumerable<PapaiNoelViewModel>>(json).ToList();
            result.Add(cartinha);
            var Obj = JsonConvert.SerializeObject(result);
            System.IO.File.WriteAllText(_caminho, Obj);
            return Ok("Cartinha criada com sucesso");
        }


    }

}
