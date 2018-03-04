using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAndPassword
{
    class UserPass
    {
        public String user;
        public String pass;
        public List<string> usersList = new List<String>();
        public List<string> passList = new List<string>();

        public void GetUnameAndPass()
        {
            //Collect User Name
            Console.Clear();
            Console.WriteLine("Enter UserName:");
            this.user = Console.ReadLine();
            usersList.Add(this.user);

            //Collect Password
            Console.WriteLine("Enter Password:");
            this.pass = Console.ReadLine();
            passList.Add(this.pass);

            Console.WriteLine("Press enter to return to main menu.");
            Console.Read();
        }
    }
}
