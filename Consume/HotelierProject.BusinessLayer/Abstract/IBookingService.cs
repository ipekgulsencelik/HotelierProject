using HotelierProject.EntityLayer.Concrete;

namespace HotelierProject.BusinessLayer.Abstract
{
    public interface IBookingService : IGenericService<Booking>
    {
        void TBookingStatusChangeApproved(int id);
    }
}
