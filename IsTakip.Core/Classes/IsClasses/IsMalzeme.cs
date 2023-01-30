using IsTakip.Core.Classes.KalinlikClasses;
using IsTakip.Core.Classes.MalzemeTipClasses;
using IsTakip.Core.Classes.UretimClasses;
using IsTakip.Core.Classes.UretimSurecClasses;
using IsTakip.Core.CustomAttribute;
using IsTakip.Core.Enums;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace IsTakip.Core.Classes.IsClasses
{
	/// <summary>
	/// Açılan işe ait malzemelerin tutulduğu tablo
	/// </summary>
	[Table("IsMalzeme")]
	public class IsMalzeme : BaseObject
	{
		public int IsId { get; set; }
		public Is Is { get; set; }

		[Required(ErrorMessage = "{0} Boş geçilemez")]
		[DisplayName("Malzeme Tip")]
		[Range(1, int.MaxValue, ErrorMessage = "{0} Seçiniz")]
		public int MalzemeTipId { get; set; }
		public MalzemeTip MalzemeTip { get; set; }

		[Required(ErrorMessage = "{0} Boş geçilemez")]
		[DisplayName("Kalınlık")]
		[Range(1, int.MaxValue, ErrorMessage = "{0} Seçiniz")]
		public int KalinlikId { get; set; }
		public Kalinlik Kalinlik { get; set; }

		[DisplayName("İşçilik")]
		public bool Iscilik { get; set; }

		[DisplayName("Malzeme Notu")]
		public string MalzemeNotu { get; set; }

		public bool UretimEmriVar { get; set; } = false;

		[NotMapped]
		public int UretimId { get; set; }
		public ICollection<IsMalzemeUretimSurec> IsMalzemeUretimSurec { get; set; }



		#region NotMapped
		[NotMapped]
		[DisplayName("Üretim Süreçleri")]
		[MustHaveOneElement(ErrorMessage = "Üretim Süreç Seçiniz")]
		public string[] SecilmisUretimSurec { get; set; }

		[NotMapped]
		public ICollection<UretimSurec> UretimSurecleri { get; set; }

		[NotMapped]
		public SelectList Kalinliklar { get; set; }

		[NotMapped]
		public SelectList MalzemeTipleri { get; set; }

		[NotMapped]
		public UretimDurum UretimDurum { get; set; } = UretimDurum.Baslanmadi;

		[NotMapped]
		public ICollection<UretimUretimSurec> UretimUretimSurec { get; set; }

		[NotMapped]
		public ICollection<UretimDosya> UretimDosya { get; set; }

		[NotMapped]
		public int? UretimSuresi { get; set; }

		[NotMapped]
		public int? UretimDurusSuresi { get; set; }
		#endregion
	}
}