using NexaraProject.Core.Business.Abstracts;
using NexaraProject.Core.Utilities.Results;
using NexaraProject.Entities.Concretes;
using NexaraProject.Entities.Dtos;
using System.Linq.Expressions;

namespace NexaraProject.Business.Abstracts.Engines
{
    public interface IOrderDetailEngine : IBusinessEngine
    {
        public IDataResult<ICollection<OrderDetail>> GetOrderDetails(Expression<Func<OrderDetail, bool>> expression);

        public IResult DeleteOrderDetail(OrderDetail orderDetail);

        public IResult AddOrderDetail(OrderDetail orderDetail);

        public IDataResult<ICollection<OrderDetailDto>> GetOrderDetailsWithInfosByOrder(int orderId);
    }
}