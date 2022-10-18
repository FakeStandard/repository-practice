using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace repository_practice.Models
{
    public class Order
    {
        [Column("OrderID")]
        [Required]
        [Key]
        public int ID { get; set; }

        [StringLength(5)]
        public string? CustomerID { get; set; }

        public int? EmployeeID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? OrderDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? RequiredDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? ShippedDate { get; set; }

        [Column("ShipVia")]
        public int? Via { get; set; }

        public decimal? Freight { get; set; }

        [Column("ShipName")]
        [StringLength(40)]
        public string? Name { get; set; }

        [Column("ShipAddress")]
        [StringLength(60)]
        public string? Address { get; set; }

        [Column("ShipCity")]
        [StringLength(15)]
        public string? City { get; set; }

        [Column("ShipRegion")]
        [StringLength(15)]
        public string? Region { get; set; }

        [Column("ShipPostalCode")]
        [StringLength(10)]
        public string? PostalCode { get; set; }

        [Column("ShipCountry")]
        [StringLength(15)]
        public string? Country { get; set; }
    }
}
