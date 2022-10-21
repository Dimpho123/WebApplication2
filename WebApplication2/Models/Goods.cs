﻿using System;
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
        
        public DateTime DATE { get; set; }
      

        public int Number_of_items { get; set; }
      
        public string Category { get; set; }
      
        public string Description_of_each_item { get; set; }

        public IEnumerator<Goods> GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
