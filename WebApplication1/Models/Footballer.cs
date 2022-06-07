using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Footballer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public string DateOfBirth { get; set; }
        public int Rating { get; set; }
        [Required]
        public int Price { get; set; }

        [ForeignKey("Club")]
        public int ClubId { get; set; }

        public Club Club { get; set; }
        public string Status { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public string PictureUrl { get; set; }
    }
}
