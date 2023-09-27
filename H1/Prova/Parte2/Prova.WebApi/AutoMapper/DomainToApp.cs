using AutoMapper;
using Prova.Domain.Entities;
using Prova.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prova.WebApi.AutoMapper
{
    public class DomainToApp
    {
        public DomainToApp()
        {
            CreateMap<EnderecoViewModel, Endereco>();
            CreateMap<PapaiNoelViewModel, PapaiNoel>();
        }
    }
}
