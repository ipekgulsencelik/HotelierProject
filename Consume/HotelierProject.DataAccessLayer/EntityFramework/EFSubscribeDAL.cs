using HotelierProject.DataAccessLayer.Abstract;
using HotelierProject.DataAccessLayer.Concrete;
using HotelierProject.DataAccessLayer.Repository;
using HotelierProject.EntityLayer.Concrete;

namespace HotelierProject.DataAccessLayer.EntityFramework
{
    public class EFSubscribeDAL : GenericRepository<Subscribe>, ISubscribeDAL
    {
        public EFSubscribeDAL(Context context) : base(context)
        {
        }
    }
}
