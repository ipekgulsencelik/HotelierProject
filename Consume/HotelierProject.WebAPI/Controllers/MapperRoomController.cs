using AutoMapper;
using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.DTOLayer.DTOs.RoomDTO;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapperRoomController : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;

        public MapperRoomController(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _roomService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddRoom(AddRoomDTO addRoomDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var values = _mapper.Map<Room>(addRoomDTO);
            _roomService.TInsert(values);

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom(UpdateRoomDTO updateRoomDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var values = _mapper.Map<Room>(updateRoomDTO);
            _roomService.TUpdate(values);

            return Ok("Successfully Updated");
        }
    }
}