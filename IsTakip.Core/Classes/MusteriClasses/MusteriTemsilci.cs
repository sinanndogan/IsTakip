using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsTakip.Core.Classes.MusteriClasses
{
	[Table("MusteriTemsilci")]
	public class MusteriTemsilci : BaseObject
	{
		[DisplayName("Ad Soyad")]
		[StringLength(250, ErrorMessage = "{0} {1} karakterden büyük olamaz")]
		[MinLength(2, ErrorMessage = "{0} {1} karakterden küçük olamaz")]
		[Required(AllowEmptyStrings = false, ErrorMessage = "{0} boş geçilemez")]
		public string AdSoyad { get; set; }

		[DisplayName("Mail Adresi")]
		[Required(ErrorMessage = "{0} Boş Geçilemez")]
		[StringLength(250, ErrorMessage = "{0} {1} karakterden büyük olamaz")]
		[EmailAddress(ErrorMessage = "Geçerli mail adresi giriniz")]
		public string MailAdresi { get; set; }

		[DisplayName("Parola")]
		[Required(ErrorMessage = "{0} boş geçilemez")]
		[StringLength(10, ErrorMessage = "{0} {1} karakterden büyük olamaz")]
		[MinLength(3, ErrorMessage = "{0} {1} karakterden küçük olamaz")]
		public string Parola { get; set; }

		[Required(ErrorMessage = "{0} Boş geçilemez")]
		[DisplayName("Telefon Numarası")]
		[StringLength(15, ErrorMessage = "{0} 10 karakterden büyük olamaz")]
		[MinLength(15, ErrorMessage = "{0} 10 Karakterden Küçük Olamaz")]
		[RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Hatalı Telefon numarası.")]
		public string TelefonNumarasi { get; set; }

		[DisplayName("Mail Bildirimi Gönder")]
		public bool MailBildirimiGonder { get; set; } = false;

		[DisplayName("Sms Bildirimi Gönder")]
		public bool SmsBildirimiGonder { get; set; } = false;

		public int MusteriId { get; set; }
		public virtual Musteri Musteri { get; set; }
	}
}
