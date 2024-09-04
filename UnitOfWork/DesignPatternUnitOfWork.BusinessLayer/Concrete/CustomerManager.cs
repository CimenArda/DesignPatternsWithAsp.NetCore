using DesignPatternUnitOfWork.BusinessLayer.Abstract;
using DesignPatternUnitOfWork.DataAccessLayer.Abstract;
using DesignPatternUnitOfWork.DataAccessLayer.UnitOfWork;
using DesignPatternUnitOfWork.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternUnitOfWork.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        private readonly IUOWDal _uowDal;

        public CustomerManager(ICustomerDal customerDal, IUOWDal uowDal)
        {
            _customerDal = customerDal;
            _uowDal = uowDal;
        }

        public void TDelete(Customer entity)
        {
           _customerDal.Delete(entity);
            _uowDal.save(); 
        }

        public Customer TGetById(int id)
        {
          return _customerDal.GetById(id);
        }

        public Customer TGetByID(int id)
        {
            return _customerDal.GetById(id);
        }

        public List<Customer> TGetList()
        {
            return _customerDal.GetList();
        }

        public void TInsert(Customer entity)
        {
             _customerDal.Insert(entity);
            _uowDal.save();

        }

        public void TMultiUpdate(List<Customer> entities)
        {
            _customerDal.MultiUpdate(entities);
            _uowDal.save();

        }

        public void TUpdate(Customer entity)
        {
           _customerDal.Update(entity);
            _uowDal.save();

        }
    }
}
