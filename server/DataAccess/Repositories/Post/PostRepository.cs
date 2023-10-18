using AutoMapper;
using AutoMapper.QueryableExtensions;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Models.DTOs.Posts;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Post
{
    public class PostRepository : IPostRepository
    {
        private readonly AppDbContext context;
        private readonly IMapper mapper;
        public PostRepository(AppDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<PostDto>> GetAllPosts()
        {
            return await context.Posts.ProjectTo<PostDto>(mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<PostDto> GetPostDetail(int id)
        {
            return await context.Posts.ProjectTo<PostDto>(mapper.ConfigurationProvider).FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
