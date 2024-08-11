using BlazingApple.Forums.Shared.Models.Posts;
using MVSRA.Shared.EFModels;
using MVSRA.Shared.Modules;

namespace MVSRA.Client.Modules;

public class BlogRepository(HttpClient httpClient) : IBlogRepository
{
    private readonly HttpClient _httpClient = httpClient;

    #region Methods
    public Task CommentOnPost(BlogComment comment)
    {
        throw new NotImplementedException();
    }

    public Task CreatePost(BlogPost post)
    {
        throw new NotImplementedException();
    }

    public async Task<BlogCommunity> GetCommunity(Guid communityId)
    {
        await Task.Delay(1);

        return CreateFakeCommunity(communityId);
    }

    public async Task<BlogPost> GetPost(Guid postId)
    {
        await Task.Delay(1);

        return CreateFakePost(postId);
    }

    public Task UpdatePost(BlogPost post)
    {
        throw new NotImplementedException();
    }
    #endregion

    #region PrivateMethods
    private BlogCommunity CreateFakeCommunity(Guid communityId)
    {
        BlogCommunity community = new()
        {
            Id = communityId,
            Title = "Blazing Heat",
            DatabaseCreationTimestamp = DateTime.Now.AddDays(Random.Shared.Next(0, 1000)),
            Posts = []
        };

        community.Posts!.Add(GetPost("Best Sauces from Each Country", "I love them all"));
        community.Posts!.Add(GetPost("Best Sauces from Each City", "Louisiana does it best"));
        community.Posts!.Add(GetPost("How to recover your tongue from a sauce burn", "hot hot hot"));

        return community;
    }

    private BlogPost CreateFakePost(Guid postId)
    {
        BlogPost post = new()
        {
            Title = "Hello word",
            Content = "I like eggs",
        };

        return post;
    }

    private IPost GetPost(string title, string content)
    {
        string slug = Convert.ToBase64String(Guid.NewGuid().ToByteArray());

        return new Post()
        {
            Id = Guid.NewGuid(),
            Slug = slug,
            Title = title,
            Content = content,
            UserId = "abc"
        };
    }
    #endregion
}
