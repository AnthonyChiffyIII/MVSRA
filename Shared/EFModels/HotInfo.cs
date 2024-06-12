using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVSRA.Shared.EFModels;

[Table("HotInformation")]
public class HotInfo
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    [StringLength(500)]
    public string News { get; set; }

    [Required]
    public DateTime ExpirationDate { get; set; } = DateTime.Now.AddDays(90);

    public DateTime UploadDate { get; set; } = DateTime.Now;

    [StringLength(200)]
    public string UploadedBy { get; set; } = "Anonymous";

    public HotInfo()
    {
        News = string.Empty;
        UploadedBy ??= string.Empty;
    }
}
