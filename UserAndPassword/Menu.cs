//create menu to 

/*
  (1) collect a plain text password from an individual user and stores the password in a string cipher
  (2) verifies a user by username and password.
  
        interface options: 
        (1) save a new password for a specific username
        (2) authenticate a specific username/password pair
        (3) exit the application. On exit, all username/password pairs will be lost 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAndPassword
{
    class Menu
    {
        bool quit = false;

        public void Run()
        {

            do
            {
                Console.Clear();
                DispayMainMenu();
                quit = ElicitUserInput();
            }
            while (!quit);
        }

        // Displays main menu options
        void DispayMainMenu()
        {
            Console.WriteLine("Main Menu:  ***Please Make Selection***");
            Console.WriteLine(" 1) Establish an account");
            Console.WriteLine(" 2) Authenticate a user");
            Console.WriteLine(" 3) Exit the system");
        }


        // Handles main navigation from the user
        bool ElicitUserInput()
        {
            bool quit = false;
            bool isValid = false;

            do
            {
                try
                {
                    Console.Write("Please select an option:");

                    int choice = int.Parse(Console.ReadLine());
                    Console.Clear();

                    isValid = true;

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Insert code to input username and password pair");
                            break;

                        case 2:
                            Console.WriteLine("Insert code to Authenticate a User");
                            break;

                        case 3:
                            Console.WriteLine("Exit");
                            break;

                        default:
                            isValid = false;
                            Console.WriteLine("Selection must be 1, 2, or 3. Try again!");
                            break;
                    }
                }

                catch (FormatException)
                {
                    isValid = false;
                }
            }
            while (!quit && !isValid);

            return quit;


        }
    }
}
