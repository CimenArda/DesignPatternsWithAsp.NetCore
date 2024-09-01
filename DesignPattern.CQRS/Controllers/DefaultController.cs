using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.CQRSPattern.Handlers;
using DesignPattern.CQRS.CQRSPattern.Queries;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.CQRS.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;
        private readonly CreateProductCommandHandler _createProductCommandHandler;
        private readonly GetProductByIdQueryHandler _getProductByIdQueryHandler;
        private readonly DeleteProductCommandHandler _deleteProductCommandHandler;
        private readonly GetProductUpdateByIdQueryHandler _getProductUpdateByIdQueryHandler;
        private readonly UpdateProductCommandHandler _updateProductCommandHandler;

        public DefaultController(GetProductQueryHandler getProductQueryHandler, CreateProductCommandHandler createProductCommandHandler, GetProductByIdQueryHandler getProductByIdQueryHandler, DeleteProductCommandHandler deleteProductCommandHandler, GetProductUpdateByIdQueryHandler getProductUpdateByIdQueryHandler, UpdateProductCommandHandler updateProductCommandHandler)
        {
            _getProductQueryHandler = getProductQueryHandler;
            _createProductCommandHandler = createProductCommandHandler;
            _getProductByIdQueryHandler = getProductByIdQueryHandler;
            _deleteProductCommandHandler = deleteProductCommandHandler;
            _getProductUpdateByIdQueryHandler = getProductUpdateByIdQueryHandler;
            _updateProductCommandHandler = updateProductCommandHandler;
        }

        public IActionResult Index()
        {
            var products = _getProductQueryHandler.Handle();
            return View(products);
        }



        public ActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(CreateProductCommand command)
        {
            _createProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        public ActionResult GetProductById(int id)
        {
            var values = _getProductByIdQueryHandler.Handle(new GetProductByIdQuery(id));
            return View(values);
        }
        public ActionResult DeleteProduct(int id)
        {
            _deleteProductCommandHandler.Handle(new DeleteProductCommand(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateProduct(int id)
        {
            var values = _getProductUpdateByIdQueryHandler.Handle(new GetProductUpdateByIdQuery(id));
            return View(values);
        }


        [HttpPost]
        public ActionResult UpdateProduct(UpdateProductCommand command)
        {
            _updateProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }



    }
}