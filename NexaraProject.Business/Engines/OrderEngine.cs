using NexaraProject.Business.Abstracts.Engines;
using NexaraProject.Business.Constants;
using NexaraProject.Core.Aspects.Transaction;
using NexaraProject.Core.Utilities.Results;
using NexaraProject.DataAccess.Abstracts.Repositories;
using NexaraProject.Entities.Concretes;
using NexaraProject.Entities.Dtos;
using NexaraProject.Entities.RequestModels;
using System.Linq.Expressions;

namespace NexaraProject.Business.Engines
{
    public class OrderEngine : BusinessEngineBase, IOrderEngine
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderDetailEngine _orderDetailEngine;

        public OrderEngine(IOrderRepository orderRepository, IOrderDetailEngine orderDetailEngine)
        {
            _orderRepository = orderRepository;
            _orderDetailEngine = orderDetailEngine;
        }

        [TransactionScopeAspect]
        public IResult AddOrder(AddOrderModel addOrder)
        {
            Order order = _mapper.Map<Order>(addOrder);
            _orderRepository.Add(order);
            _orderRepository.SaveChanges();
            (addOrder.OrderDetails as List<AddOrderDetailModel>).ForEach(o =>
            {
                OrderDetail orderDetail = _mapper.Map<OrderDetail>(o);
                orderDetail.OrderId = order.Id;
                _orderDetailEngine.AddOrderDetail(orderDetail);
            });

            return new SuccessResult();
        }

        [TransactionScopeAspect]
        public IResult DeleteOrder(int orderId)
        {
            var order = _orderRepository.Get(o => o.Id.Equals(orderId));
            if (order == null)
                return new ErrorResult(Messages.NotFound);

            var resultOrderDetails = _orderDetailEngine.GetOrderDetails(o => o.OrderId.Equals(order.Id));
            if (resultOrderDetails.Success)
            {
                (resultOrderDetails.Data as List<OrderDetail>).ForEach(o =>
                {
                    _orderDetailEngine.DeleteOrderDetail(o);
                });
            }
            _orderRepository.Delete(order.Id);
            _orderRepository.SaveChanges();
            return new SuccessResult();
        }

        public IDataResult<Order> GetOrder(Expression<Func<Order, bool>> expression)
        {
            return new SuccessDataResult<Order>(_orderRepository.Get(expression));
        }

        public IDataResult<ICollection<OrderDto>> GetOrdersWithInfos()
        {
            return new SuccessDataResult<ICollection<OrderDto>>(_orderRepository.GetOrdersWithInfos());
        }
    }
}