using IsTakip.Core.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsTakip.Core.Classes.UretimSurecClasses
{
	/// <summary>
	/// Üretim Süreç bilgisinin tanım tablosu Ör: Lazer Kesim, Makas
	/// </summary>
	[Table("UretimSurec")]
	public class UretimSurec : BaseObject
	{
		[Required(ErrorMessage = "{0} Boş geçilemez")]
		[DisplayName("Süreç Tanım")]
		[StringLength(50, ErrorMessage = "{0} {1} karakterden büyük olamaz")]
		[MinLength(3, ErrorMessage = "{0} {1} karakterden küçük olamaz")]
		public string Tanim { get; set; }

		[DisplayName("Açıklama")]
		[StringLength(500)]
		[MaxLength(500, ErrorMessage = "{0} {1} karakterden büyük olamaz")]
		public string Aciklama { get; set; }

		[DisplayName("Renk Kodu")]
		[Required(ErrorMessage = "{0} Boş geçilemez")]
		public string RenkKodu { get; set; }

		[Display(Name = "Sıra No")]
		[Required(ErrorMessage = "{0} Boş geçilemez")]
		public int SiraNo { get; set; }

		[Display(Name = "Sayfa Görünümü")]
		[Required(ErrorMessage = "{0} Boş Geçilemez")]
		public SurecSayfaGorunumu SurecSayfaGorunumu { get; set; }

		[Display(Name = "Müşteri Görünsün Mü?")]
		public bool KolonMusteri { get; set; }
		[Display(Name = "Program Görünsün Mü?")]
		public bool KolonProgram { get; set; }
		[Display(Name = "Makine Görünsün Mü?")]
		public bool KolonMakine { get; set; }
		[Display(Name = "Kalınlık Görünsün Mü?")]
		public bool KolonKalinlik { get; set; }
	}
}