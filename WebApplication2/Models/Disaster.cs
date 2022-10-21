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
     
        public DateTime StartDATE { get; set; }
      
        public DateTime EndDATE { get; set; }
        
        public string Location { get; set; }
     
        public string Description { get; set; }
      
        public string Aid_Types { get; set; }
        public IEnumerator<Disaster> GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
