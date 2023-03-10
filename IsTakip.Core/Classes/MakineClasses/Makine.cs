using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IsTakip.Core.Classes.MakineClasses
{
  public class Makine : BaseObject
  {
    [Required(ErrorMessage = "{0} boş geçilemez")]
    [DisplayName("Makine Tanım")]
    [StringLength(50, ErrorMessage = "{0} {1} karakterden büyük olamaz.")]
    [MinLength(3, ErrorMessage = "{0} {1} karakterden küçük olamaz.")]
    public string Tanim { get; set; }
  }
}
