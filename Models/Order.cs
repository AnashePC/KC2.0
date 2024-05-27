using System;
using System.ComponentModel.DataAnnotations;

namespace KhumaloCraft02.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required]
        public string ItemName { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Required]
        [EmailAddress]
        public string CustomerEmail { get; set; }

        [Required]
        public string CustomerAddress { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;
    }
}
