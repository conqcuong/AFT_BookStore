using Microsoft.AspNetCore.Mvc;

namespace AFT_BookStore.Controllers
{
    public class PostsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
