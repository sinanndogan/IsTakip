using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Core.Classes
{
  public class BaseObject
  {
    [Key] // Kolonun Primary Key olmasını sağlar
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // kolon içindeki verinin 1 den başlayarak birer birer artmasını sağlar
    public int Id { get; set; }

    [DefaultValue(0)] // eğer bizden bir değer gelmezse veritabanında bu alana sıfır verisini ekler
    public int OlusturanKullanciId { get; set; }

    [ScaffoldColumn(false)] // biz istemediğimiz sürece ekrana getirilemez ve düzenlenemez alan oluştur
    [Browsable(false)] // biz istemediğimiz sürece grid alanlarında (ModelItem) görünmez
    [StringLength(50)]
    [DisplayName("Oluşturan Kullanıcı")]
    public string? OlusturanKullanici { get; set; }

    [ScaffoldColumn(false)] 
    [Browsable(false)] 
    [DisplayName("Oluşturma Tarihi")]
    public DateTime OlusturmaTarihi { get; set; }

    [DefaultValue(0)]
    public int GuncelleyenKullanciId { get; set; }

    [ScaffoldColumn(false)] 
    [Browsable(false)] 
    [StringLength(50)]
    [DisplayName("Güncelleyen Kullanıcı")]
    public string? GuncelleyenKullanici { get; set; }

    [ScaffoldColumn(false)]
    [Browsable(false)]
    [DisplayName("Güncelleme Tarihi")]
    public DateTime GuncellemeTarihi { get; set; }

    [DisplayName("Aktif")]
    public bool Aktif { get; set; }

    [ScaffoldColumn(false)]
    [DisplayName("Silinme Durumu")]
    public bool Silindi { get; set; }

    [DisplayName("Durum")]
    public string IsAktifString => Aktif ? "Aktif" : "Pasif";

    [DisplayName("Silindi")]
    public string IsSilindiString => Silindi ? "Evet" : "";
  }
}
