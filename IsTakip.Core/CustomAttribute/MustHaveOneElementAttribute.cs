using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace IsTakip.Core.CustomAttribute
{
	public class MustHaveOneElementAttribute : ValidationAttribute
	{
		public override bool IsValid(object value)
		{
			return value is IList { Count: > 0 };
		}
	}
}
