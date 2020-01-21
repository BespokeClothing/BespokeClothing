using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BespokeClothing.API.Domain.Models
{
    public class UserOrganisations : CommonEntities
    {
        [Required]
        [ForeignKey("UserID")]
        public tblUsers User { get; set; }
        public int UserID { get; set; }


        [Required]
        [ForeignKey("OrganisationID")]
        public tblOrganisations Organisation { get; set; }
        public int OrganisationID { get; set; }
    }
}
