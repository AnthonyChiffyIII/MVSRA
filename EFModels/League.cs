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
    public string Description { get; set; } = string.Empty;

    [StringLength(500)]
    public string? WebsiteURL { get; set; }

    [StringLength(500)]
    public string? RulesURL { get; set; }

    [StringLength(500)]
    public string? IconURL { get; set; }

    [StringLength(200)]
    public string? Contact { get; set; }

    public DateTime UploadDate { get; set; } = DateTime.Now;

    [StringLength(200)]
    public string UploadedBy { get; set; } = "Anonymous";

    //TODO: Add payment table
    public List<Payment> PaymentInfo { get; set; } = [];

    public bool IsDisplayed { get; set; } = false;

    public League()
    {
        Name = string.Empty;
    }

    public League(string name, string website, string rule, string icon, List<Payment>? payments = null)
    {
        Name = name;
        WebsiteURL = website;
        RulesURL = rule;
        IconURL = icon;
        PaymentInfo = payments ?? [];
    }
}
