using NexaraProject.Core.Business;
using NexaraProject.Core.Utilities.Results;
using NexaraProject.Entities.Concretes;

namespace NexaraProject.Business.Abstracts.Engines
{
    public interface IColorEngine : IBusinessEngine
    {
        public IDataResult<ICollection<Color>> GetColours();
    }
}