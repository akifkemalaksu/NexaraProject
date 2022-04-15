using NexaraProject.Core.Entities;

namespace NexaraProject.Entities.Dtos
{
    public class OrderDetailDto : IDto
    {
        public int Id { get; set; }
        public string ProductModel { get; set; }
        public string Pattern { get; set; }
        public string Season { get; set; }
        public string Color { get; set; }
        public string SizeSet { get; set; }
        public string Size { get; set; }
        public int Piece { get; set; }
    }
}