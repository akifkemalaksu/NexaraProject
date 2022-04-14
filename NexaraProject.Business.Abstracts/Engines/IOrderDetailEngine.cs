using NexaraProject.Core.Business.Abstracts;
using NexaraProject.Core.Utilities.Results;
using NexaraProject.Entities.Concretes;

namespace NexaraProject.Business.Abstracts.Engines
{
    public interface IOrderDetailEngine : IBusinessEngine
    {
        public IResult AddOrderDetail(OrderDetail orderDetail);
    }
}