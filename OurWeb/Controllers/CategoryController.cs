using Microsoft.AspNetCore.Mvc;

namespace OurWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
