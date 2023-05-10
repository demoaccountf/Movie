using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using onlineTickets.Data;

namespace onlineTickets.Controllers
{
    public class ProducersController : Controller
    {

        private readonly AppDbContext _context;

        public ProducersController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allProducts = await _context.Producers.ToListAsync();
            return View();
        }
    }
}
