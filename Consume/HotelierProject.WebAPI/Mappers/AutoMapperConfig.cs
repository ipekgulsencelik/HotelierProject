using AutoMapper;
using HotelierProject.DTOLayer.DTOs.RoomDTO;
using HotelierProject.EntityLayer.Concrete;

namespace HotelierProject.WebAPI.Mappers
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<AddRoomDTO, Room>();
            CreateMap<Room, AddRoomDTO>();

            // CreateMap<UpdateRoomDTO, Room>().ReverseMap();

            CreateMap<UpdateRoomDTO, Room>();
            CreateMap<Room, UpdateRoomDTO>();
        }
    }
}
