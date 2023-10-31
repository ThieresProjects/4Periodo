using _2L1.Application.ViewModels;
using _2L1.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2L1.Application.AutoMapper
{
    public class ApplicationToDomain : Profile
    {
        public ApplicationToDomain() 
        {
            CreateMap<ProdutoViewModel, Produto>()
   .ConstructUsing(q => new Produto(q.Nome, q.Ativo, q.Valor, q.Estoque));
        }
    }
}
