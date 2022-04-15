using NexaraProject.Core.DataAccess;
using NexaraProject.Entities.Concretes;
using NexaraProject.Entities.Dtos;

namespace NexaraProject.DataAccess.Abstracts.Repositories
{
    public interface IOrderDetailRepository : IRepository<OrderDetail, int>
    {
        public ICollection<OrderDetailDto> GetOrderDetailsWithInfosByOrder(int orderId);
    }
}