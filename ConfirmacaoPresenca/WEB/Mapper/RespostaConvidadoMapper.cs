using AutoMapper;
using Negocio.Models;
using WEB.ViewModels;

namespace WEB.Mapper
{
    public class RespostaConvidadoMapper : Profile
    {
        public RespostaConvidadoMapper()
        {
            CreateMap<RespostaConvidadoModel, RespostaConvidadoViewModel>().ReverseMap();
        }
    }
}
