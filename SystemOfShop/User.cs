using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace SystemOfShop
{
    internal class User
    {
        private string name;
        private string login;
        private string password;
        public void Users(string name, string login, string password)
        {
            name = "Сергей";
            login = "Sergey";
            password = "12345678";
        }
        public virtual bool Enter(string login, string password)
        {
            login = Console.ReadLine();
            password = Console.ReadLine();
            bool result;
            if(login != null & password != null)
            {
                result = true;
            }
            else { result = false; }
            return result;
        }
    }
}
