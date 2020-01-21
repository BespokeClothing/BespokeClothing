using System.ComponentModel.DataAnnotations;

namespace BespokeClothing.API.Domain.Models
{
    public class Roles : CommonEntities
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}