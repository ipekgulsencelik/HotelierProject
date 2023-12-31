﻿using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.DataAccessLayer.Abstract;
using HotelierProject.EntityLayer.Concrete;

namespace HotelierProject.BusinessLayer.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDAL _bookingDAL;

        public BookingManager(IBookingDAL bookingDAL)
        {
            _bookingDAL = bookingDAL;
        }

        public void TBookingStatusChangeApprovedByID(int id)
        {
            _bookingDAL.BookingStatusChangeApprovedByID(id);
        }

        public void TBookingStatusChangeApproved(Booking booking)
        {
            _bookingDAL.BookingStatusChangeApproved(booking);
        }

        public void TDelete(Booking entity)
        {
            _bookingDAL.Delete(entity);
        }

        public Booking TGetByID(int id)
        {
            return _bookingDAL.GetByID(id);
        }

        public List<Booking> TGetList()
        {
            return _bookingDAL.GetList();
        }

        public void TInsert(Booking entity)
        {
            _bookingDAL.Insert(entity);
        }

        public void TUpdate(Booking entity)
        {
            _bookingDAL.Update(entity);
        }
    }
}