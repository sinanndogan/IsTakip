using System.ComponentModel.DataAnnotations.Schema;

namespace IsTakip.Core.Classes.IsClasses
{
	/// <summary>
	/// İş kaydı üzerinden eklenen dosyaları tutar.
	/// </summary>
	[Table("IsDosya")]
	public class IsDosya : BaseObject
	{
		public int IsId { get; set; }
		public virtual Is Is { get; set; }

		public string DosyaAdi { get; set; }
	}
}
