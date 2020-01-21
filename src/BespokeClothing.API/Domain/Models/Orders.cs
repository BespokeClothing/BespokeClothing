using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BespokeClothing.API.Domain.Models
{
    public class Orders : CommonEntities
    {
        [Required]
        [ForeignKey("OrganisationID")]
        public Organisations Organisation { get; set; }
        public int OrganisationID { get; set; }


        [Required]
        [ForeignKey("UserID")]
        public Users User { get; set; }
        public int UserID { get; set; }


        [Required]
        public float TotalPrice { get; set; }

 
        public float Advance { get; set; }

        [Required]
        public DateTime DeliveryDate { get; set; }
    }
}
