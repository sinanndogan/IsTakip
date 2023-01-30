using IsTakip.Core.Classes.DepoClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Core.Classes.UretimClasses
{
	public class UretimDepoEnvanter : BaseObject
	{
		public Uretim Uretim { get; set; }
		[Display(Name = "Üretim")]
		public int UretimId { get; set; }

		public DepoEnvanter DepoEnvanter { get; set; }

		[Display(Name = "Depo Envanter")]
		public int DepoEnvanterId { get; set; }

		[Display(Name = "Malzeme Adedi")]
		public int MalzemeAdedi { get; set; }
	}
}
