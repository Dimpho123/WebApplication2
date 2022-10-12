using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Configuration;


namespace WebApplication2.Models
{
    public class Money
    {
        [Key]
        public int money_id { get; set; }
        [Required]
        public DateTime date { get; set; }
        [Required]
        public string Amount { get; set; }
     
    }
}
