using System.ComponentModel.DataAnnotations.Schema;
using IsTakip.Core.Classes.MusteriClasses;

namespace IsTakip.Core.Classes.IsClasses
{
	public class IsMusteriTemsilcisi : BaseObject
	{

		public int IsId { get; set; }
		public virtual Is Is { get; set; }

		public int? MusteriTemsilciId { get; set; }

		[ForeignKey("MusteriTemsilciId")]
		public MusteriTemsilci MusteriTemsilci { get; set; }
	}
}