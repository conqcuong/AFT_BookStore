using Microsoft.AspNetCore.Mvc;

namespace AFT_BookStore.Controllers
{
    public class AuthController : Controller
    {
        // Action for the login page
        public IActionResult Login()
        {
            return View();
        }

        // Action for the register page
        public IActionResult Register()
        {
            return View();
        }
    }
}
