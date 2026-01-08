using AutoMapper;
using NerdStore.Catalago.Application.ViewModels;
using NerdStore.Catalago.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Catalago.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Produto, ProdutoViewModel>()
               .ForMember(d => d.Largura, o => o.MapFrom(s => s.Dimensoes.Largura))
               .ForMember(d => d.Altura, o => o.MapFrom(s => s.Dimensoes.Altura))
               .ForMember(d => d.Profundidade, o => o.MapFrom(s => s.Dimensoes.Profundidade));

            CreateMap<Categoria, CategoriaViewModel>();
        }
    }
}
