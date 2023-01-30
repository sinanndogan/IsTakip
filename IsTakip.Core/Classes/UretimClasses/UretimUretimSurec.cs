using IsTakip.Core.Classes.UretimSurecClasses;
using IsTakip.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Core.Classes.UretimClasses
{
	public class UretimUretimSurec : BaseObject
	{
		public Uretim Uretim { get; set; }
		public int UretimId { get; set; }

		public UretimIsMalzeme UretimIsMalzeme { get; set; }
		public int UretimIsMalzemeId { get; set; }

		public UretimSurec UretimSurec { get; set; }
		public int UretimSurecId { get; set; }

		public UretimDurum UretimDurum { get; set; }

		public DateTime? SurecBaslangic { get; set; }
		public DateTime? SurecBitis { get; set; }

	}
}
