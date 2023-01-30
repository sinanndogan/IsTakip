using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Core.Enums
{
	public enum SurecSayfaGorunumu
	{
		[Display(Name = "Üretim Bazında Gruplama")]
		UretimGrup = 1,
		[Display(Name = "Müşteri Bazında Gruplama")]
		MusteriGrup = 2
	}
}
