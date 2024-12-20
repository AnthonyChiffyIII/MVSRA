using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVSRA.Server.EFModels;

[Table("PhotoGallery")]
public class Photo
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [StringLength(200)]
    public string? Caption { get; set; }

    public byte[] Data { get; set; } = null!;

    [StringLength(100)]
    public string FileType { get; set; } = "image/jpeg";

    public DateTime UploadDate { get; set; } = DateTime.Now;

    [StringLength(200)]
    public string UploadedBy { get; set; } = "Anonymous";

    public Photo()
    {
        Caption ??= string.Empty;
        FileType ??= string.Empty;
        UploadedBy ??= string.Empty;
        Data ??= [];
    }

    public virtual List<Location> Locations { get; set; } = [];
}
