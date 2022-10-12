using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace WebApplication2.Models
{
    public class Disaster
    {
        [Key]
        public int Disaster_ID { get; set; }
        [Required]
        public DateTime StartDATE { get; set; }
        [Required]
        public DateTime EndDATE { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Aid_Types { get; set; }
    }
}
