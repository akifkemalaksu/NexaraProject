using NexaraProject.Core.Utilities.Results;
using NexaraProject.Entities.Concretes;
using NexaraProject.Core.Business.Abstracts;

namespace NexaraProject.Business.Abstracts.Engines
{
    public interface ISeasonEngine : IBusinessEngine
    {
        public IDataResult<ICollection<Season>> GetSeasons();
    }
}