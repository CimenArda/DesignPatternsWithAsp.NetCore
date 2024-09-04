using DesignPatternUnitOfWork.DataAccessLayer.Abstract;
using DesignPatternUnitOfWork.DataAccessLayer.Concrete;
using DesignPatternUnitOfWork.DataAccessLayer.Repositories;
using DesignPatternUnitOfWork.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternUnitOfWork.DataAccessLayer.EntityFramework
{
    public class EfProcessDal:GenericRepository<Process>,IProcessDal
    {

        public EfProcessDal(Context context ):base(context)
        {

        }
    }
}
