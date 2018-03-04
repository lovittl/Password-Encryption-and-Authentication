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
        // Objects of class types
        public UserPass UnP;
        bool quit = false;

        public void Run()  //METHOD TO KICK OFF PROCESSING AFTER SPLASH AT MAIN
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

            //public Menu mainMenu;
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
                            
                            UserPass UnP = new UserPass();
                            UnP.GetUnameAndPass();
                            //[x]Write a user interface that gives the user three options. Option 1 is to create an account by entering a username and a password.
                            break;

                        case 2:

                            AuthUser authPass = new AuthUser();
                            authPass.CheckUserPass();
                            //[ ]authenticate a user by entering a username and password
                            break;
                            
                        case 3:
                            Console.WriteLine("Exit");
                            quit = true;
                            break;
                            //[ ]Upon exit, the application will print all username/password pairs previously entered. 

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
