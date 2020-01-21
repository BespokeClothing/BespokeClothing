using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BespokeClothing.API.Domain.Models
{
    public class OrderItems : CommonEntities
    {
        [Required]
        [ForeignKey("UserID")]
        public tblUsers User { get; set; }
        public int UserID { get; set; }


        [Required]
        [ForeignKey("OrderID")]
        public tblOrders Order { get; set; }
        public int OrderID { get; set; }

        [Required]
        [ForeignKey("ProductID")]
        public tblProducts Product { get; set; }
        public int ProductID { get; set; }

        [MaxLength(16)]
        public byte[] Image { get; set; }

        public int Quantity { get; set; }


        [Required]
        public int Price { get; set; }

        [MaxLength(100)]
        public string Measurement2 { get; set; }


        [MaxLength(100)]
        public string Measurement3 { get; set; }

        [MaxLength(100)]
        public string Measurement4 { get; set; }

        [MaxLength(100)]
        public string Measurement5 { get; set; }

        [MaxLength(100)]
        public string Measurement6 { get; set; }

        [MaxLength(100)]
        public string Measurement7 { get; set; }

        [MaxLength(100)]
        public string Measurement8 { get; set; }

        [MaxLength(100)]
        public string Measurement9 { get; set; }

        [MaxLength(100)]
        public string Measurement10 { get; set; }

        [MaxLength(100)]
        public string Measurement11 { get; set; }

        [MaxLength(100)]
        public string Measurement12 { get; set; }

        
        public DateTime DeliveryDate { get; set; }


        [Required]
        [ForeignKey("TailorID")]
        public tblUsers Tailor { get; set; }
        public int TailorID { get; set; }
    }
}
