using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Core.Enums
{
  public enum IsOnceligi
  {
    [Display(Name = "Düşük Öncelikli")]
    Dusuk = 0,
    [Display(Name = "Orta Öncelikli")]
    Orta = 1,
    [Display(Name = "Yüksek Öncelikli")]
    Yuksek = 2
  }
}
