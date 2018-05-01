using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7InvalidInputs
{
    class Program
    {
        //Main Function
        static void Main(string[] args)
        {

            //User prompts (loop statements)
            Console.WriteLine("Please enter a valid Name:");
            string ValidName = Console.ReadLine();

            //while loop is calling the function that validates the input
            while (!IsName(ValidName))
            {
                //If they enter an invalid name this will loop back around and tell them to enter a valid name.
                Console.WriteLine("Sorry, name is not valid");
                Console.WriteLine("Please enter a valid Name");
                ValidName = Console.ReadLine();
            }

            Console.WriteLine("Please enter a valid email");
            string ValidEmail = Console.ReadLine();

            while (!IsEmail(ValidEmail))
            {
                Console.WriteLine("Sorry, email is not valid");
                Console.WriteLine("Please enter a valid Email");
                //Methods have to end with ()
                ValidEmail = Console.ReadLine();
            }


            Console.WriteLine("Please enter a vaild phone number");
            string ValidPhone = Console.ReadLine();
            
           while (!IsPhone(ValidPhone))
           {
                Console.WriteLine("Sorry, phone number is not valid");
                Console.WriteLine("Please enter a valid Phone Number");
                ValidPhone = Console.ReadLine();
           }

            Console.WriteLine("Please enter a valid Date");
            string ValidDate = Console.ReadLine();
            
            while (!IsDate(ValidDate))
            {
                Console.WriteLine("Sorry, date is not valid");
                Console.WriteLine("Please enter a valid Date");
                ValidDate = Console.ReadLine();
            }

        }
        //Method
        static bool IsName(string ValidName)
        {
            return (Regex.IsMatch(ValidName, @"[A-Z][a-z]{1,29}"));
        }

        //Methods=anything with perameter (verifying the info is valid)
        static bool IsEmail (string ValidEmail)
        {
            //returning a true or false does this match this statement
            return Regex.IsMatch(ValidEmail, @"^([\w\.]{5,30}@\w{5,10}.\w{2,3})$");
        }

        static bool IsPhone(string ValidPhone)
        {
            return Regex.IsMatch(ValidPhone, @"^\d{3}-\d{3}-\d{4}$");
        }

        static bool IsDate(string ValidDate)
        {
            return Regex.IsMatch(ValidDate, @"^\d{2,2}/\d{2,2}/\d{4,4}$");
        }


    }
}
