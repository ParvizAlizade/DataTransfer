using Microsoft.AspNetCore.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class CountryController : Controller
    {
        public List<Countries> Countries;
        public CountryController()
        {
            Countries = new List<Countries>()
            {
                new Countries()
                {
                    Id = 1,
                    Name="Afganistan",
                    FlagPhoto="https://www.who.int/images/default-source/countries-overview/flags/afg.tmb-768v.jpg",
                    Population=132,
                    Territory=76.8
                },
                new Countries()
                {
                    Id = 2,
                    Name="Albania",
                    FlagPhoto="https://www.who.int/images/default-source/countries-overview/flags/alb.tmb-768v.jpg",
                    Population=403.9,
                    Territory=132.3
                },

                  new Countries()
                {
                    Id = 3,
                    Name="Bahamas",
                    FlagPhoto="https://www.who.int/images/default-source/countries-overview/flags/bhs.tmb-768v.jpg",
                    Population=28.7,
                    Territory=13.6
                },

                   new Countries()
                {
                    Id =4,
                    Name="Belgium",
                    FlagPhoto="https://www.who.int/images/default-source/countries-overview/flags/bel.tmb-768v.jpg",
                    Population=382.2,
                    Territory=567.3,
                },
                new Countries()
                {
                    Id = 5,
                    Name="Banglades",
                    FlagPhoto="https://www.who.int/images/default-source/countries-overview/flags/bgd.tmb-768v.jpg",
                    Population=144.4,
                    Territory=38.1
                },
                new Countries()
                {
                    Id = 6,
                    Name="Argentina",
                    FlagPhoto="https://www.who.int/images/default-source/countries-overview/flags/arg.tmb-768v.jpg",
                    Population=1.6,
                    Territory=496.9
                },
                new Countries()
                {
                    Id = 7,
                    Name="Brazil",
                    FlagPhoto="https://www.who.int/images/default-source/countries-overview/flags/bra.tmb-768v.jpg",
                    Population=875.4,
                    Territory=982.00,
                },
                new Countries()
                {
                    Id = 8,
                    Name="Australia",
                    FlagPhoto="https://www.who.int/images/default-source/countries-overview/flags/aus.tmb-768v.jpg",
                    Population=543.6,
                    Territory=234.50
                },
                new Countries()
                {
                    Id = 9,
                    Name="Belarus",
                    FlagPhoto="https://www.who.int/images/default-source/countries-overview/flags/blr.tmb-768v.jpg",
                    Population=23.7,
                    Territory=45.00
                },
                 new Countries()
                {
                    Id = 10,
                    Name="Bhutan",
                    FlagPhoto="https://www.who.int/images/default-source/countries-overview/flags/brn.tmb-768v.jpg",
                    Population=14.2,
                    Territory=767.8
                },
                new Countries()
                {
                    Id = 11,
                    Name="Chile",
                    FlagPhoto="https://www.who.int/images/default-source/countries-overview/flags/chl.tmb-768v.jpg",
                    Population=455.64,
                    Territory=239.2
                },
                new Countries()
                {
                    Id =12 ,
                    Name="China",
                    FlagPhoto="https://www.who.int/images/default-source/countries-overview/flags/chn.tmb-768v.jpg",
                    Population=879.5,
                    Territory=6500.3
                },


            };
        }
        public IActionResult Index()
        {
            
            return View(Countries);
        }
    }
}
