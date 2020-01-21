using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BespokeClothing.API.Domain.Models
{
    public class OrganisationSubscriptions : CommonEntities
    {
        [Required]
        [ForeignKey("SubscriptionTypeID")]
        public tblSubscriptionTypes SubscriptionType { get; set; }
        public int SubscriptionTypeID { get; set; }

        [Required]
        [ForeignKey("OrganisationID")]
        public tblOrganisations Organisation { get; set; }
        public int OrganisationID { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public float Price { get; set; }

        [Required]
        [ForeignKey("StatusID")]
        public tblCodes Status { get; set; }
        public int StatusID { get; set; }
        public bool IsAutoRenew { get; set; }

    }
}
