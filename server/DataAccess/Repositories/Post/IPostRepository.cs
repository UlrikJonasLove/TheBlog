using Models.DTOs.Posts;

namespace DataAccess.Repositories.Post
{
    public interface IPostRepository
    {
        Task<IEnumerable<PostDto>> GetAllPosts();
        Task<PostDto> GetPostDetail(int id);
    }
}
