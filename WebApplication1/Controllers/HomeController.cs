using System;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string conncetionString = @"Data Source=C:\Users\salma\source\repos\WebApplication1\WebApplication1\2022 GL3 .NET Framework TP3 - SQLite database.db";
            SQLiteConnection dbCon = new SQLiteConnection(conncetionString);
            dbCon.Open();
            using (dbCon)
            {
                SQLiteCommand cmd = new SQLiteCommand("select * from personal_info", dbCon);
                SQLiteDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string first_name = (string)reader["first_name"];
                        string last_name = (string)reader["last_name"];
                        string email = (string)reader["email"];
                        string image = (string)reader["image"];
                        string country = (string)reader["country"];
                        string date_birth = "14/2011";
                        Debug.WriteLine("{0} {1} -email: {2} -birthdate: {3} -image: {4} -country: {5} ", first_name, last_name, email, date_birth, image, country);

                        //Debug.WriteLine( first_name, last_name, email, date_birth, image, country);




                    }
                }

            }

            return View();
        }

        public ActionResult About(int id)
        {
            ViewBag.Message = "Your application description page. ";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult New()
        {
            ViewBag.Message = "Your new page.";

            return RedirectToAction("Contact");
        }
    }
}