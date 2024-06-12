using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVSRA.Shared.EFModels;

[Table("PhotoGallery_HomePage")]
public class HomePagePhoto
{
    [Key]
    public Guid PhotoGuid { get; set; }
    [ForeignKey(nameof(PhotoGuid))]
    public virtual Photo Photo { get; set; } = null!;

    public HomePagePhoto()
    {

    }
}
