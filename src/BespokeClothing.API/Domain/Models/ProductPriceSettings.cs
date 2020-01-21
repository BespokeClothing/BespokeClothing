using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BespokeClothing.API.Domain.Models
{
    public class ProductPriceSettings
    {
        [Required]
        [ForeignKey("ProductID")]
        public Products Product { get; set; }
        public int ProductID { get; set; }

        [Required]
        [ForeignKey("OrganisationID")]
        public Organisations Organisation { get; set; }
        public int OrganisationID { get; set; }

        public float StichingPrice { get; set; }
    }
}
