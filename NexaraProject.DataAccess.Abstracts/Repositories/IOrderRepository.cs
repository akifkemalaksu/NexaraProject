using NexaraProject.Core.DataAccess;
using NexaraProject.Entities.Concretes;
using NexaraProject.Entities.Dtos;

namespace NexaraProject.DataAccess.Abstracts.Repositories
{
    public interface IOrderRepository : IRepository<Order, int>
    {
        public ICollection<OrderDto> GetOrdersWithInfos();
    }
}