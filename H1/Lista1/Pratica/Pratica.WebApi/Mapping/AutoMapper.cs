using AutoMapper;
using Pratica.Domain;
using Pratica.WebApi.Models;

namespace Pratica.WebApi.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AlunoViewModel, Aluno>();
            CreateMap<Aluno, AlunoViewModel>();
            CreateMap<IEnumerable<AlunoViewModel>, IEnumerable<Aluno>>();
            CreateMap<IEnumerable<Aluno>, IEnumerable<AlunoViewModel>>();
        }
    }
}

