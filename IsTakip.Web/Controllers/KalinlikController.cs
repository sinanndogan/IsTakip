using IsTakip.Core.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IsTakip.Web.Controllers
{
  public class KalinlikController : Controller
  {
    private readonly DataContext _context;
    public KalinlikController(DataContext context)
    {
      _context = context;
    }

    public async Task<IActionResult> Index()
    {
      var kalinlik = await _context.Kalinlik.Where(t => !t.Silindi).ToListAsync();
      return View(kalinlik);
    }
  }
}
