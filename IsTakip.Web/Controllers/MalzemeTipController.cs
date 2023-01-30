using IsTakip.Core.Classes.MalzemeTipClasses;
using IsTakip.Core.Context;
using IsTakip.Core.Enums;
using IsTakip.Core.Helper;
using IsTakip.Core.Result;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace IsTakip.Web.Controllers
{
	public class MalzemeTipController:Controller
	{
		private readonly DataContext _context;

		public MalzemeTipController(DataContext context) : base()
		{
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			return View(await _context.MalzemeTip.Where(t => !t.Silindi).ToListAsync());
		}

		public async Task<IActionResult> Details(int? id)
		{
			if (id is null)
				return RedirectToAction(nameof(Index));

			var data = await _context.MalzemeTip.FirstOrDefaultAsync(m => m.Id == id);
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
		public async Task<IActionResult> Create(MalzemeTip model)
		{
			if (_context.MalzemeTip.Any(t => t.Tanim == model.Tanim.Trim() && !t.Silindi))
				ModelState.AddModelError("Tanim", "Eklemek istediğiniz tanım daha önce kayıt edilmiş");

			var resultObject = new ResultObject();

			if (ModelState.IsValid)
			{
				try
				{
					model.Tanim = model.Tanim.Trim();
					model.Aciklama = StringHelper.Trim(model.Aciklama);

					_context.Add(model);
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
			return View(model);
		}

		public async Task<IActionResult> Edit(int? id)
		{
			if (id is null)
				return RedirectToAction(nameof(Index));

			var data = await _context.MalzemeTip.FindAsync(id);
			if (data is null)
				return RedirectToAction(nameof(Index));

			return View(data);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, MalzemeTip model)
		{
			if (id != model.Id)
				return RedirectToAction(nameof(Index));

			if (!_context.MalzemeTip.Any(e => e.Id == id))
				return RedirectToAction(nameof(Index));

			if (_context.MalzemeTip.Any(t => t.Tanim == model.Tanim.Trim() && !t.Silindi && t.Id != model.Id))
				ModelState.AddModelError("Tanim", "Güncellemek istediğiniz tanım daha önce kayıt edilmiş");

			var resultObject = new ResultObject();

			if (ModelState.IsValid)
			{
				try
				{
					var data = await _context.MalzemeTip.FirstOrDefaultAsync(t => t.Id == model.Id);

					data.Tanim = model.Tanim.Trim();
					data.Aciklama = StringHelper.Trim(model.Aciklama);

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
			return View(model);
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
				//Bu Malzeme Tipi "İş" tablosunda varsa silinmesine izin verilmeyecek.
				if (_context.IsMalzeme.Any(x => x.MalzemeTipId == id))
				{
					var malzemeTip = await _context.MalzemeTip.FirstOrDefaultAsync(m => m.Id == id);
					resultObject.Mesaj = $"Malzeme Tipi önceki açılan bir iş içinde kullanıldığı için silinemez.";
					resultObject.ResultStatus = ResultStatus.Error;
					ViewBag.Result = resultObject;
					resultObject.Url = "/MalzemeTip/index";
					return View(malzemeTip);
				}

				var data = await _context.MalzemeTip.FindAsync(id);

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