using NexaraProject.Core.Entities;

namespace NexaraProject.Entities.RequestModels
{
    public class AddOrderDetailModel : IRequestModel
    {
        public int ProductModelId { get; set; }
        public int PatternId { get; set; }
        public int SeasonId { get; set; }
        public int ColorId { get; set; }
        public int SizeSetId { get; set; }
        public int SizeId { get; set; }
        public int Piece { get; set; }
    }
}