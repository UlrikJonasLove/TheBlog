using Business.Services.Post;
using DataAccess.Repositories;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ServiceOrchestrator : IServiceOrchestrator
    {
        private readonly IUnitOfWork unitOfWork;
        public ServiceOrchestrator(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IPostService PostService => new PostService(unitOfWork);
    }
}
