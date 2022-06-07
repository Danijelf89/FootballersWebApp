using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApplication1.Models
{

    public class Club
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ClubName { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public int Budget { get; set; }
        [Required]
        public string Founded { get; set; }
        [Required]
        public string Owner { get; set; }
        [Required]
        public bool IsDefault { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }
       
        public string PictureUrl { get; set; }

       
    }
}
