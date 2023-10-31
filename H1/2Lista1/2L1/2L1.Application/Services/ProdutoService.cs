using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2L1.Domain.Interfaces.Repositories;
using _2L1.Domain.Interfaces.Services;

namespace _2L1.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<dynamic> GetAll()
        {
            throw new NotImplementedException();
        }

        public dynamic GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public dynamic GetOneByName(string name)
        {
            throw new NotImplementedException();
        }

        public HttpRequestMessage Update(dynamic id)
        {
            throw new NotImplementedException();
        }
    }
}
