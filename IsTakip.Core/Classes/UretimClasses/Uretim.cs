using IsTakip.Core.Classes.MakineClasses;
using IsTakip.Core.Classes.MalzemeTipClasses;
using IsTakip.Core.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsTakip.Core.Classes.UretimClasses
{
  /// <summary>
  /// Üretim Emirlerinin Ana Tablosu
  /// </summary>
  [Table("Uretim")]
	public class Uretim : BaseObject
	{
		[Required(ErrorMessage = "{0} Boş geçilemez")]
		[DisplayName("Program Adı")]
		[StringLength(50, ErrorMessage = "{0} {1} karakterden büyük olamaz")]
		[MinLength(3, ErrorMessage = "{0} {1} karakterden küçük olamaz")]
		public string ProgramAdi { get; set; }

		[Required(ErrorMessage = "{0} Boş geçilemez")]
		[DisplayName("Üretim Kodu")]
		[StringLength(50, ErrorMessage = "{0} {1} karakterden büyük olamaz")]
		public string UretimKodu { get; set; }

		[Required(ErrorMessage = "{0} Boş geçilemez")]
		[DisplayName("Malzeme Tip")]
		public int MalzemeTipId { get; set; }
		public MalzemeTip MalzemeTip { get; set; }


		[DisplayName("Malzeme Transfer Durumu")]
		public MalzemeTransferDurum MalzemeTransferDurum { get; set; }

		//[DisplayName("Üretimi Yapan Operatör")]
		//public int? KullaniciId { get; set; }
		//public Kullanici Kullanici { get; set; }

		[DisplayName("Üretim Başlama Tarihi")]
		public DateTime? UretimBaslamaTarihi { get; set; }

		[DisplayName("Üretim Bitirş Tarihi")]
		public DateTime? UretimBitisTarihi { get; set; }

		[DisplayName("Makine")]
		public int? MakineId { get; set; }
		public Makine Makine { get; set; }

		[Display(Name = "Not")]
		public string Not { get; set; }

		public UretimDurum UretimDurum { get; set; }

		/// <summary>
		/// Üretim işleminde hangi müşterilerin hangi işlerinin olduğu tutulur. Bu işlerin Muhasebesel işlemlerini de bu yapıda tutuyoruz.
		/// </summary>
		public ICollection<UretimIsMalzeme> UretimIsMalzeme { get; set; }

		public ICollection<UretimDurus> UretimDurus { get; set; }
		public ICollection<UretimDosya> UretimDosya { get; set; }

		public ICollection<UretimDepoEnvanter> UretimDepoEnvanter { get; set; }

		public ICollection<UretimUretimSurec> UretimUretimSurec{ get; set; }
	}
}