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
    public class DomainToApplication : Profile
    {
        public DomainToApplication()
        {
            CreateMap<Produto, ProdutoViewModel>();
        }
    }
}
