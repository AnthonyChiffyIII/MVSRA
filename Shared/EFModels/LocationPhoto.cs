using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVSRA.Shared.EFModels;

[Table("PhotoGallery_Locations")]
public class LocationPhoto
{
    [Key, Column(Order = 0)]
    public Guid PhotoGuid { get; set; }
    [ForeignKey(nameof(PhotoGuid))]
    public virtual Photo Photo { get; set; } = null!;

    [Key, Column(Order = 1)]
    public Guid LocationGuid { get; set; }
    [ForeignKey(nameof(LocationGuid))]
    public virtual Location Location { get; set; } = null!;

    public LocationPhoto()
    {

    }
}
