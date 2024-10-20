using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace SistemaInventario.Areas.Cliente.Controllers
{
    [Area("Cliente")]
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
