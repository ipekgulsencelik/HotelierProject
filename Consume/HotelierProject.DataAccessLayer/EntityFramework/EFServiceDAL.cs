using HotelierProject.DataAccessLayer.Abstract;
using HotelierProject.DataAccessLayer.Concrete;
using HotelierProject.DataAccessLayer.Repository;
using HotelierProject.EntityLayer.Concrete;

namespace HotelierProject.DataAccessLayer.EntityFramework
{
    public class EFServiceDAL : GenericRepository<Service>, IServiceDAL
    {
        public EFServiceDAL(Context context) : base(context)
        {
        }
    }
}
