using HotelierProject.DataAccessLayer.Abstract;
using HotelierProject.DataAccessLayer.Concrete;
using HotelierProject.DataAccessLayer.Repository;
using HotelierProject.EntityLayer.Concrete;

namespace HotelierProject.DataAccessLayer.EntityFramework
{
    public class EFStaffDAL : GenericRepository<Staff>, IStaffDAL
    {
        public EFStaffDAL(Context context) : base(context)
        {
        }
    }
}
