using HotelierProject.EntityLayer.Concrete;

namespace HotelierProject.DataAccessLayer.Abstract
{
    public interface IBookingDAL : IGenericDAL<Booking>
    {
        void BookingStatusChangeApproved(Booking booking);
        void BookingStatusChangeApprovedByID(int id);
    }
}
