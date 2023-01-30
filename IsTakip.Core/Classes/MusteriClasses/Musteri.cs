using IsTakip.Core.Classes.MusteriSinifClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Core.Classes.MusteriClasses
{
  public class Musteri : BaseObject
  {
		[Required(ErrorMessage = "{0} Boş geçilemez")]
		[DisplayName("Müşteri Tanım")]
		[StringLength(150, ErrorMessage = "{0} {1} karakterden büyük olamaz")]
		[MinLength(3, ErrorMessage = "{0} {1} karakterden küçük olamaz")]
		public string Tanim { get; set; }

		[Required(ErrorMessage = "{0} Boş geçilemez")]
		[DisplayName("Müşteri Sınıfı")]
		public int MusteriSinifId { get; set; }

		public MusteriSinif MusteriSinif { get; set; }

		[DisplayName("Adres")]
		[StringLength(150, ErrorMessage = "{0} {1} karakterden büyük olamaz")]
		[MinLength(3, ErrorMessage = "{0} {1} karakterden küçük olamaz")]
		public string Adres { get; set; }

		[DisplayName("Telefon Numarası")]
		[StringLength(15, ErrorMessage = "{0} 10 karakterden büyük olamaz")]
		[MinLength(15, ErrorMessage = "{0} 10 Karakterden Küçük Olamaz")]
		public string TelefonNumarasi { get; set; }

		[DisplayName("Vergi Dairesi")]
		[StringLength(50, ErrorMessage = "{0} {1} karakterden büyük olamaz")]
		[MinLength(3, ErrorMessage = "{0} {1} Karakterden Küçük Olamaz")]
		public string VergiDairesi { get; set; }

		[DisplayName("Vergi Numarası")]
		[StringLength(10, ErrorMessage = "{0} {1} karakterden büyük olamaz")]
		[MinLength(10, ErrorMessage = "{0} {1} Karakterden Küçük Olamaz")]
		[RegularExpression("^[0-9]*$", ErrorMessage = "Vergi Numarası sadece rakam içermelidir")]
		public string VergiNumarasi { get; set; }

		[DisplayName("Açıklama")]
		[StringLength(500)]
		[MaxLength(500, ErrorMessage = "{0} {1} karakterden büyük olamaz")]
		public string Aciklama { get; set; }

		[NotMapped]
		[DisplayName("TanimveMusteriSinif")]
		public string TanimveMusteriSinif { get { return $"{Tanim} ({MusteriSinif?.Tanim})"; } }

		public ICollection<MusteriKisitlama> MusteriKisitlama { get; set; }
		public ICollection<MusteriTemsilci> MusteriTemsilci { get; set; }
	}
}
