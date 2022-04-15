using NexaraProject.Core.DataAccess.EntityFramework;
using NexaraProject.DataAccess.Abstracts.Repositories;
using NexaraProject.Entities.Concretes;
using NexaraProject.Entities.Dtos;

namespace NexaraProject.DataAccess.EntityFramework.Repositories
{
    public class OrderRepository : EntityFrameworkRepositoryBase<NexaraContext, Order, int>, IOrderRepository
    {
        public OrderRepository(NexaraContext dbContext) : base(dbContext)
        {
        }

        public ICollection<OrderDto> GetOrdersWithInfos()
        {
            return (from order in _dbSet
                    join country in _dbContext.Countries on order.CountryId equals country.Id
                    select new OrderDto
                    {
                        Id = order.Id,
                        Country = country.Name,
                        OrderNumber = order.OrderNumber,
                        CreateDate = order.CreateDate,
                        Deadline = order.Deadline,
                    }).ToList();
        }
    }
}