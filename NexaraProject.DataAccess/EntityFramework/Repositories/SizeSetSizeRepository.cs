using NexaraProject.Core.DataAccess.EntityFramework;
using NexaraProject.DataAccess.Abstracts.Repositories;
using NexaraProject.Entities.Concretes;

namespace NexaraProject.DataAccess.EntityFramework.Repositories
{
    public class SizeSetSizeRepository : EntityFrameworkRepositoryBase<NexaraContext, SizeSetSize, int>, ISizeSetSizeRepository
    {
        public SizeSetSizeRepository(NexaraContext dbContext) : base(dbContext)
        {
        }
    }
}