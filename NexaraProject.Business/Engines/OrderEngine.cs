using NexaraProject.Business.Abstracts.Engines;
using NexaraProject.Core.Utilities.Results;
using NexaraProject.DataAccess.Abstracts.Repositories;
using NexaraProject.Entities.Concretes;
using NexaraProject.Entities.RequestModels;

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

            _orderRepository.Dispose();
            return new SuccessResult();
        }
    }
}