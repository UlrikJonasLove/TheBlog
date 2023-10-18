using DataAccess.Repositories;
using Models.DTOs.Posts;

namespace Business.Services.Post
{
    public class PostService : IPostService
    {
        private readonly IUnitOfWork unitOfWork;
        public PostService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<PostDto>> GetAllPosts()
        {
            return await unitOfWork.PostRepository.GetAllPosts();
        }

        public async Task<PostDto> GetPostDetails(int id)
        {
            return await unitOfWork.PostRepository.GetPostDetail(id);
        }
    }
}
