using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IsTakip.Core.Classes.MalzemeTipClasses
{
  public class MalzemeTip : BaseObject
  {
    [Required(ErrorMessage = "{0} boş geçilemez")]
    [DisplayName("Depo Tanım")]
    [StringLength(50, ErrorMessage = "{0} {1} karakterden büyük olamaz.")]
    [MinLength(3, ErrorMessage = "{0} {1} karakterden küçük olamaz.")]
    public string Tanim { get; set; }

    [DisplayName("Açıklama")]
    [StringLength(500, ErrorMessage = "{0} {1} karakterden büyük olamaz.")]
    public string Aciklama { get; set; }
  }
}
