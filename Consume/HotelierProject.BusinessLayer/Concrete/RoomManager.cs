using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.DataAccessLayer.Abstract;
using HotelierProject.EntityLayer.Concrete;

namespace HotelierProject.BusinessLayer.Concrete
{
    public class RoomManager : IRoomService
    {
        private readonly IRoomDAL _roomDAL;

        public RoomManager(IRoomDAL roomDAL)
        {
            _roomDAL = roomDAL;
        }

        public void TDelete(Room entity)
        {
            _roomDAL.Delete(entity);
        }

        public Room TGetByID(int id)
        {
            return _roomDAL.GetByID(id);
        }

        public List<Room> TGetList()
        {
            return _roomDAL.GetList();
        }

        public void TInsert(Room entity)
        {
            _roomDAL.Insert(entity);
        }

        public void TUpdate(Room entity)
        {
            _roomDAL.Update(entity);
        }
    }
}