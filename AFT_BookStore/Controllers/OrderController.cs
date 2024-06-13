using Microsoft.AspNetCore.Mvc;

namespace AFT_BookStore.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OrderingGuide()
        {
            return View();
        }

        public IActionResult ShippingInformation()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }
    }
}
