using IsTakip.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsTakip.Core.Result
{
	public class ResultObject
	{
		public ResultStatus ResultStatus { get; set; }
		public string Mesaj { get; set; }
		public string Url { get; set; }
	}
}
