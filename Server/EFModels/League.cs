using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVSRA.Server.EFModels;

[Table("Leagues")]
public class League
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    [StringLength(200)]
    public string Name { get; set; }

    [Required]
    [StringLength(500)]
    public string Description { get; set; }

    [StringLength(500)]
    public string? ScheduleURL { get; set; }

    [StringLength(500)]
    public string? RulesURL { get; set; }

    [StringLength(200)]
    public string? Contact { get; set; }

    public DateTime UploadDate { get; set; } = DateTime.Now;

    [StringLength(200)]
    public string UploadedBy { get; set; } = "Anonymous";

    public League()
    {
        Name = string.Empty;
        Description = string.Empty;
        UploadedBy ??= string.Empty;
    }
}
