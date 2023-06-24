using AutoMapper;
using HotelierProject.EntityLayer.Concrete;
using HotelierProject.WebUI.DTOs.ServiceDTO;

namespace HotelierProject.WebUI.Mappers
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDTO, Service>().ReverseMap();
            CreateMap<UpdateServiceDTO, Service>().ReverseMap();
            CreateMap<CreateServiceDTO, Service>().ReverseMap();
        }
    }
}