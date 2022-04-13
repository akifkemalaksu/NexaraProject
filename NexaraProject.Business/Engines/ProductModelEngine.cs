using NexaraProject.Business.Abstracts.Engines;
using NexaraProject.Core.Utilities.Results;
using NexaraProject.DataAccess.Abstracts.Repositories;
using NexaraProject.Entities.Concretes;

namespace NexaraProject.Business.Engines
{
    public class ProductModelEngine : IProductModelEngine
    {
        private readonly IProductModelRepository _productModelRepository;

        public ProductModelEngine(IProductModelRepository productModelRepository)
        {
            _productModelRepository = productModelRepository;
        }

        public IDataResult<ICollection<ProductModel>> GetProductModels()
        {
            return new SuccessDataResult<ICollection<ProductModel>>(_productModelRepository.GetList());
        }
    }
}