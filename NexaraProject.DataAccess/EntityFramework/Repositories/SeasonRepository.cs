using NexaraProject.Core.DataAccess.EntityFramework;
using NexaraProject.DataAccess.Abstracts.Repositories;
using NexaraProject.Entities.Concretes;

namespace NexaraProject.DataAccess.EntityFramework.Repositories
{
    public class SeasonRepository : EntityFrameworkRepositoryBase<NexaraContext, Season, int>, ISeasonRepository
    {
        public SeasonRepository(NexaraContext dbContext) : base(dbContext)
        {
        }
    }
}