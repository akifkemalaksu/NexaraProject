using NexaraProject.Core.DataAccess.EntityFramework;
using NexaraProject.DataAccess.Abstracts.Repositories;
using NexaraProject.Entities.Concretes;

namespace NexaraProject.DataAccess.EntityFramework.Repositories
{
    public class SizeSetRepository : EntityFrameworkRepositoryBase<NexaraContext, SizeSet, int>, ISizeSetRepository
    {
        public SizeSetRepository(NexaraContext dbContext) : base(dbContext)
        {
        }
    }
}