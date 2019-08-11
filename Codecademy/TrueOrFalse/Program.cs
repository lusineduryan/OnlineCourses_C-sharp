using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Welcome to 'True or False?'\nHere are the questions:\n");

            string[] questions = { "Is C# an OOP language?", "Is banana a vegatable?", "Are there 4 seasons in a year?" };
            bool[] answers = { true, false, true };
            bool[] responses = new bool[questions.Length];
            if (questions.Length != answers.Length)
            {
                Console.WriteLine("Please make sure you have the same corresponding answer for each question!");
            }

            int askingIndex = 0;
            foreach (string question in questions)
            {
                Console.WriteLine(question);
                Console.WriteLine("True or False?");
                string input = Console.ReadLine();
                bool inputBool;
                bool isBool = Boolean.TryParse(input, out inputBool);
                while (!isBool)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'!");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }
                responses[askingIndex] = inputBool;
                askingIndex++;
            }
            int scoringIndex = 0;
            int score = 0;
            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];
                scoringIndex++;
                if (answer == response)
                {
                    score++; 
                }
            }
            Console.WriteLine($"You got {score} out of 3 correct!");
            Console.ReadKey();


        }
    }
}

