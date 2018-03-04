﻿using System;
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
        List<string> usersList = new List<String>();
        List<string> passList = new List<string>();

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


            //test to check syntax for validation (remove after UserAuth class built)
            if (usersList.Contains(user))
            {
                Console.WriteLine("authenticated");
            }
            else
            {
                Console.WriteLine("unauthorized");
            }


            //test to print users and passwords
            Console.WriteLine(usersList);
            Console.Write(passList);

            Console.Read();
        }
    }
}
