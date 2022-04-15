using NexaraProject.Core.DataAccess.EntityFramework;
using NexaraProject.DataAccess.Abstracts.Repositories;
using NexaraProject.Entities.Concretes;
using NexaraProject.Entities.Dtos;

namespace NexaraProject.DataAccess.EntityFramework.Repositories
{
    public class OrderDetailRepository : EntityFrameworkRepositoryBase<NexaraContext, OrderDetail, int>, IOrderDetailRepository
    {
        public OrderDetailRepository(NexaraContext dbContext) : base(dbContext)
        {
        }

        public ICollection<OrderDetailDto> GetOrderDetailsWithInfosByOrder(int orderId)
        {
            return (from orderDetail in _dbSet
                    join productModel in _dbContext.ProductModels on orderDetail.ProductModelId equals productModel.Id
                    join pattern in _dbContext.Patterns on orderDetail.PatternId equals pattern.Id
                    join season in _dbContext.Seasons on orderDetail.SeasonId equals season.Id
                    join color in _dbContext.Colors on orderDetail.ColorId equals color.Id
                    join sizeSet in _dbContext.SizeSets on orderDetail.SizeSetId equals sizeSet.Id
                    join size in _dbContext.Sizes on orderDetail.SizeId equals size.Id
                    where orderDetail.OrderId == orderId
                    select new OrderDetailDto
                    {
                        Id = orderDetail.Id,
                        Color = color.Name,
                        Pattern = pattern.Name,
                        ProductModel = productModel.Name,
                        Season = season.Name,
                        Size = size.Name,
                        SizeSet = sizeSet.Name,
                        Piece = orderDetail.Piece
                    }).ToList();
        }
    }
}