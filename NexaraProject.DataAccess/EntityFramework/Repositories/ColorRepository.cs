using NexaraProject.Core.DataAccess.EntityFramework;
using NexaraProject.DataAccess.Abstracts.Repositories;
using NexaraProject.Entities.Concretes;
using System;

namespace NexaraProject.DataAccess.EntityFramework.Repositories
{
    public class ColorRepository : EntityFrameworkRepositoryBase<Color, int>, IColorRepository
    {
    }
}