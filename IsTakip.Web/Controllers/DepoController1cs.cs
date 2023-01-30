using IsTakip.Core.Classes.DepoClasses;
using IsTakip.Core.Context;
using IsTakip.Core.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IsTakip.Web.Controllers
{
  public class DepoController1cs : Controller
  {
    readonly IsTakip.Core.Context.DataContext _context;
    public DepoController1cs(IsTakip.Core.Context.DataContext context)
    {
      _context = context;
    }

    public async Task<IActionResult> Index()
    {
      //Depo verilerini select işlemi ile çekiyoruz
      var data = _context.Depo.Where(t => !t.Silindi).ToListAsync();
      return View(data);
    }

    public async Task<IActionResult> Detail(int? id)
    {
      if (id == null)
        return RedirectToAction("Index", "Home");

      // var data = _context.Depo.Where(t => t.Id == id).ToListAsync();

      //var data = _context.Depo.Where(t => t.Id == id).ToList();
      //var data = _context.Depo.Where(t => t.Id == id).FirstOrDefault();
      var data = await _context.Depo.FirstOrDefaultAsync(t => t.Id == id);
      if (data == null)
        return RedirectToAction(nameof(Index));

      return View(data);
    }

    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken] //sayfadan gelen modelin, bizim contex modelimizdeki dataModel ile aynı olup olmadığını kontrol eder.
    public IActionResult Create(Depo model)
    {
      if (ModelState.IsValid)
      {
        model.Tanim = StringHelper.Trim(model.Tanim);
        model.Aciklama = StringHelper.Trim(model.Aciklama);
        model.OlusturanKullanici = "system";
        model.OlusturmaTarihi = DateTime.Now;
        model.GuncelleyenKullanici = "system";
        model.GuncellemeTarihi = DateTime.Now;

        _context.Add(model);
        var result = _context.SaveChanges();

        //todo:resultObject nesnesi tanımalyıp onu çağıralım.
      }
      return View();
    }
  }
}
