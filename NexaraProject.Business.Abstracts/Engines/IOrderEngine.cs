using NexaraProject.Core.Business.Abstracts;
using NexaraProject.Core.Utilities.Results;
using NexaraProject.Entities.RequestModels;

namespace NexaraProject.Business.Abstracts.Engines
{
    public interface IOrderEngine : IBusinessEngine
    {
        public IResult AddOrder(AddOrderModel addOrder);
    }
}