using System.ComponentModel.DataAnnotations.Schema;
using IsTakip.Core.Classes.UretimSurecClasses;

namespace IsTakip.Core.Classes.IsClasses
{
	/// <summary>
	/// Açılan işe ait malzemelerin Üretim Süreçlerini tutulduğu tablo
	/// </summary>
	[Table("IsMalzemeUretimSurec")]
	public class IsMalzemeUretimSurec : BaseObject
	{
		public int IsMalzemeId { get; set; }
		public IsMalzeme IsMalzeme { get; set; }

		public int UretimSurecId { get; set; }
		public UretimSurec UretimSurec { get; set; }
	}
}