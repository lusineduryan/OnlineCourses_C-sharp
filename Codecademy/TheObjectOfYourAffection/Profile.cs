using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingProfile
{
    public class Profile
    {
        string name;
        int age;
        string city;
        string country;
        public string pronouns;
        string[] hobbies;
        public Profile (string name, int age, string city, string country, string pronouns)
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = "they/them";
        }

        public string ViewProfile()
        {
            string profInfo =  $"Hi, I am {name}. I am {age}. I live in {city}, {country}. I have the following hobbies: ";
            foreach (string hobby in hobbies)
            {
                profInfo += hobby + ", ";
            }
            return profInfo;
        }

        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }
    }
        
}

