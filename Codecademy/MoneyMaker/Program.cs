using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Please enter the total amount of money in cents!");

            double money = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{money} cents is equal to ... ");

            int goldCoinValue = 10;
            int silverCoinValue = 5;

            double goldCoins = Math.Floor(money / goldCoinValue);
            double remainder = money % goldCoinValue;

            double silverCoins = Math.Floor(remainder / silverCoinValue);
            remainder %= silverCoinValue;

            Console.WriteLine($"Gold coins: {goldCoins} \nSilver coins: {silverCoins} \nBronze coins: {remainder}");

            Console.ReadKey();
        }
    }
}
