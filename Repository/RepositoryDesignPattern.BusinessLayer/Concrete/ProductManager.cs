using RepositoryDesignPattern.BusinessLayer.Abstract;
using RepositoryDesignPattern.DataAccessLayer.Abstract;
using RepositoryDesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _ProductDal;

        public ProductManager(IProductDal ProductDal)
        {
            _ProductDal = ProductDal;
        }

        public void TDelete(Product t)
        {
            _ProductDal.Delete(t);
        }

        public Product TGetByID(int id)
        {
            return _ProductDal.GetByID(id);
        }

        public List<Product> TGetList()
        {
            return _ProductDal.GetList();
        }

        public void TInsert(Product t)
        {
            _ProductDal.Insert(t);
        }

        public List<Product> TProductListWithCategory()
        {
            return _ProductDal.ProductListWithCategory();
        }

        public void TUpdate(Product t)
        {
            _ProductDal.Update(t);
        }
    }
}
