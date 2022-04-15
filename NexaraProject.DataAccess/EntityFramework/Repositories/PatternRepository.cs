using NexaraProject.Core.DataAccess.EntityFramework;
using NexaraProject.DataAccess.Abstracts.Repositories;
using NexaraProject.Entities.Concretes;

namespace NexaraProject.DataAccess.EntityFramework.Repositories
{
    public class PatternRepository : EntityFrameworkRepositoryBase<NexaraContext, Pattern, int>, IPatternRepository
    {
        public PatternRepository(NexaraContext dbContext) : base(dbContext)
        {
        }
    }
}