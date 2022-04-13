using NexaraProject.Core.Entities;

namespace NexaraProject.Entities.Concretes
{
    public class OrderDetail : IEntity<int>
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductModelId { get; set; }
        public int PatternId { get; set; }
        public int SeasonId { get; set; }
        public int ColorId { get; set; }
        public int SizeSetId { get; set; }
        public int SizeId { get; set; }
        public int Piece { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }
    }
}