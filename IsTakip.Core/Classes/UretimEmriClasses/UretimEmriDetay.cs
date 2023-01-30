using IsTakip.Core.Classes.DepoClasses;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsTakip.Core.Classes.UretimEmriClasses
{
	[Table("UretimEmriDetay")]
	public class UretimEmriDetay : BaseObject
	{
		public int UretimEmriId { get; set; }
		public UretimEmri UretimEmri { get; set; }

		/// <summary>
		/// Üretimde kullanılacak malzemenin referansı
		/// </summary>
		public int DepoEnvanterId { get; set; }
		public DepoEnvanter  DepoEnvanter { get; set; }

		[Required(ErrorMessage = "{0} Boş geçilemez")]
		[DisplayName("Malzeme Adet")]
		public int MalzemeAdet { get; set; }
	}
}