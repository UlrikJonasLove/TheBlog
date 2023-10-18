using Business.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs.Posts;
using Models.Entities;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IServiceOrchestrator orchestrator;
        public PostController(IServiceOrchestrator orchestrator)
        {
            this.orchestrator = orchestrator;
        }

        [HttpGet] 
        public async Task<IEnumerable<PostDto>> GetAllPosts()
        {
            return await orchestrator.PostService.GetAllPosts();
        }

        [HttpGet("{id}")]
        public async Task<PostDto> GetPostDetails(int id)
        {
            return await orchestrator.PostService.GetPostDetails(id);
        }
    }
}
