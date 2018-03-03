using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAndPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            // Splash screen explaining the UserAndPasswordProgram

            Console.WriteLine("** WELCOME TO USER AND PASSWORD! **\n");
            Console.WriteLine("This program will collect a plain text password from an individual user \n" +
                              "and store the password in a string cipher, verify a user by username and password.\n\n\n" +
                              "Press Enter to Display Menu");
            
            //*find out why a return is required to display menu*
            
            Console.ReadLine();

            // Creates an instance of the Menu class

            Menu M1 = new Menu();
            Menu runner = new Menu();
            runner.Run();
        }
    }
}

