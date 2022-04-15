using NexaraProject.Core.Business.Abstracts;
using NexaraProject.Core.Utilities.Results;
using NexaraProject.Entities.Concretes;
using NexaraProject.Entities.Dtos;
using NexaraProject.Entities.RequestModels;
using System.Linq.Expressions;

namespace NexaraProject.Business.Abstracts.Engines
{
    public interface IOrderEngine : IBusinessEngine
    {
        public IDataResult<Order> GetOrder(Expression<Func<Order, bool>> expression);

        public IResult AddOrder(AddOrderModel addOrder);

        public IResult DeleteOrder(int orderId);

        public IDataResult<ICollection<OrderDto>> GetOrdersWithInfos();
    }
}