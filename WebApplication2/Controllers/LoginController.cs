using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using System.Data.SqlClient;


namespace WebApplication2.Controllers
{

    
    public class LoginController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
     
        [HttpGet]
        public ActionResult login()
        {
            return View();
        }
        void connectionString()
        {
            con.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=website;Integrated Security=True";
        }
        [HttpPost]
        public ActionResult Verify(Login l  )
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText="Select * from userinfo2 where email='"+l.email+"' and Password='"+l.Password+"'";
            dr = com.ExecuteReader();
            if(dr.Read())
            {
                con.Close();
                return View("Verify");
            }
            else
            {
                con.Close();
                return View("Error");
            }
          
           
        }
    }
}
