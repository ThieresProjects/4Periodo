using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2L1.Domain.Interfaces.Repositories;
using _2L1.Infrastructure.Data.Providers.MongoDB.Collections;
using _2L1.Infrastructure.Data.Providers.MongoDB.Interfaces;

namespace _2L1.Infrastructure.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly IMongoRepository<ProdutoCollection> _produtoRepository;
        public ProdutoRepository(IMongoRepository<ProdutoCollection> produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

    }
}
