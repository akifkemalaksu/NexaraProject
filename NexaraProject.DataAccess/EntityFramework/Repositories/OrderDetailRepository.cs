using NexaraProject.Core.DataAccess.EntityFramework;
using NexaraProject.DataAccess.Abstracts.Repositories;
using NexaraProject.Entities.Concretes;

namespace NexaraProject.DataAccess.EntityFramework.Repositories
{
    public class OrderDetailRepository : EntityFrameworkRepositoryBase<NexaraContext, OrderDetail, int>, IOrderDetailRepository
    {
        public OrderDetailRepository(NexaraContext dbContext) : base(dbContext)
        {
        }
    }
}