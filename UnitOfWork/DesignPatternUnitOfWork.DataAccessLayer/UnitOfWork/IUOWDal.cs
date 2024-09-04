using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternUnitOfWork.DataAccessLayer.UnitOfWork
{
    public interface IUOWDal
    {
        void save();
    }
}
