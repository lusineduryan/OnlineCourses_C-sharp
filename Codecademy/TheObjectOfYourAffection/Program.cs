using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");
            string[] hobbiesOfSam = { "listening to audiobooks and podcasts", "playing rec sports like bowling and kickball",
                "writing a speculative fiction novel" };
            sam.SetHobbies(hobbiesOfSam);
            Console.WriteLine(sam.ViewProfile());
            Console.ReadKey();


        }
    }
}