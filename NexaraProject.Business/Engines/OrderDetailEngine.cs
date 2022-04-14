using NexaraProject.Business.Abstracts.Engines;
using NexaraProject.Core.Utilities.Results;
using NexaraProject.DataAccess.Abstracts.Repositories;
using NexaraProject.Entities.Concretes;

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
            _orderDetailRepository.Dispose();
            return new SuccessResult();
        }
    }
}