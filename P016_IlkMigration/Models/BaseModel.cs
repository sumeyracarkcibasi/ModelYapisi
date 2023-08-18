using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P016_IlkMigration.Models
{
  public class BaseModel
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [DisplayName("Durum")]
    public bool Aktif { get; set; }

    [DisplayName("Durum")]
    public string AktifString => Aktif ? "Aktif" : "Pasif";
    }
}
