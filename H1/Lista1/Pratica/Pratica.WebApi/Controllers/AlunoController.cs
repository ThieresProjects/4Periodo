using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pratica.Domain;
using Pratica.Domain.Interface.Service;
using Pratica.WebApi.Mapping;
using Pratica.WebApi.Models;

namespace Pratica.WebApi.Controllers
{
    public class AlunoController : ControllerBase
    {
        private readonly MapperConfiguration _config;
        private readonly IMapper _mapper;
        private readonly IAlunoService _alunoService;

        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
            _config = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
            _mapper = _config.CreateMapper();
        }

        [HttpGet]
        [Route("Alunos/Get")]
        public IEnumerable<AlunoViewModel> Get()
        {
            //return _mapper.Map<IEnumerable<AlunoViewModel>>(_alunoService.GetAll());
            return new List<AlunoViewModel>();
        }
        [Route("Alunos/{Id}")]
        [HttpGet]
        public AlunoViewModel Get(int Id)
        {
            return _mapper.Map<AlunoViewModel>(_alunoService.GetOne(Id));
        }


        [HttpPost]
        [Route("Alunos/Post")]
        public IActionResult Post(AlunoViewModel aluno)
        {
            try
            {
                _alunoService.Save(_mapper.Map<Aluno>(aluno));
                return Ok("Aluno Cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }

        [HttpPut]
        [Route("Alunos/Put")]
        public IActionResult Put(AlunoViewModel aluno)
        {
            try
            {
                _alunoService.Update(_mapper.Map<Aluno>(aluno));
                return Ok("Aluno atualizado com sucesso");
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }

        [HttpDelete]
        [Route("Alunos/Delete")]
        public IActionResult Delete(int Id)
        {
            try
            {
                _alunoService.Delete(Id);
                return Ok("Aluno deletado com sucesso");
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }
    }
}
