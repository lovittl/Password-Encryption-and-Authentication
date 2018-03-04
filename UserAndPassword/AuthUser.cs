using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAndPassword
{
    class AuthUser
    {
        public void CheckUserPass()
        {
            UserPass UnPPair = new UserPass();
            string userAuth = "";
            string passAuth = "";

            Console.Clear();
            Console.WriteLine("Enter user name to be authenticated");
            userAuth = Console.ReadLine();
            
            Console.WriteLine("Enter Password to be authenticated");
            passAuth = Console.ReadLine();
            
            Console.WriteLine($"\nUser Name: {userAuth}");
            Console.WriteLine($"User Password: {passAuth}");
            Console.WriteLine("Press Enter to Return to Main Menu");
            Console.Read();

            /*
            When user selects option 2 allow them to enter a user name and password
               check the user name and password against user names and passwords entered in option 1 and 

            if user name and password are found in data structure in class UserPass (or not) then return feedback to the user

            // STRETCH GOAL:  Simulate decryption of password 
            */
        }
    }
}
