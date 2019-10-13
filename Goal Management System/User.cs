using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proooooooooooject
{
   public class User
    {
        private string username;
        private string userpassword;
        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Userpassword
        {
            get
            {
                return userpassword;
            }

            set
            {
                userpassword = value;
            }
        }
    }
}
