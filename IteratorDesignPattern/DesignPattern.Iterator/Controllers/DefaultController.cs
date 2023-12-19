using DesignPattern.Iterator.IteratorPattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Iterator.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            VisitRouteMover visitRouteMover = new VisitRouteMover();
            List<string> strings = new List<string>();

            visitRouteMover.AddVisitRoute(new VisitorRoute { CountryName = "Almanya", CityName = "Berlin", VisitPlaceName = "Berlin Kapısı" });
            visitRouteMover.AddVisitRoute(new VisitorRoute { CountryName = "Fransa", CityName = "Paris", VisitPlaceName = "Eyfel Kulesi" });
            visitRouteMover.AddVisitRoute(new VisitorRoute { CountryName = "İtalya", CityName = "Venedik", VisitPlaceName = "Gondol" });
            visitRouteMover.AddVisitRoute(new VisitorRoute { CountryName = "İtalya", CityName = "Roma", VisitPlaceName = "Kolezyum" });
            visitRouteMover.AddVisitRoute(new VisitorRoute { CountryName = "Çek", CityName = "Prag", VisitPlaceName = "Meydan" });

            var iterat

            return View();
        }
    }
}
