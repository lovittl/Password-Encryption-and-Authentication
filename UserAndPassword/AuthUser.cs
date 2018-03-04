using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAndPassword
{
    class AuthUser
    {
        // Objects of class types
        //public UserPass UnP_Pair;


        public void CheckUserPass()
        {
            UserPass UnPPair = new UserPass();
            string userAuth = "";
            string passAuth = "";

            Console.WriteLine("Enter User Name to be Authenticated:");
            userAuth = Console.ReadLine();

            Console.WriteLine("Enter Password to be Authenticated:");
            passAuth = Console.ReadLine();


            if (UnPPair.usersList.Contains(userAuth) && (UnPPair.passList.Contains(passAuth)))
            {
                Console.WriteLine("authenticated");
                Console.WriteLine("Press Enter to Return to Main Menu");
            } 
            else
            {
                Console.WriteLine("Not Authorized");
            }
            Console.WriteLine("Press Enter to Return to Main Menu");
            Console.ReadLine();
        }
    }
}
