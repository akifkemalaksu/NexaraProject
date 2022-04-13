using NexaraProject.Core.Entities;

namespace NexaraProject.Entities.Concretes
{
    public class Season : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }
    }
}