using DesignPattern.Facade.DAL;
using DesignPattern.Facade.Facade;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Facade.Controllers
{
    public class OrderController : Controller
    {
        Context context = new Context();
        OrderFacade orderFacade = new OrderFacade();

        [HttpGet]
        public IActionResult OrderStart()
        {
            return View();
        }
        public IActionResult OrderStart(int id)
        {
            orderFacade.CompleteOrder(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult OrderDetailStart()
        {
            return View();
        }
        [HttpPost]
        public IActionResult OrderDetailStart(int CustomerID, int ProductID, int OrderID, int ProductCount, decimal ProductPrice)
        {
            orderFacade.CompleteOrderDetail(CustomerID,ProductID,OrderID,ProductCount,ProductPrice);
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            var values = context.Orders.ToList();
            return View(values);
        }
    }
}
