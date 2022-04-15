using NexaraProject.Core.DataAccess.EntityFramework;
using NexaraProject.DataAccess.Abstracts.Repositories;
using NexaraProject.Entities.Concretes;

namespace NexaraProject.DataAccess.EntityFramework.Repositories
{
    public class CountryRepository : EntityFrameworkRepositoryBase<NexaraContext, Country, int>, ICountryRepository
    {
        public CountryRepository(NexaraContext dbContext) : base(dbContext)
        {
        }
    }
}