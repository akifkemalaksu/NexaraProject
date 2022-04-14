using NexaraProject.Core.Entities;

namespace NexaraProject.Entities.Concretes
{
    public class Order : IEntity<int>
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public int CountryId { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }
    }
}