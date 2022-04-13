using NexaraProject.Core.DataAccess.EntityFramework;
using NexaraProject.DataAccess.Abstracts.Repositories;
using NexaraProject.Entities.Concretes;

namespace NexaraProject.DataAccess.EntityFramework.Repositories
{
    public class OrderRepository : EntityFrameworkRepositoryBase<NexaraContext, Order, int>, IOrderRepository
    {
        public OrderRepository(NexaraContext dbContext) : base(dbContext)
        {
        }
    }
}