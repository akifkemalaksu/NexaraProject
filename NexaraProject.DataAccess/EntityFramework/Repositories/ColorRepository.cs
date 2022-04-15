using NexaraProject.Core.DataAccess.EntityFramework;
using NexaraProject.DataAccess.Abstracts.Repositories;
using NexaraProject.Entities.Concretes;
using System;

namespace NexaraProject.DataAccess.EntityFramework.Repositories
{
    public class ColorRepository : EntityFrameworkRepositoryBase<NexaraContext, Color, int>, IColorRepository
    {
        public ColorRepository(NexaraContext dbContext) : base(dbContext)
        {
        }
    }
}