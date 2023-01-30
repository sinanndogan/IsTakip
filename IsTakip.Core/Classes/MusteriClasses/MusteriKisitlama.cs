using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsTakip.Core.Classes.MusteriClasses
{
	[Table("MusteriKisitlama")]
	public class MusteriKisitlama : BaseObject
	{
		[Required(ErrorMessage = "{0} boş geçilemez")]
		[DisplayName("İşlem Açıklama")]
		[StringLength(250, ErrorMessage = "{0} {1} karakterden büyük olamaz")]
		[MinLength(2, ErrorMessage = "{0} {1} karakterden küçük olamaz")]
		public string IslemAciklama { get; set; }

		[DisplayName("Kısıtlansın")]
		public bool Kisitla { get; set; }

		[NotMapped]
		[DisplayName("Kısıtlanma Durumu")]
		public string KisitlaString { get { return Kisitla ? "Kısıtlandı" : "İşlem Açılabilir"; } }

		public int MusteriId { get; set; }
		public virtual Musteri Musteri { get; set; }

		[NotMapped]
		public int? MusteriKisitlamaId { get; set; }
	}
}