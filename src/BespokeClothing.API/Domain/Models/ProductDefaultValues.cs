using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BespokeClothing.API.Domain.Models
{
    public class ProductDefaultValues : CommonEntities
    {

        [Required]
        [ForeignKey("ProductID")]
        public Products Product { get; set; }
        public int ProductID { get; set; }

        [Required]
        [MaxLength(100)]
        public string SizeName { get; set; }

        
        [MaxLength(100)]
        public string Measurement1 { get; set; }

        
        [MaxLength(100)]
        public string Measurement2 { get; set; }

         
        [MaxLength(100)]
        public string Measurement3 { get; set; }
         
        [MaxLength(100)]
        public string Measurement4 { get; set; }
        
        [MaxLength(100)]
        public string Measurement5 { get; set; }
       
        [MaxLength(100)]
        public string Measurement6 { get; set; }
    
        [MaxLength(100)]
        public string Measurement7 { get; set; }
      
        [MaxLength(100)]
        public string Measurement8 { get; set; }
        [Required]
        [MaxLength(100)]
        public string Measurement9 { get; set; }
       
        [MaxLength(100)]
        public string Measurement10 { get; set; }
        
        [MaxLength(100)]
        public string Measurement11 { get; set; }
        
        [MaxLength(100)]
        public string Measurement12 { get; set; }

    }
}
