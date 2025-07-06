using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVSRA.Server.EFModels;

[Table("PhotoGallery_HomePage")]
public class HomePagePhoto
{
    [Key]
    public Guid PhotosId { get; set; }
    [ForeignKey(nameof(PhotosId))]
    public virtual Photo Photo { get; set; } = null!;

    public HomePagePhoto()
    {

    }
}
