using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAndPassword
{
    class UserPass
    {

        String user;
        String pass;

        public void GetUnameAndPass()
        {
            Console.Clear();
            Console.WriteLine("Enter UserName:");
            this.user = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            this.pass = Console.ReadLine();

        }
    }
}
