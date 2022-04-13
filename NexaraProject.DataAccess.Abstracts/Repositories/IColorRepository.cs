using NexaraProject.Core.DataAccess;
using NexaraProject.Entities.Concretes;
using System;

namespace NexaraProject.DataAccess.Abstracts.Repositories
{
    public interface IColorRepository : IRepository<Color, int>
    {
    }
}