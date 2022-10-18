using System.ComponentModel.DataAnnotations;

namespace repository_practice.Models
{
    public class OrderDetail
    {
        [Required]
        public int OrderID { get; set; }

        [Required]
        public int ProductID { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }

        [Required]
        public Int16 Quantity { get; set; }

        [Required]
        public Single Discount { get; set; }
    }
}
