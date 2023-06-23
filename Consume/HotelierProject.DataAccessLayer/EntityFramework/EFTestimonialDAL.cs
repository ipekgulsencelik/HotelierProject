using HotelierProject.DataAccessLayer.Abstract;
using HotelierProject.DataAccessLayer.Concrete;
using HotelierProject.DataAccessLayer.Repository;
using HotelierProject.EntityLayer.Concrete;

namespace HotelierProject.DataAccessLayer.EntityFramework
{
    public class EFTestimonialDAL : GenericRepository<Testimonial>, ITestimonialDAL
    {
        public EFTestimonialDAL(Context context) : base(context)
        {
        }
    }
}
