using Models.DTOs.Posts;

namespace Business.Services.Post
{
    public interface IPostService
    {
        Task<IEnumerable<PostDto>> GetAllPosts();
        Task<PostDto> GetPostDetails(int id);
    }
}
