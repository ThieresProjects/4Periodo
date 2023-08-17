using Pratica.Domain;
using Pratica.Domain.Interface.Repository;
using Pratica.Domain.Interface.Service;
using Pratica.Domain.Interface.Service.Base;

namespace Pratica.Service
{
    public class AlunoService : IServiceBase<Aluno>, IAlunoService
    {
        private readonly IAlunoRepository _alunoService;
        public AlunoService(IAlunoRepository alunoService)
        {
            _alunoService = alunoService;
        }

        public Aluno GetOne(int Id)
        {
            return _alunoService.GetOne(Id);
        }

        public IEnumerable<Aluno> GetAll()
        {
            return _alunoService.GetAll();
        }


        public IAsyncResult Save(Aluno aluno)
        {
            return _alunoService.Save(aluno);
        }

        public IAsyncResult Update(Aluno aluno)
        {
            return _alunoService.Update(aluno);
        }
        public IAsyncResult Delete(int Id)
        {
            return _alunoService.Delete(Id);
        }
    }
}