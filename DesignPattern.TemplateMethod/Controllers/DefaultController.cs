using DesignPattern.TemplateMethod.TemplateMethod;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.TemplateMethod.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicPlanIndex()
        {
            NetflixPlans netflixPlans = new BasicPlan();

            ViewBag.v1 = netflixPlans.PlanType("Temel Plan");
            ViewBag.v2 = netflixPlans.CountPerson(2);
            ViewBag.v3 = netflixPlans.Price(145.90);
            ViewBag.v4 = netflixPlans.Resolution("480px");
            ViewBag.v5 = netflixPlans.Content("Film-Dizi");


            return View();
        }

        public IActionResult StandartPlanIndex()
        {
            NetflixPlans netflixPlans = new BasicPlan();

            ViewBag.v1 = netflixPlans.PlanType("Standart Plan");
            ViewBag.v2 = netflixPlans.CountPerson(4);
            ViewBag.v3 = netflixPlans.Price(225.50);
            ViewBag.v4 = netflixPlans.Resolution("720px");
            ViewBag.v5 = netflixPlans.Content("Film-Dizi,Futbol");


            return View();
        }

        public IActionResult UltraPlanIndex()
        {
            NetflixPlans netflixPlans = new BasicPlan();

            ViewBag.v1 = netflixPlans.PlanType("Ultra Plan");
            ViewBag.v2 = netflixPlans.CountPerson(6);
            ViewBag.v3 = netflixPlans.Price(300.00);
            ViewBag.v4 = netflixPlans.Resolution("1080px");
            ViewBag.v5 = netflixPlans.Content("Film-Dizi,Futbol,Animasyon,Youtube,Belgesel");


            return View();
        }
    }
}
