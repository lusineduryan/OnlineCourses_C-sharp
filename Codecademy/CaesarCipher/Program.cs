using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string userMessage = Console.ReadLine();
            char[] secretMessage = userMessage.ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length];
            for (int i = 0; i < secretMessage.Length; i++)
            {
                char eachCharacter = secretMessage[i];
                int indexInAlphabet = Array.IndexOf(alphabet, eachCharacter);
                int secretIndex = (indexInAlphabet + 3) % 26;
                char newEncryptedCharacter = alphabet[secretIndex];
                encryptedMessage[i] = newEncryptedCharacter;
            }
            string reverseMessage = String.Join("", encryptedMessage);


            Console.WriteLine(reverseMessage);
            Console.ReadKey();
        }
    }
}
