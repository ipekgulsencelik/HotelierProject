using HotelierProject.DataAccessLayer.Abstract;
using HotelierProject.DataAccessLayer.Concrete;
using HotelierProject.DataAccessLayer.Repository;
using HotelierProject.EntityLayer.Concrete;

namespace HotelierProject.DataAccessLayer.EntityFramework
{
    public class EFBookingDAL : GenericRepository<Booking>, IBookingDAL
    {
        public EFBookingDAL(Context context) : base(context)
        {
        }

        public void BookingStatusChangeApproved(Booking booking)
        {
            var context = new Context();
            var values = context.Bookings.Where(x => x.BookingID == booking.BookingID).FirstOrDefault();
            values.Status = "Approved";
            context.SaveChanges();
        }

        public void BookingStatusChangeApprovedByID(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = "Approved";
            context.SaveChanges();
        }
    }
}
