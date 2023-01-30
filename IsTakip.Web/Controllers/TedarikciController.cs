using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IsTakip.Core.Classes.TedarikciClasses;
using IsTakip.Core.Context;
using IsTakip.Core.Result;
using IsTakip.Core.Helper;
using IsTakip.Core.Enums;

namespace IsTakip.Web.Controllers
{
    public class TedarikciController : Controller
    {
        private readonly DataContext _context;

        public TedarikciController(DataContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tedarikci.Where(t => !t.Silindi).ToListAsync());
        }
        
        public async Task<IActionResult> Details(int? id)
        {
            if (id is null)
                return RedirectToAction(nameof(Index));

            var data = await _context.Tedarikci.FirstOrDefaultAsync(x => x.Id == id);
            if (data is null)
                return RedirectToAction(nameof(Index));

            return View(data);
        }
     
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Tedarikci tedarikci)
        {
            if (_context.Tedarikci.Any(t => t.Tanim == tedarikci.Tanim.Trim() && !t.Silindi))
                ModelState.AddModelError("Tanim", "Eklemek istediğiniz tanım daha önce kayıt edilmiş");

            var resultObject = new ResultObject();

            if (ModelState.IsValid)
            {
                try
                {
                    tedarikci.Tanim = tedarikci.Tanim.Trim();
                    tedarikci.Aciklama = StringHelper.Trim(tedarikci.Aciklama);
                    _context.Add(tedarikci);
                    var result = await _context.SaveChangesAsync();
                    if (result > 0)
                    {
                        resultObject.Mesaj = "Kayıt ekleme başarılı. Yönlendiriliyor...";
                        resultObject.ResultStatus = ResultStatus.Success;
                        resultObject.Url = "/Tedarikci/index";
                    }
                    else
                    {
                        resultObject.Mesaj = $"İşlem sırasında hata oluştu.";
                        resultObject.ResultStatus = ResultStatus.Error;
                    }
                }
                catch (Exception e)
                {
                    resultObject.Mesaj = $"İşlem sırasında hata oluştu. {e.Message}";
                    resultObject.ResultStatus = ResultStatus.Error;
                }
            }
            ViewBag.Result = resultObject;
            return View(tedarikci);
        }       
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null)
                return RedirectToAction(nameof(Index));

            var data = await _context.Tedarikci.FindAsync(id);
            if (data is null)
                return RedirectToAction(nameof(Index));
            return View(data);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Tedarikci tedarikci)
        {
            if (id != tedarikci.Id)
                return RedirectToAction(nameof(Index));

            if (!_context.Tedarikci.Any(e => e.Id == id))
                return RedirectToAction(nameof(Index));

            if (_context.Tedarikci.Any(t => t.Tanim == tedarikci.Tanim.Trim() && !t.Silindi && t.Id != tedarikci.Id))
                ModelState.AddModelError("Tanim", "Güncellemek istediğiniz tanım daha önce kayıt edilmiş");
            var resultObject = new ResultObject();
            if (ModelState.IsValid)
            {
                try
                {
                    var data = await _context.Tedarikci.FirstOrDefaultAsync(t => t.Id == tedarikci.Id);
                    data.Tanim = tedarikci.Tanim.Trim();
                    data.Aciklama = StringHelper.Trim(tedarikci.Aciklama);
                    _context.Update(data);
                    var result = await _context.SaveChangesAsync();

                    if (result > 0)
                    {
                        resultObject.Mesaj = "Kayıt ekleme başarılı. Yönlendiriliyor...";
                        resultObject.ResultStatus = ResultStatus.Success;
                        resultObject.Url = "/MalzemeTip/index";
                    }
                    else
                    {
                        resultObject.Mesaj = $"İşlem sırasında hata oluştu.";
                        resultObject.ResultStatus = ResultStatus.Error;
                    }
                }
                catch (Exception e)
                {
                    resultObject.Mesaj = $"İşlem sırasında hata oluştu. {e.Message}";
                    resultObject.ResultStatus = ResultStatus.Error;
                }
            }
            ViewBag.Result = resultObject;
            return View(tedarikci);
        }        
        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null)
                return RedirectToAction(nameof(Index));

            var data = await _context.MalzemeTip.FirstOrDefaultAsync(m => m.Id == id);
            if (data is null)
                return RedirectToAction(nameof(Index));

            return View(data);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var resultObject = new ResultObject();
            try
            {
                if (_context.Tedarikci.Any(x => x.Id == id))
                {
                    var tedarikci = await _context.Tedarikci.FirstOrDefaultAsync(m => m.Id == id);
                    resultObject.ResultStatus = ResultStatus.Error;
                    ViewBag.Result = resultObject;
                    resultObject.Url = "/Tedarikci/index";
                    return View(tedarikci);
                }
                var data = await _context.Tedarikci.FindAsync(id);
                if (data is null)
                    return RedirectToAction(nameof(Index));
                data.GuncellemeTarihi = DateTime.Now;
                data.GuncelleyenKullanici = "system";
                data.Silindi = true;
                _context.Update(data);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                resultObject.Mesaj = $"İşlem sırasında hata oluştu. {e.Message}";
                resultObject.ResultStatus = ResultStatus.Error;
            }
            ViewBag.Result = resultObject;
            return RedirectToAction(nameof(Index));
        }
    }
}
