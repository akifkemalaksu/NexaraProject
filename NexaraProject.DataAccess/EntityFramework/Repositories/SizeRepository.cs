using NexaraProject.Core.DataAccess.EntityFramework;
using NexaraProject.DataAccess.Abstracts.Repositories;
using NexaraProject.Entities.Concretes;

namespace NexaraProject.DataAccess.EntityFramework.Repositories
{
    public class SizeRepository : EntityFrameworkRepositoryBase<NexaraContext, Size, int>, ISizeRepository
    {
        public SizeRepository(NexaraContext dbContext) : base(dbContext)
        {
        }
    }
}