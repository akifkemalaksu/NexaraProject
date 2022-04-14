using NexaraProject.Core.DataAccess;
using NexaraProject.Entities.Concretes;

namespace NexaraProject.DataAccess.Abstracts.Repositories
{
    public interface ISizeRepository : IRepository<Size, int>
    {
        public ICollection<Size> GetSizesBySizeSet(int sizeSetId);
    }
}