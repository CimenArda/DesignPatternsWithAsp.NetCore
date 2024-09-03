using Microsoft.AspNetCore.Mvc;
using RepositoryDesignPattern.BusinessLayer.Abstract;
using RepositoryDesignPattern.EntityLayer.Concrete;

namespace RepositoryDesignPattern.PresentationLayer.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _ProductService;

        public ProductController(IProductService ProductService)
        {
            _ProductService = ProductService;
        }

        public IActionResult Index()
        {
            var values = _ProductService.TGetList();
            return View(values);
        }
        public IActionResult Index2()
        {
            var values = _ProductService.TProductListWithCategory();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product Product)
        {
            _ProductService.TInsert(Product);
            return RedirectToAction("Index");
        }


        public IActionResult DeleteProduct(int id)
        {
            var value = _ProductService.TGetByID(id);
            _ProductService.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var value = _ProductService.TGetByID(id);
            return View(value);

        }

        [HttpPost]
        public IActionResult UpdateProduct(Product Product)
        {
            _ProductService.TUpdate(Product);
            return RedirectToAction("Index");

        }
    }
}
