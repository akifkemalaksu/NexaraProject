using NexaraProject.Core.Entities;

namespace NexaraProject.Entities.Concretes
{
    public class SizeSetSize : IEntity<int>
    {
        public int Id { get; set; }
        public int SizeSetId { get; set; }
        public int SizeId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }
    }
}