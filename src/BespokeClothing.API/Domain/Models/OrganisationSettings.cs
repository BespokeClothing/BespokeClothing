using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BespokeClothing.API.Domain.Models
{
    public class OrganisationSettings : CommonEntities
    {
        [Required]
        [ForeignKey("OrganisationID")]
        public Organisations Organisation { get; set; }
        public int OrganisationID { get; set; }


        [Required]
        [ForeignKey("ParentOrganisationSettingID")]
        public OrganisationSettings ParentOrganisationSetting { get; set; }
        public int ParentOrganisationSettingID { get; set; }


        [Required]
        [MaxLength(50)]
        public string Code { get; set; }

        [Required]
        [MaxLength(50)]
        public string Value { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

      
    }
}
