using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVSRA.EFModels;

[Table("PhotoGallery")]
public class Photo
{
    [StringLength(200)]
    public string? Caption { get; set; }

    public byte[] Data { get; set; } = null!;

    public DateTime UploadDate { get; set; } = DateTime.Now;

    public string UploadedBy { get; set; } = "Anonymous";
}
