using Microsoft.AspNetCore.Mvc;

namespace AFT_BookStore.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Shop()
        {
            return View();
        }
    }
}
