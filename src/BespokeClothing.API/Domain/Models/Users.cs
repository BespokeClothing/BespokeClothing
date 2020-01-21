using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BespokeClothing.API.Domain.Models
{
    public class Users : CommonEntities
    {


        [ForeignKey("ParentUserID")]
        public tblUsers ParentUser { get; set; }
        public int ParentUserID { get; set; }

        [ForeignKey("RoleID")]
        public tblRoles Role { get; set; }
        public int RoleID { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [MaxLength(100)]
        public string LastName { get; set; }

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
        public string HomePhone { get; set; }

        [MaxLength(16)]
        public string Mobile { get; set; }

        [MaxLength(16)]
        public string AlternateMobile { get; set; }

        [MaxLength(255)]
        public string EMail { get; set; }

        public bool IsSuperAdmin { get; set; }

        [MaxLength(16)]
        public byte[] Image { get; set; }
    }
}
