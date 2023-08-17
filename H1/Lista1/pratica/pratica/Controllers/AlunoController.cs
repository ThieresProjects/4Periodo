using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pratica.Model;

namespace pratica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {

        [HttpGet]
        public ActionResult Get()
        {
            return Ok();
        }
        [HttpPost]
        public ActionResult Post(AlunoViewModel alunos)
        {
            return Ok();
        }
        [HttpPut]
        public ActionResult Put()
        {
            return Ok();
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            return Ok();
        }

        
    }
}
