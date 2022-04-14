using NexaraProject.Core.DataAccess.EntityFramework;
using NexaraProject.DataAccess.Abstracts.Repositories;
using NexaraProject.Entities.Concretes;

namespace NexaraProject.DataAccess.EntityFramework.Repositories
{
    public class SizeRepository : EntityFrameworkRepositoryBase<Size, int>, ISizeRepository
    {
        public ICollection<Size> GetSizesBySizeSet(int sizeSetId)
        {
            var context = _dbContext as NexaraContext;
            return (from size in _dbSet
                    join sizeSetSize in context.SizeSetSizes on size.Id equals sizeSetSize.SizeId
                    join sizeSet in context.SizeSets on sizeSetSize.SizeSetId equals sizeSet.Id
                    select size
                    ).Distinct().ToList();
        }
    }
}