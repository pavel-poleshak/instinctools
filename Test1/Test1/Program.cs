using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Airport airport = new Airport("Borov");
            airport.AddPlains();
            
            Console.WriteLine("===================================");
            airport.GetListOfPlains();
            Console.ReadLine();

        }
    }
}
