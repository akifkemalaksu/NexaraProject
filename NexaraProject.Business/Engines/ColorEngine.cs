using NexaraProject.Business.Abstracts.Engines;
using NexaraProject.Core.Utilities.Results;
using NexaraProject.DataAccess.Abstracts.Repositories;
using NexaraProject.Entities.Concretes;
using System;
using NexaraProject.Business.Engines;

namespace NexaraProject.Business.Engines
{
    public class ColorEngine : BusinessEngineBase, IColorEngine
    {
        private readonly IColorRepository _colorRepository;

        public ColorEngine(IColorRepository colorRepository)
        {
            _colorRepository = colorRepository;
        }

        public IDataResult<ICollection<Color>> GetColours()
        {
            return new SuccessDataResult<ICollection<Color>>(_colorRepository.GetList());
        }
    }
}