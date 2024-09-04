using DesignPatternUnitOfWork.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternUnitOfWork.DataAccessLayer.UnitOfWork
{
    public class UOWDal : IUOWDal
    {
        private readonly Context _context;

        public UOWDal(Context context)
        {
            _context = context;
        }

        public void save()
        {
           _context.SaveChanges();  
        }
    }
}
