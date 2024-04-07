using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVSRA.Shared.EFModels;

[Table("PhotoGallery")]
public class Photo
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [StringLength(200)]
    public string? Caption { get; set; }

    public byte[] Data { get; set; } = null!;

    public string FileType { get; set; } = "image/jpeg";

    public DateTime UploadDate { get; set; } = DateTime.Now;

    public string UploadedBy { get; set; } = "Anonymous";
}
