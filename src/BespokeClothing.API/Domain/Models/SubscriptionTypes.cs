using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BespokeClothing.API.Domain.Models
{
    public class SubscriptionTypes : CommonEntities
    {

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        public float Amount { get; set; }

        [Required]
        public int StorageSpace { get; set; }
    }
}
