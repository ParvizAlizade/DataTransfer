using Microsoft.AspNetCore.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class ContinentController : Controller
    {
        List<Continents> Continents;
        public ContinentController()
        {
            Continents = new List<Continents>()
            {
               new Continents()
               {
                   Id = 1,
                  ContinentName="Asia"
               },

               new Continents()
               {
                   Id = 2,
                  ContinentName="Europe"
               },
                new Continents()
               {
                   Id = 3,
                  ContinentName="South America"
               },
                new Continents()
               {
                   Id = 4,
                  ContinentName="Africa"
               },
                 new Continents()
               {
                   Id = 5,
                  ContinentName="Australia"
               },
                  new Continents()
               {
                   Id = 6,
                  ContinentName="North America"
               },
            };

        }
        public IActionResult Index()
        {
            return View(Continents);
        }
    }
}
