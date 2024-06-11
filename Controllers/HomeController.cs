using abs38.Data;
using abs38.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace abs38.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var list = _context.projektbeteiligten.ToList();
            return View(list);
        }

    }
}
