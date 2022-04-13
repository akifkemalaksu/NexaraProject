using NexaraProject.Core.DataAccess;
using NexaraProject.Entities.Concretes;

namespace NexaraProject.DataAccess.Abstracts.Repositories
{
    public interface ICountryRepository : IRepository<Country, int>
    {
    }
}