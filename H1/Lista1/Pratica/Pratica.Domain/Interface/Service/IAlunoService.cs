using Pratica.Domain.Interface.Service.Base;

namespace Pratica.Domain.Interface.Service
{
    public interface IAlunoService : IServiceBase<Aluno>
    {
        public Aluno GetOne(int Id);
        public IEnumerable<Aluno> GetAll();
        public IAsyncResult Save(Aluno aluno); 
        public IAsyncResult Update(Aluno aluno); 
        public IAsyncResult Delete(int Id); 

    }
}
