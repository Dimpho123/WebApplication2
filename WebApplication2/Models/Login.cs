using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using WebApplication2.Models;

namespace WebApplication2.Models
{
    public class Login
    {
        public string email { get; set; }

        public string Password { get; set; }

    }
}
