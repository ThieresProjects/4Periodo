using AutoMapper;
using Pratica.Domain;
using Pratica.WebApi.Models;

namespace Pratica.WebApi.Mapping
{
    public class MappingProfile : Profile
    {
        private readonly IMapper _mapper;
        public MappingProfile()
        {
            CreateMap<AlunoViewModel, Aluno>();
            CreateMap<Aluno, AlunoViewModel>();
            CreateMap<IEnumerable<AlunoViewModel>, List<Aluno>>();
            CreateMap<IEnumerable<Aluno>, List<AlunoViewModel>>();
        }
    }
}

