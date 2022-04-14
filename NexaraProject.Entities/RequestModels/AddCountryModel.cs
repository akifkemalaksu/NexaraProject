using NexaraProject.Core.Entities;
using System;

namespace NexaraProject.Entities.RequestModels
{
    public class AddCountryModel : IRequestModel
    {
        public string Name { get; set; }
    }
}