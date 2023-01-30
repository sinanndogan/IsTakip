using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using IsTakip.Core.Classes.MusteriClasses;

namespace IsTakip.Core.Classes.AjandaClasses
{
	[Table("Ajanda")]
	public class Ajanda : BaseObject
	{
		[Required(ErrorMessage = "{0} Boş geçilemez")]
		[DisplayName("Not")]
		[StringLength(500, ErrorMessage = "{0} {1} karakterden büyük olamaz")]
		public string Note { get; set; }

		[DisplayName("Müşteri")]
		public int? MusteriId { get; set; }
		public Musteri Musteri { get; set; }
	}
}
