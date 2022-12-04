using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Personal_info
    {
        public List<Person> GetAllPerson()
        {
            List<Person> people = new List<Person>();
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
                        int id = Convert.ToInt32(reader["ID"]);
                        string first_name = (string)reader["first_name"];
                        string last_name = (string)reader["last_name"];
                        string email = (string)reader["email"];
                        string image = (string)reader["image"];
                        string country = (string)reader["country"];
                        string date_birth = "14/2011";
                        //Debug.WriteLine("{0} {1} -email: {2} -birthdate: {3} -image: {4} -country: {5} ", first_name, last_name, email, date_birth, image, country);

                        //Debug.WriteLine( first_name, last_name, email, date_birth, image, country);

                        people.Add(new Person(id, first_name, last_name, country, image, email, date_birth));


                    }
                }
            }
            return people;
        }
            public Person GetPerson(int id)
        {
            List<Person> people = GetAllPerson();
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].id == id)
                {
                    return people[i];
                }
            }
            return null;

        }

    }
}