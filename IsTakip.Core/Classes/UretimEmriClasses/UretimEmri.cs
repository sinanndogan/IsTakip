using IsTakip.Core.Classes.MalzemeTipClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsTakip.Core.Classes.UretimEmriClasses
{
	/// <summary>
	/// Üretim Emirlerinin Ana Tablosu
	/// </summary>
	[Table("UretimEmri")]
	public class UretimEmri : BaseObject
	{
		[Required(ErrorMessage = "{0} Boş geçilemez")]
		[DisplayName("Program Adı")]
		[StringLength(50, ErrorMessage = "{0} {1} karakterden büyük olamaz")]
		[MinLength(3, ErrorMessage = "{0} {1} karakterden küçük olamaz")]
		public string ProgramAdi { get; set; }

		[Required(ErrorMessage = "{0} Boş geçilemez")]
		[DisplayName("Üretim Kodu")]
		[StringLength(50, ErrorMessage = "{0} {1} karakterden büyük olamaz")]
		public string UretimKodu { get; set; }

		[Required(ErrorMessage = "{0} Boş geçilemez")]
		[DisplayName("Malzeme Tip")]
		public int MalzemeTipId { get; set; }
		public MalzemeTip MalzemeTip { get; set; }

		/// <summary>
		/// Bu ÜretimEmrinde toplam kaç adet bu Malzeme Tipinden kullanılacağını tutar.
		/// </summary>
		[Required(ErrorMessage = "{0} Boş geçilemez")]
		[DisplayName("Malzeme Adet")]
		public int MalzemeAdet { get; set; }

		public ICollection<UretimEmriDetay> UretimEmriDetay { get; set; }

		[DisplayName("Üretim Başlama Tarihi")]
		public DateTime? UretimBaslamaTarihi { get; set; }

		[DisplayName("Üretim Bitirş Tarihi")]
		public DateTime? UretimBitisTarihi { get; set; }

	}
}