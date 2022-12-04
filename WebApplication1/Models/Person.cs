using System;
using System.ComponentModel.DataAnnotations;


public class Person
{
    public Person(int id, string first_name, string last_name, string country, string image, string email, string date_birth)
    {
        this.id = id;
        this.first_name = first_name;
        this.last_name = last_name;
        this.country = country;
        this.image = image;
        this.email = email;
        this.date_birth = date_birth;
    }

    public int id { get; set; }
    public string  first_name{ get; set; }
    public string last_name { get; set; }
    public string country { get; set; }
    public string image { get; set; }
    public string email { get; set; }
    public string date_birth { get; set; }



    
}
