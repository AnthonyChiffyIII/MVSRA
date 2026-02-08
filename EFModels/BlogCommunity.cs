using BlazingApple.Forums.Shared.Models.Communities;
using BlazingApple.Forums.Shared.Models.Forums;
using BlazingApple.Forums.Shared.Models.Posts;
using MVSRA.Server.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVSRA.Server.EFModels;

[Table("Blog_Communities")]
public class BlogCommunity : IForumCommunity
{
    #region Keys
    [Key]
    public Guid Id { get; set; } = Constants.DEFAULT_COMMUNITY;

    public Guid ForumId { get; set; } = Constants.DEFAULT_FORUM;
    [ForeignKey(nameof(ForumId))]
    [NotMapped]
    public virtual IForum? Forum { get; set; }
    #endregion

    #region Properties
    [StringLength(100)]
    public string Title { get; set; } = null!;

    [StringLength(300)]
    public string Description { get; set; } = "Communities can be public or limited to select users";

    [StringLength(100)]
    public string CreatingUserId { get; set; } = "System";

    [StringLength(200)]
    public string Slug { get; set; } = "/abcdefg";

    public DateTime DatabaseCreationTimestamp { get; set; } = DateTime.Now;

    public DateTime DatabaseModificationTimestamp { get; set; } = DateTime.Now;
    #endregion

    #region VirtualProperties
    [NotMapped]
    public virtual List<IPost>? Posts { get; set; } = [];
    #endregion
     
    #region Methods
    public string ToCreationDate()
    {
        return DatabaseCreationTimestamp.ToString("d");
    }

    public string ToLastUpdatedDate()
    {
        return DatabaseModificationTimestamp.ToString("G");
    }
    #endregion
}
