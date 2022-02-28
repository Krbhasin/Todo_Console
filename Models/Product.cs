using System.ComponentModel.DataAnnotations;

namespace TODO.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool BuyIt { get; set; }
    }
}