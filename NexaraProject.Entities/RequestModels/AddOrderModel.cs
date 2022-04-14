using NexaraProject.Core.Entities;
using System;

namespace NexaraProject.Entities.RequestModels
{
    public class AddOrderModel : IRequestModel
    {
        public string OrderNumber { get; set; }
        public int CountryId { get; set; }
        public DateTime Deadline { get; set; }
        public ICollection<AddOrderDetailModel> OrderDetails { get; set; }
    }
}