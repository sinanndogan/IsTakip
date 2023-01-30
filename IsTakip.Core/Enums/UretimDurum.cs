using System.ComponentModel.DataAnnotations;

namespace IsTakip.Core.Enums
{
	/// <summary>
	/// Üretimin hangi aşamada olduğu bilgisi
	/// </summary>
	public enum UretimDurum
	{
		[Display(Name = "Başlanmadı")]
		Baslanmadi = 0,
		[Display(Name = "İşlemde")]
		Islemde= 1,
		[Display(Name = "Tamamlandı")]
		Tamamlandi= 2
	}
}