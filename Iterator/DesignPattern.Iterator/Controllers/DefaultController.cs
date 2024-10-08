﻿using DesignPattern.Iterator.Iterator;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Iterator.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            VisitRouteMover visitRouteMover = new VisitRouteMover();    
            List<string> strings = new List<string>();


            visitRouteMover.AddVisitRoute(new VisitRoute
            {
                CountryName = "Almanya",
                CityName = "Berlin",
                VisitPlaceName = "Berlim Kapısı"
            });
            visitRouteMover.AddVisitRoute(new VisitRoute
            {
                CountryName = "Fransa",
                CityName = "Paris",
                VisitPlaceName = "Eiffel"
            });
            visitRouteMover.AddVisitRoute(new VisitRoute
            {
                CountryName = "İtalya",
                CityName = "Venedik",
                VisitPlaceName = "Gondol"
            });
            visitRouteMover.AddVisitRoute(new VisitRoute
            {
                CountryName = "İtalya",
                CityName = "Roma",
                VisitPlaceName = "Kolezyum"
            });
            visitRouteMover.AddVisitRoute(new VisitRoute
            {
                CountryName = "Çekya",
                CityName = "Prag",
                VisitPlaceName = "Meydan"
            });

            var iterator = visitRouteMover.CreateIterator();
            while (iterator.NextLocation())
            {
                strings.Add(iterator.CurrentItem.CountryName+iterator.CurrentItem.CityName+iterator.CurrentItem.VisitPlaceName);
            }

            ViewBag.v=strings;
            return View();
        }
    }
}
