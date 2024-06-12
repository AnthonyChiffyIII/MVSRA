using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVSRA.Shared.EFModels;

[Table("Meetings")]
public class Meeting
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    public DateOnly Date { get; set; }

    [Required]
    public TimeOnly Time { get; set; }

    [Required]
    [StringLength(200)]
    public string Location { get; set; }

    [Required]
    [StringLength(200)]
    public string Address { get; set; }

    [StringLength(500)]
    public string? Attendees { get; set; }

    [StringLength(500)]
    public string? Agenda { get; set; }

    [StringLength(500)]
    public string? MeetingNotesURL { get; set; }

    public DateTime UploadDate { get; set; } = DateTime.Now;

    [StringLength(200)]
    public string UploadedBy { get; set; } = "Anonymous";

    public Meeting()
    {
        Location = "N/A";
        Address = string.Empty;
        UploadedBy ??= string.Empty;
    }
}
