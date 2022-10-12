using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Configuration;


namespace WebApplication2.Models
{
    public class Goods
    {
        [Key]
        public int GOODS_ID { get; set; }
        [Required]
        public DateTime DATE { get; set; }
        [Required]

        public string Number_of_items { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Description_of_each_item { get; set; }
    }
}
