using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Core.Enums
{
	public enum MalzemeTransferDurum
	{
		[Display(Name = "Malzeme Talep Bekleniyor")]
		TalepBekleniyor = 0,
		[Display(Name = "Malzeme Talep Edildi")]
		TalepEdildi = 1,
		[Display(Name = "Malzeme Teslim Edildi")]
		TeslimEdildi = 2
	}
}
