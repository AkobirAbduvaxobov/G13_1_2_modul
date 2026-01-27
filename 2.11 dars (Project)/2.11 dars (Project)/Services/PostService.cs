using _2._11_dars__Project_.Dtos;
using _2._11_dars__Project_.Entities;
using _2._11_dars__Project_.Persistence;

namespace _2._11_dars__Project_.Services;

public class PostService : IPostService
{
    public Guid AddPost(PostCreateDto postCreateDto, string token)
    {
        var tokenResult = AppDBContext.GetTokenInfo(token);

        var post = new Post()
        {
            PostId = Guid.NewGuid(),
            Title = postCreateDto.Title,
            Content = postCreateDto.Content,
            CreatedTime = DateTime.Now,
            UpdatedTime = DateTime.Now,
            UserId = Guid.Parse(tokenResult.userId)
        };

        var userExists = false;
        foreach (var user in AppDBContext.Users)
        {
            if (user.UserId.ToString() == tokenResult.userId)
            {
                userExists = true;
                break;
            }
        }

        if (userExists == true)
        {
            AppDBContext.Posts.Add(post);
        }

        return post.PostId;
    }

    public bool DeletePost(Guid postId, string token)
    {
        var tokenResult = AppDBContext.GetTokenInfo(token);

        foreach (var post in AppDBContext.Posts)
        {
            if (post.PostId == postId && post.UserId.ToString() == tokenResult.userId)
            {
                AppDBContext.Posts.Remove(post);
                return true;
            }
        }

        return false;
    }

    public List<PostGetDto> GetAllPosts(string token)
    {
        var tokenResult = AppDBContext.GetTokenInfo(token);

        var postGetDtos = new List<PostGetDto>();

        foreach (var post in AppDBContext.Posts)
        {
            if (post.UserId.ToString() == tokenResult.userId)
            {
                var postGetDto = new PostGetDto()
                {
                    PostId = post.PostId,
                    Title = post.Title,
                    Content = post.Content,
                    CreatedTime = post.CreatedTime,
                    UpdatedTime = post.UpdatedTime
                };
                postGetDtos.Add(postGetDto);
            }
        }

        return postGetDtos;
    }

    public List<PostGetDto>? GetAllPostsByAdmin(string token)
    {
        var tokenResult = AppDBContext.GetTokenInfo(token);
        if (tokenResult.role == "User")
        {
            return null;
        }

        var postGetDtos = new List<PostGetDto>();
        foreach (var post in AppDBContext.Posts)
        {
            var postGetDto = new PostGetDto()
            {
                PostId = post.PostId,
                Title = post.Title,
                Content = post.Content,
                CreatedTime = post.CreatedTime,
                UpdatedTime = post.UpdatedTime
            };
            postGetDtos.Add(postGetDto);
        }

        return postGetDtos;
    }

    public PostGetDto? GetPostById(Guid postId)
    {
        throw new NotImplementedException();
    }

    public bool UpdatePost(Guid postId, PostCreateDto postCreateDto, string token)
    {
        var tokenResult = AppDBContext.GetTokenInfo(token);

        foreach (var post in AppDBContext.Posts)
        {
            if (post.PostId == postId && post.UserId.ToString() == tokenResult.userId)
            {
                post.Title = postCreateDto.Title;
                post.Content = postCreateDto.Content;
                return true;
            }
        }

        return false;
    }
}
