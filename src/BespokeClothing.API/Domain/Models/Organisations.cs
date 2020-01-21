using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BespokeClothing.API.Domain.Models
{
    public class Organisations : CommonEntities
    {

        [ForeignKey("ParentOrganisationID")]
        public Organisations ParentOrganisation { get; set; }
        public int ParentOrganisationID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }


        [MaxLength(500)]
        public string Address { get; set; }

        [MaxLength(255)]
        public string CountryID { get; set; }


        [MaxLength(255)]
        public string StateID { get; set; }

        [MaxLength(255)]
        public string CityID { get; set; }


        [MaxLength(10)]
        public string ZipCode { get; set; }

        [MaxLength(16)]
        public string Phone { get; set; }

        [MaxLength(16)]
        public string Mobile { get; set; }


        [MaxLength(255)]
        public string EMail { get; set; }

        [MaxLength(255)]
        public string Website { get; set; }


        [ForeignKey("TypeID")]
        public Codes Type { get; set; }
        public int TypeID { get; set; }

        [MaxLength(16)]
        public byte[] Logo { get; set; }


        public bool IsNotificationEnabled { get; set; }

    }
}
