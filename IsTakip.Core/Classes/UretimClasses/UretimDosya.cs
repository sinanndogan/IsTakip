using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsTakip.Core.Classes.UretimClasses
{
	/// <summary>
	/// Üretim e ait dosya/dosyaların bilgilerini tutar.
	/// </summary>
	[Table("UretimDosya")]
	public class UretimDosya : BaseObject
	{
		public int UretimId { get; set; }
		public Uretim Uretim { get; set; }

		[DisplayName("Dosya Adı")]
		public string DosyaAdi{ get; set; }
	}
}