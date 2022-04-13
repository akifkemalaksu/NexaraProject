using NexaraProject.Core.Entities;
using System;

namespace NexaraProject.Entities.Concretes
{
    public class Country : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }
    }
}