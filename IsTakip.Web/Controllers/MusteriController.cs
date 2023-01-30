using IsTakip.Core.Classes.MusteriClasses;
using IsTakip.Core.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace IsTakip.Web.Controllers
{
  public class MusteriController : Controller
  {
    private readonly DataContext _context;
    public MusteriController(DataContext context) : base()
    {
      _context = context;
    }

    public async Task<IActionResult> Index()
    {
      //var model = await _context.Musteri.Include(t => t.MusteriSinif).ToListAsync();
      var model = await MusterininSonKisitlamaBilgisiniGetir(await _context.Musteri
      .Include(x => x.MusteriSinif).Where(t => !t.Silindi)
      .Include(x => x.MusteriKisitlama.Where(t => !t.Silindi))
      .ToListAsync());

      return View();
    }
    //Müşterinin son kısıtlama bilgisini almak istiyoruz.
    public async Task<IEnumerable<Musteri>> MusterininSonKisitlamaBilgisiniGetir(List<Musteri> _numerable)
    {
      foreach (var item in _numerable)
      {
        if (item.MusteriKisitlama.Count is 1 or 0)
          continue;

        var liste = item.MusteriKisitlama.ToList();
        liste.RemoveRange(0, item.MusteriKisitlama.Count - 1);
        item.MusteriKisitlama = liste;
      }
      return _numerable;
    }

    public async Task<IActionResult> Create()
    {
      ViewData["MusteriSinif"] = 
      new SelectList(await _context.MusteriSinif.Where(t => !t.Silindi).ToListAsync(), "Id", "Tanim");


      return View();
    }

  }
}
