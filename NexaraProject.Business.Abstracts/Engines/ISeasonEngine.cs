using NexaraProject.Core.Business;
using NexaraProject.Core.Utilities.Results;
using NexaraProject.Entities.Concretes;

namespace NexaraProject.Business.Abstracts.Engines
{
    public interface ISeasonEngine : IBusinessEngine
    {
        public IDataResult<ICollection<Season>> GetSeasons();
    }
}