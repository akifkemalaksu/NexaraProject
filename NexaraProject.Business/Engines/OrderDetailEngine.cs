using NexaraProject.Business.Abstracts.Engines;
using NexaraProject.Core.Utilities.Results;
using NexaraProject.DataAccess.Abstracts.Repositories;
using NexaraProject.Entities.Concretes;
using NexaraProject.Entities.Dtos;
using System.Linq.Expressions;

namespace NexaraProject.Business.Engines
{
    public class OrderDetailEngine : BusinessEngineBase, IOrderDetailEngine
    {
        private readonly IOrderDetailRepository _orderDetailRepository;

        public OrderDetailEngine(IOrderDetailRepository orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }

        public IResult AddOrderDetail(OrderDetail orderDetail)
        {
            _orderDetailRepository.Add(orderDetail);
            _orderDetailRepository.SaveChanges();
            return new SuccessResult();
        }

        public IResult DeleteOrderDetail(OrderDetail orderDetail)
        {
            _orderDetailRepository.Delete(orderDetail.Id);
            _orderDetailRepository.SaveChanges();
            return new SuccessResult();
        }

        public IDataResult<ICollection<OrderDetail>> GetOrderDetails(Expression<Func<OrderDetail, bool>> expression)
        {
            return new SuccessDataResult<ICollection<OrderDetail>>(_orderDetailRepository.GetList(expression));
        }

        public IDataResult<ICollection<OrderDetailDto>> GetOrderDetailsWithInfosByOrder(int orderId)
        {
            return new SuccessDataResult<ICollection<OrderDetailDto>>(_orderDetailRepository.GetOrderDetailsWithInfosByOrder(orderId));
        }
    }
}