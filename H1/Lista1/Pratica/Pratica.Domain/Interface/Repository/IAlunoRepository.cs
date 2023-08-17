using Pratica.Domain.Interface.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica.Domain.Interface.Repository
{
    public interface IAlunoRepository : IRepositoryBase<Aluno> 
    {
        public Aluno GetOne(int Id);
        public IEnumerable<Aluno> GetAll();
        public IAsyncResult Save(Aluno aluno);
        public IAsyncResult Update(Aluno aluno);
        public IAsyncResult Delete(int Id);
    }
}
