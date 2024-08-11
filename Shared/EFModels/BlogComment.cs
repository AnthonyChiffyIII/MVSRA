using BlazingApple.Components.Shared.Interfaces;
using BlazingApple.Forums.Shared.Models.Posts;
using BlazingApple.Forums.Shared.Models.Reactions;
using BlazingApple.Forums.Shared.Models.Votes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVSRA.Shared.EFModels;

[Table("Blog_Comments")]
public class BlogComment : IPostComment
{
    #region Constructors
    public BlogComment() { }

    public BlogComment(IPostComment comment)
    {
        Id = comment.Id;
        PostId = comment.PostId;
        Post = comment.Post;
        ParentId = comment.ParentId;
        Parent = comment.Parent;
        Content = comment.Content;
        UserId = comment.UserId;
        DatabaseCreationTimestamp = comment.DatabaseCreationTimestamp;
        DatabaseModificationTimestamp = comment.DatabaseModificationTimestamp;
        User = comment.User;
        Votes = comment.Votes;
        Reactions = comment.Reactions;
        Children = comment.Children;
    }
    #endregion

    #region Keys
    [Key]
    public Guid Id { get; set; } = new Guid();

    public Guid PostId { get; set; }
    [ForeignKey(nameof(PostId))]
    [NotMapped]
    public virtual IPost? Post { get; set; }

    public Guid? ParentId { get; set; }
    [ForeignKey(nameof(ParentId))]
    [NotMapped]
    public virtual IPostComment? Parent { get; set; }
    #endregion

    #region Properties
    [StringLength(8000)]
    public string Content { get; set; } = null!;

    [StringLength(100)]
    public string UserId { get; set; } = "System";

    public DateTime DatabaseCreationTimestamp { get; set; } = DateTime.Now;

    public DateTime DatabaseModificationTimestamp { get; set; } = DateTime.Now;
    #endregion

    #region VirtualProperties
    [NotMapped]
    public virtual IUser? User { get; set; }

    [NotMapped]
    public virtual List<ICommentVote>? Votes { get; set; } = [];

    [NotMapped]
    public virtual List<ICommentReaction>? Reactions { get; set; } = [];

    [NotMapped]
    public virtual List<IPostComment>? Children { get; set; } = [];
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

    public IPostComment ConvertToInterface() => this;
    #endregion
}
