using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cheers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //// VARIABLES SECTION ////
            string prompt = "> ";
            string cheerPrefix = "Give me a";

            Console.WriteLine("What's your name??");
            Console.Write(prompt);
            string nameInput = Console.ReadLine();

            
            for (int i = 0; i < nameInput.Length; i++)
            {
                Console.WriteLine(cheerPrefix + " .. " + nameInput[i].ToString().ToLower());                
            }


            Console.WriteLine(nameInput.ToUpper() + " is ... THE TITS!");
        }
    }
}
