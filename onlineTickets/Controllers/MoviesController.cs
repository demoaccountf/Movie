using Microsoft.AspNetCore.Mvc;

namespace onlineTickets.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
