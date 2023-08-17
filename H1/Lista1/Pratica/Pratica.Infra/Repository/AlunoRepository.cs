using Pratica.Domain;
using Pratica.Domain.Interface.Repository;
using Pratica.Domain.Interface.Repository.Base;

namespace Pratica.Infra
{
    public class AlunoRepository : IRepositoryBase<Aluno>, IAlunoRepository
    {
        public Aluno GetOne(int Id)
        {
            return new Aluno();
        }

        public IEnumerable<Aluno> GetAll()
        {
            return new List<Aluno>();
        }


        public IAsyncResult Save(Aluno aluno)
        {
            throw new NotImplementedException();
        }

        public IAsyncResult Update(Aluno aluno)
        {
            throw new NotImplementedException();
        }
        public IAsyncResult Delete(int Id)
        {
            throw new NotImplementedException();
        }
    }
}