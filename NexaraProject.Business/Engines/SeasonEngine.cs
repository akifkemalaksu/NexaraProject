using NexaraProject.Business.Abstracts.Engines;
using NexaraProject.Core.Utilities.Results;
using NexaraProject.DataAccess.Abstracts.Repositories;
using NexaraProject.Entities.Concretes;

namespace NexaraProject.Business.Engines
{
    public class SeasonEngine : BusinessEngineBase, ISeasonEngine
    {
        private readonly ISeasonRepository _seasonRepository;

        public SeasonEngine(ISeasonRepository seasonRepository)
        {
            _seasonRepository = seasonRepository;
        }

        public IDataResult<ICollection<Season>> GetSeasons()
        {
            return new SuccessDataResult<ICollection<Season>>(_seasonRepository.GetList());
        }
    }
}