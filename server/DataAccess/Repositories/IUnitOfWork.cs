using DataAccess.Repositories.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IUnitOfWork
    {
        IPostRepository PostRepository { get; }
        Task<bool> SaveAsync();
        bool HasChanges();
    }
}
