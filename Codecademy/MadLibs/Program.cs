using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program is requesting some words to type and making a funny story.
            Author: Lusine Duryan
            */


            // Let the user know that the program is starting:
            Console.WriteLine("Hi, your funny adventure is about to begin!");

            // Give the Mad Lib a title:
            string title = "My funny story";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.WriteLine("name");
            string name = Console.ReadLine();
            Console.WriteLine("emotion");
            string emotion = Console.ReadLine();
            Console.WriteLine("adjective");
            string adjective = Console.ReadLine();
            Console.WriteLine("group of people");
            string groupOfPeople = Console.ReadLine();
            Console.WriteLine("food");
            string food = Console.ReadLine();
            Console.WriteLine("move");
            string move = Console.ReadLine();
            Console.WriteLine("music genre");
            string musicGenre = Console.ReadLine();
            Console.WriteLine("animal");
            string animal = Console.ReadLine();
            Console.WriteLine("feeling");
            string feeling = Console.ReadLine();
            Console.WriteLine("last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("other name");
            string otherName = Console.ReadLine();
            Console.WriteLine("adverb");
            string adverb = Console.ReadLine();
            Console.WriteLine("place");
            string place = Console.ReadLine();
            Console.WriteLine("any object");
            string anyObject = Console.ReadLine();
            Console.WriteLine("a place");
            string aPlace = Console.ReadLine();
            Console.WriteLine("woman's name");
            string womansName = Console.ReadLine();
            Console.WriteLine("year");
            string year = Console.ReadLine();
            Console.WriteLine("bird");
            string bird = Console.ReadLine();

            // The template for the story:

            string story = $"This morning {name} woke up feeling {emotion}. \'It is going to be a {adjective} day!\' " +
                $"Outside, a bunch of {groupOfPeople}s were protesting to keep {food} in stores. " +
                $"They began to {move} to the rhythm of the {musicGenre}, which made all the {animal}s very {feeling}. Concerned, {lastName} texted {otherName}, who flew {adverb} " +
                $"to {place} and dropped {anyObject} in a puddle of frozen {aPlace}. {womansName} woke up in the year {year}, in a world where {bird}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);
            Console.ReadKey();
        }
    }
}
