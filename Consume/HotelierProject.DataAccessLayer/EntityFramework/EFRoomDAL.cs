using HotelierProject.DataAccessLayer.Abstract;
using HotelierProject.DataAccessLayer.Concrete;
using HotelierProject.DataAccessLayer.Repository;
using HotelierProject.EntityLayer.Concrete;

namespace HotelierProject.DataAccessLayer.EntityFramework
{
    public class EFRoomDAL : GenericRepository<Room>, IRoomDAL
    {
        public EFRoomDAL(Context context) : base(context)
        {
        }
    }
}
