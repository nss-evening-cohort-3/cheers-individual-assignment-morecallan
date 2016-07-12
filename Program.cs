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
            Console.WriteLine("What's your name??");
            Console.Write("> ");
            string nameInput = Console.ReadLine();

            
            for (int i = 0; i < nameInput.Length; i++)
            {
                Console.WriteLine("Give me " + "a" + ".." + nameInput[i].ToString().ToLower());                
            }


            Console.WriteLine(nameInput.ToUpper() + " is ... THE TITS!");
        }
    }
}
