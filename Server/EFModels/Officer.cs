using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVSRA.Server.EFModels;

[Table("ActiveOfficers")]
public class Officer
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    [StringLength(200)]
    public string Position { get; set; }

    [Required]
    [StringLength(200)]
    public string Name { get; set; }

    public DateTime UploadDate { get; set; } = DateTime.Now;

    [StringLength(200)]
    public string UploadedBy { get; set; } = "Anonymous";

    public Officer()
    {
        Position = "Officer";
        Name = "Vacant";
        UploadedBy ??= string.Empty;
    }
}
