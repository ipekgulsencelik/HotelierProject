﻿using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.DataAccessLayer.Abstract;
using HotelierProject.EntityLayer.Concrete;

namespace HotelierProject.BusinessLayer.Concrete
{
    public class StaffManager : IStaffService
    {
        private readonly IStaffDAL _staffDAL;

        public StaffManager(IStaffDAL staffDAL)
        {
            _staffDAL = staffDAL;
        }

        public void TDelete(Staff entity)
        {
            _staffDAL.Delete(entity);
        }

        public Staff TGetByID(int id)
        {
            return _staffDAL.GetByID(id);
        }

        public List<Staff> TGetList()
        {
            return _staffDAL.GetList();
        }

        public void TInsert(Staff entity)
        {
            _staffDAL.Insert(entity);
        }

        public void TUpdate(Staff entity)
        {
            _staffDAL.Update(entity);
        }
    }
}