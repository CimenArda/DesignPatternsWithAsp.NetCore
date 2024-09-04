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
    public class ProcessManager : IProcessService
    {
        private readonly IProcessDal _ProcessDal;
        private readonly IUOWDal _uowDal;

        public ProcessManager(IProcessDal ProcessDal, IUOWDal uowDal)
        {
            _ProcessDal = ProcessDal;
            _uowDal = uowDal;
        }

        public void TDelete(Process entity)
        {
            _ProcessDal.Delete(entity);
            _uowDal.save();
        }

        public Process TGetById(int id)
        {
            return _ProcessDal.GetById(id);
        }

        public List<Process> TGetList()
        {
            return _ProcessDal.GetList();
        }

        public void TInsert(Process entity)
        {
            _ProcessDal.Insert(entity);
            _uowDal.save();

        }

        public void TMultiUpdate(List<Process> entities)
        {
            _ProcessDal.MultiUpdate(entities);
            _uowDal.save();

        }

        public void TUpdate(Process entity)
        {
            _ProcessDal.Update(entity);
            _uowDal.save();

        }
    }
    }
