using _2L1.Domain.Entities;
using _2L1.Infrastructure.Data.Providers.MongoDB.Collections;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2L1.Infrastructure.Data.AutoMapper
{
    public class InfraToDomain : Profile
    {
        public InfraToDomain()
        {
            CreateMap<ProdutoCollection, Produto>()
        .ConstructUsing(q => new Produto(q.Nome, q.Ativo, q.Valor, q.Estoque));
        }
    }
}
