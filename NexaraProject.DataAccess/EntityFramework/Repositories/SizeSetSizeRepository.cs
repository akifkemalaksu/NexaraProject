using NexaraProject.Core.DataAccess.EntityFramework;
using NexaraProject.DataAccess.Abstracts.Repositories;
using NexaraProject.Entities.Concretes;

namespace NexaraProject.DataAccess.EntityFramework.Repositories
{
    public class SizeSetSizeRepository : EntityFrameworkRepositoryBase<SizeSetSize, int>, ISizeSetSizeRepository
    {
    }
}