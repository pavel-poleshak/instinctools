using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Airport airport = new Airport(new List<IPlane>());
            airport.GetDataFromConsole();
           
            

           
            Console.ReadLine();
        }
    }
}
