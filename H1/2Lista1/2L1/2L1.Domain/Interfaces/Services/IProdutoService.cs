using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2L1.Domain.Interfaces.Services
{
    public interface IProdutoService
    {
        public IEnumerable<dynamic> GetAll();
        public dynamic GetOne(int id);
        public dynamic GetOneByName(string name);
        public HttpRequestMessage Update(dynamic id);
    }
}
