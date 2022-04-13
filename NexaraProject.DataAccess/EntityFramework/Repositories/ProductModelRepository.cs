using NexaraProject.Core.DataAccess.EntityFramework;
using NexaraProject.DataAccess.Abstracts.Repositories;
using NexaraProject.Entities.Concretes;

namespace NexaraProject.DataAccess.EntityFramework.Repositories
{
    public class ProductModelRepository : EntityFrameworkRepositoryBase<NexaraContext, ProductModel, int>, IProductModelRepository
    {
        public ProductModelRepository(NexaraContext dbContext) : base(dbContext)
        {
        }
    }
}