using System.Linq;
using Komis.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Komis.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISamochodRepository _samochodRepository;

        public HomeController(ISamochodRepository samochodRepository)     
        {
            _samochodRepository = samochodRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Tytul = "Przegląd Samochodów";

            var samochody = _samochodRepository.PobierzWszystkieSamochody().OrderBy(s => s.Marka);

            return View(samochody);
        }
    }
}
