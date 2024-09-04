using DesignPattern.UnitOfWork.ViewModel;
using DesignPatternUnitOfWork.BusinessLayer.Abstract;
using DesignPatternUnitOfWork.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DesignPattern.UnitOfWork.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _CustomerService;

        public CustomerController(ICustomerService CustomerService)
        {
            _CustomerService = CustomerService;
        }
        public IActionResult Index()
        {
            return View();
        }

         [HttpPost]
        public IActionResult Index(CustomerViewModel model)
        {
            var value1 = _CustomerService.TGetById(model.SenderID);
            var value2 = _CustomerService.TGetById(model.ReceiverID);


            value1.CustomerBalance -= model.Amount;
            value2.CustomerBalance += model.Amount;

            List<Customer> modifiedCustomers = new List<Customer>()
            {
                value1,value2
              };
            _CustomerService.TMultiUpdate(modifiedCustomers);
            return View();
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer Customer)
        {
            _CustomerService.TInsert(Customer);
            return RedirectToAction("Index");
        }


        public IActionResult DeleteCustomer(int id)
        {
            var value = _CustomerService.TGetById(id);
            _CustomerService.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            var value = _CustomerService.TGetById(id);
            return View(value);

        }

        [HttpPost]
        public IActionResult UpdateCustomer(Customer Customer)
        {
            _CustomerService.TUpdate(Customer);
            return RedirectToAction("Index");

        }




    }
}
