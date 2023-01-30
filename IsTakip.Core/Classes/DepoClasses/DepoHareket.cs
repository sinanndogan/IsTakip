using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Core.Classes.DepoClasses
{
  public class DepoHareket: BaseObject
  {
    public int DepoId { get; set; }
    public Depo Depo{ get; set; }

    public int DepoRafId { get; set; }
    public DepoRaf DepoRaf { get; set; }

  }
}
