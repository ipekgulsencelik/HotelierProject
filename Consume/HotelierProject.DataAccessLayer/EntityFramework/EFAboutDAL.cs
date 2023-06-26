using HotelierProject.DataAccessLayer.Abstract;
using HotelierProject.DataAccessLayer.Concrete;
using HotelierProject.DataAccessLayer.Repository;
using HotelierProject.EntityLayer.Concrete;

namespace HotelierProject.DataAccessLayer.EntityFramework
{
    public class EFAboutDAL : GenericRepository<About>, IAboutDAL
    {
        public EFAboutDAL(Context context) : base(context)
        {
        }
    }
}
