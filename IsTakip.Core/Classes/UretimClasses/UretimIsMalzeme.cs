using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using IsTakip.Core.Classes.IsClasses;
using IsTakip.Core.Classes.MusteriClasses;

namespace IsTakip.Core.Classes.UretimClasses
{
	/// <summary>
	/// Açılan Üretim Emrinde ait malzemelerin tutulduğu tablo
	/// </summary>
	[Table("UretimIsMalzeme")]
	public class UretimIsMalzeme : BaseObject
	{
		public int UretimId { get; set; }
		public Uretim Uretim { get; set; }

		public int IsMalzemeId { get; set; }
		public IsMalzeme IsMalzeme { get; set; }

		public int IsId { get; set; }
		public Is Is { get; set; }

		[DisplayName("Müşteri")]
		public int MusteriId { get; set; }
		public Musteri Musteri { get; set; }

		[DisplayName("Fatura Kesildi")]
		public bool FaturaKesildi { get; set; }

		[DisplayName("İşlendi")]
		public bool FaturaIslendi { get; set; }

		[DisplayName("Fatura Tutarı")]
		[StringLength(50, ErrorMessage = "{0} {1} karakterdsen büyük olamaz")]
		public string FaturaTutari { get; set; }

		[DisplayName("Fatura Notu")]
		[StringLength(150, ErrorMessage = "{0} {1} karakterden büyük olamaz")]
		public string FaturaNot { get; set; }
	}
}
