using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Core.Helper
{
  public class StringHelper
  {
    public static string Trim(string data)
    {
      if (data is not null)
      {
        data = data.Trim();
      }
      else
      {
        data = string.Empty;
      }

      return data;
    }
  }
}
