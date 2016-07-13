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
            string cheerPrefix = "Give me ";
            string requiresAn =  "aefhilmnorsxAEFHILMNORSX";
            string properArticle = "a";


            // Ask for the user's name.            
            Console.WriteLine("What's your stupid name??");
            // Accept input from the user and print their name. (Accept input)         
            Console.Write(prompt);
            string nameInput = Console.ReadLine();

            //After your user enters their name, your program should ask for their birthdate.
            //The user should only have to enter the Day and Month
            Console.WriteLine("What's your dang birthday??");
            Console.Write(prompt);
            string birthdayInput = Console.ReadLine();

            // Accept input from the user and print their name. (Print their name)
            // Cheer the user on.  
            for (int i = 0; i < nameInput.Length; i++) {
                if (requiresAn.IndexOf(nameInput[i]) > -1) {
                   properArticle = "an";
               } else {
                   properArticle = "a";
               }
                Console.WriteLine(cheerPrefix + properArticle + " .. " + nameInput[i].ToString().ToLower());                                           
            }
            Console.WriteLine(nameInput.ToUpper() + " is ... THE TITS!");

            // After the cheer, your program should tell the user how many more days there are until their next birthday.
            
        }
    }
}
