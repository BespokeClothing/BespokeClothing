using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BespokeClothing.API.Domain.Models
{
    public class CommonEntities
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("CreatedUserID")]
        public tblUsers CreatedUser { get; set; }
        public int CreatedUserID { get; set; }

        public DateTime CreatedOn { get; set; }


        [ForeignKey("UpdatedUserID")]
        public tblUsers UpdatedUser { get; set; }
        public int UpdatedUserID { get; set; }

        public DateTime UpdatedOn { get; set; }

        public bool IsActive { get; set; }
    }
}
