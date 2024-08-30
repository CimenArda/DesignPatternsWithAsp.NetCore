using DesignPattern.ChainOfResponsibility.ChainOfResponsibility;
using DesignPattern.ChainOfResponsibility.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.ChainOfResponsibility.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CustomerProcessViewModel model)
        {
            Employee treasurer = new Treasurer();
            Employee managerassistant = new ManagerAssistant();
            Employee manager = new Manager();
            Employee areadirector = new AreaDirector();

            treasurer.setNextApprover(managerassistant);
            managerassistant.setNextApprover(manager);
            manager.setNextApprover(areadirector);

            treasurer.ProcessRequest(model);
            return View();
        }
    }
}
