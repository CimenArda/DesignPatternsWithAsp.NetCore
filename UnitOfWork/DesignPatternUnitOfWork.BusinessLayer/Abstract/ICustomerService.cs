using DesignPatternUnitOfWork.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternUnitOfWork.BusinessLayer.Abstract
{
    public interface ICustomerService : IGenericService<Customer>
    {
        Customer TGetByID(int id);
    }
}
