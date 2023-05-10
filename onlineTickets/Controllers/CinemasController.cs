using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using onlineTickets.Data;

namespace onlineTickets.Controllers
{
    public class CinemasController : Controller
    {

        private readonly AppDbContext _context;

        public CinemasController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allProducts = await _context.Cinemas.ToListAsync();
            return View();
        }
    }
}
