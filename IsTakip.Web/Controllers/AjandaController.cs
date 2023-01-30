using IsTakip.Core.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IsTakip.Web.Controllers
{
    public class AjandaController : Controller
    {
        private readonly DataContext _context;
        public AjandaController(DataContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var ajandas = await _context.Ajanda.Where(x => !x.Silindi).ToListAsync();
            return View(ajandas);
        }
    }
}
