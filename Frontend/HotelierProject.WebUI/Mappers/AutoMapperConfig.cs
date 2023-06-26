using AutoMapper;
using HotelierProject.EntityLayer.Concrete;
using HotelierProject.WebUI.DTOs.AboutDTO;
using HotelierProject.WebUI.DTOs.LoginDTO;
using HotelierProject.WebUI.DTOs.RegisterDTO;
using HotelierProject.WebUI.DTOs.ServiceDTO;
using HotelierProject.WebUI.DTOs.StaffDTO;
using HotelierProject.WebUI.DTOs.SubscribeDTO;
using HotelierProject.WebUI.DTOs.TestimonialDTO;

namespace HotelierProject.WebUI.Mappers
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDTO, Service>().ReverseMap();
            CreateMap<UpdateServiceDTO, Service>().ReverseMap();
            CreateMap<CreateServiceDTO, Service>().ReverseMap();

            CreateMap<CreateNewUserDTO, AppUser>().ReverseMap();
            CreateMap<LoginUserDTO, AppUser>().ReverseMap();

            CreateMap<ResultAboutDTO, About>().ReverseMap();
            CreateMap<UpdateAboutDTO, About>().ReverseMap();

            CreateMap<ResultTestimonialDTO, Testimonial>().ReverseMap();

            CreateMap<ResultStaffDTO, Staff>().ReverseMap();

            CreateMap<CreateSubscribeDTO, Subscribe>().ReverseMap();
        }
    }
}