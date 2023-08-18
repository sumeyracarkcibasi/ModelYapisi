using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P016_IlkMigration.Models
{
  //[Table("Urunler")]
  public class Urun : BaseModel
  {
    [Required(ErrorMessage = "{0} boş geçilemez.")]
    //[Display(Name ="Ürün Kodu")]
    [DisplayName("Ürün Kodu")]
    [StringLength(100, ErrorMessage = "{0} {1} karakterden fazla olamaz.")]
    [MinLength(3, ErrorMessage = "{0} en az {1} karkater olmalıdır")]
    public string UrunKodu { get; set; }

    [Required(ErrorMessage = "{0} boş geçilemez.")]
    [DisplayName("Ürün Tanım")]
    [StringLength(150, ErrorMessage = "{0} {1} karakterden fazla olamaz.")]
    [MinLength(5, ErrorMessage = "{0} en az {1} karkater olmalıdır")]
    public string UrunTanim { get; set; }

    [Required(ErrorMessage = "{0} boş geçilemez.")]
    public int Miktar { get; set; }
  }
}
