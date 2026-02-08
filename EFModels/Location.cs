using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVSRA.Server.EFModels;

[Table("Locations")]
public class Location
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    [StringLength(200)]
    public string Name { get; set; }

    [Required]
    [StringLength(500)]
    public string Description { get; set; }

    [Required]
    [StringLength(500)]
    public string DirectionsURL { get; set; }

    public DateTime UploadDate { get; set; } = DateTime.Now;

    [StringLength(200)]
    public string UploadedBy { get; set; } = "Anonymous";

    public Location()
    {
        Name = string.Empty;
        Description = string.Empty;
        DirectionsURL = string.Empty;
        UploadedBy ??= string.Empty;
    }

    public virtual List<Photo> Photos { get; set; } = [];
}
