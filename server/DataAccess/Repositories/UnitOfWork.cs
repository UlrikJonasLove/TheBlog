using AutoMapper;
using DataAccess.Data;
using DataAccess.Repositories.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext context;
        private readonly IMapper mapper;
        
        public UnitOfWork(AppDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public IPostRepository PostRepository => new PostRepository(context, mapper);

        public async Task<bool> SaveAsync() => await context.SaveChangesAsync() > 0;

        public bool HasChanges() => context.ChangeTracker.HasChanges();
    }
}
