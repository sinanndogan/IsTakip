using IsTakip.Core.Classes.MusteriClasses;
using IsTakip.Core.Enums;
using Microsoft.AspNetCore.Http;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsTakip.Core.Classes.IsClasses
{
  /// <summary>
  /// Müşteri ile anlaştıktan sonra o müşterinin işlerinin açıldığı ilk tablo
  /// </summary>
  [Table("Is")]
	public sealed class Is : BaseObject
	{
		[Required(ErrorMessage = "Müşteri seçiniz")]
		[DisplayName("Müşteri")]
		public int MusteriId { get; set; }
		public Musteri Musteri { get; set; }

		[DisplayName("Teklifli İş")]
		public bool Teklifli { get; set; }

		[DisplayName("Teklif Fiyatı")]
		public decimal? Fiyat { get; set; }

		[DisplayName("Teklif No")]
		[StringLength(50)]
		[MaxLength(50, ErrorMessage = "{0} {1} karakterden büyük olamaz")]
		public string TeklifNo { get; set; }

		[DisplayName("Teslim Zamanı")]
		public bool OgledenOnceTeslim { get; set; }

		[DisplayName("İş Bitiminde Bildir")]
		public bool IsBitimindeBildir { get; set; }

		[Required(ErrorMessage = "Termin giriniz")]
		[DisplayName("Termin")]
		public DateTime Termin { get; set; }

		[DisplayName("İş Önceliği")]
		public IsOnceligi IsOnceligi { get; set; }

		[Required(ErrorMessage = "Müşteri Sipariş Numarası giriniz")]
		[DisplayName("Müşteri Sipariş Numarası")]
		[StringLength(50)]
		[MaxLength(50, ErrorMessage = "{0} {1} karakterden büyük olamaz")]
		public string MusteriSiparisNo { get; set; }

		[Display(Name = "Fatura")]
		public bool FaturaKesildiMi { get; set; } = false;

		[Display(Name = "İşlendi")]
		public bool IslendiMi { get; set; } = false;

		[Display(Name = "Muhasebe Notu")]
		[MaxLength(500, ErrorMessage = "{0} {1} karakterden büyük olamaz")]
		public string MuhasebeNotu { get; set; }

		[DisplayName("İş Notu")]
		[MaxLength(500, ErrorMessage = "{0} {1} karakterden büyük olamaz")]
		public string ErturIsNotu { get; set; }

		public ICollection<IsMusteriTemsilcisi> IsMusteriTemsilcisi { get; set; }
		public ICollection<IsDosya> IsDosyalari { get; set; }
		public ICollection<IsMalzemeUretimSurec> IsMalzemeUretimSurec { get; set; }
		public ICollection<IsMalzeme> IsMalzemeleri { get; set; }

		#region NotMapped & ViewModel
		[NotMapped]
		public IsMalzeme IsMalzeme { get; set; }

		[NotMapped]
		public string IsMalzemeJson { get; set; }

		[NotMapped]
		public UretimDurum UretimDurum { get; set; }

		[NotMapped]
		[DisplayName("Dosya Ekleri")]
		public List<IFormFile> Files { get; set; }

		[Required(ErrorMessage = "Yetkili seçiniz")]
		[NotMapped]
		[DisplayName("Yetkili Kişiler")]
		public string[] SecilmisPersonel { get; set; }

		[NotMapped]
		public DateTime? UretimBitisTarihi { get; set; }
		#endregion
	}
}