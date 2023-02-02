using Core.Entities;

namespace Entities.Concretes
{
    public class Computer:Entity
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
    }
}
