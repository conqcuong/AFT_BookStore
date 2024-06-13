using Microsoft.AspNetCore.Mvc;

namespace AFT_BookStore.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
