using NexaraProject.Core.Entities;
using System;

namespace NexaraProject.Entities.Dtos
{
    public class OrderDto : IDto
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public string Country { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime CreateDate { get; set; }
    }
}