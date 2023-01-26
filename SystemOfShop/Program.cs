using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOfShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.WriteLine("Данные: " + user.Enter());
            Console.WriteLine("Итог: " + user.GetName().ToString());
            Console.ReadKey();
        }
    }
}
