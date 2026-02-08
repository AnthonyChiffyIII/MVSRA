using BlazingApple.Forums.Shared.Models.Communities;
using BlazingApple.Forums.Shared.Models.Posts;
using BlazingApple.Forums.Shared.Models.Reactions;
using BlazingApple.Forums.Shared.Models.Votes;
using MVSRA.Server.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVSRA.Server.EFModels;

[Table("Blog_Posts")]
public class BlogPost : IPost
{
    #region Keys
    [Key]
    public Guid Id { get; set; } = new Guid();

    public Guid CommunityId { get; set; } = Constants.DEFAULT_COMMUNITY;
    [ForeignKey(nameof(CommunityId))]
    [NotMapped]
    public virtual IForumCommunity? Community { get; set; }
    #endregion

    #region Properties
    [StringLength(100)]
    public string Title { get; set; } = null!;

    [StringLength(8000)]
    public string Content { get; set; } = null!;

    [StringLength(100)]
    public string UserId { get; set; } = "System";

    [StringLength(200)]
    public string Slug { get; set; } = "/abcdefg";

    public DateTime DatabaseCreationTimestamp { get; set; } = DateTime.Now;

    public DateTime DatabaseModificationTimestamp { get; set; } = DateTime.Now;
    #endregion

    #region VirtualProperties
    [NotMapped]
    public virtual List<IPostVote>? Votes { get; set; } = [];

    [NotMapped]
    public virtual List<IPostReaction>? Reactions { get; set; } = [];

    [NotMapped]
    public virtual List<BlogComment>? BlogComments { get; set; } = [];
    #endregion

    #region NotMappedProperties
    [NotMapped]
    public virtual List<IPostComment>? Comments
    {
        get => BlogComments?.Select(x => x.ConvertToInterface()).ToList();
        set => BlogComments = value?.Select(x => new BlogComment(x)).ToList();
    }
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
