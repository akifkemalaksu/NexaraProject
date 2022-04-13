using NexaraProject.Core.Utilities.Results;
using NexaraProject.Entities.Concretes;
using NexaraProject.Core.Business.Abstracts;

namespace NexaraProject.Business.Abstracts.Engines
{
    public interface IProductModelEngine : IBusinessEngine
    {
        public IDataResult<ICollection<ProductModel>> GetProductModels();
    }
}