using IsTakip.Core.Classes.DurusTipClasses;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsTakip.Core.Classes.UretimClasses
{
	/// <summary>
	/// Üretim e ait duruş bilgilerini tutar.
	/// </summary>
	[Table("UretimDurus")]
	public class UretimDurus : BaseObject
	{
		public int UretimId { get; set; }
		public Uretim Uretim { get; set; }

		public int DurusTipId { get; set; }
		public DurusTip DurusTip { get; set; }

		[DisplayName("Duruş Başlangıç Tarihi")]
		public DateTime DurusBaslamaTarihi { get; set; }

		[DisplayName("Duruş Bitirş Tarihi")]
		public DateTime? DurusBitisTarihi { get; set; }

		public int? DurusSuresi { get; set; }

		[DisplayName("Açıklama")]
		[StringLength(500)]
		[MaxLength(500, ErrorMessage = "{0} {1} karakterden büyük olamaz")]
		public string Aciklama { get; set; }
	}
}
