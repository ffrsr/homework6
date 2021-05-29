using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ข้อ2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double money;

            Console.Write("Please input money :");
            money = double.Parse(Console.ReadLine());

            Console.WriteLine("Vat : {0} bath", Math.Round(money * 0.07));
            
            Console.WriteLine("Total money : {0} bath", money + Math.Round(money * 0.07));
            
            Console.ReadLine();
        }
       
    }
}
