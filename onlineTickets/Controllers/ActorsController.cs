using Microsoft.AspNetCore.Mvc;
using onlineTickets.Data;
using onlineTickets.Data.Services;

namespace onlineTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;
        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }


        // Get: Actors/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

    }
}
