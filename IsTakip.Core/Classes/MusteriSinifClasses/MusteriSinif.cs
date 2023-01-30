using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsTakip.Core.Classes.MusteriSinifClasses
{
  public class MusteriSinif : BaseObject
  {
    [Required(ErrorMessage = "{0} boş geçilemez")]
    [DisplayName("Müşteri Sınıfı")]
    [StringLength(50, ErrorMessage ="{0} {1} karakterden büyük olamaz.")]
    [MinLength(3,ErrorMessage ="{0} {1} karakterden küçük olamaz.")]
    public string Tanim { get; set; }

    [DisplayName("Açıklama")]
    [StringLength(500, ErrorMessage = "{0} {1} karakterden büyük olamaz.")]
    public string? Aciklama { get; set; }
  }
}
