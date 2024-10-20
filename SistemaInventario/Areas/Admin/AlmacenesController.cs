using Microsoft.AspNetCore.Mvc;

namespace SistemaInventario.Areas.Admin
{
    [Area("Admin")]
    public class AlmacenesController : Controller
    {
        public AlmacenesController()
        {
            
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
