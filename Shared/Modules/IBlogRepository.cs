using MVSRA.Shared.EFModels;

namespace MVSRA.Shared.Modules;

public interface IBlogRepository
{
    Task<BlogCommunity> GetCommunity(Guid communityId);

    Task<BlogPost> GetPost(Guid postId);

    Task CreatePost(BlogPost post);

    Task UpdatePost(BlogPost post);

    Task CommentOnPost(BlogComment comment);
}
