using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOfShop
{
    internal class Admin : User
    {
        public override bool Enter(string login, string password)
        {
            return base.Enter(login, password);
        }
    }
}
