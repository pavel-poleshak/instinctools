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
            airport.PrintListOfPlanes();
            airport.SortByBortNumber().ToConsole(x=>(String.Format("{0}\t{1}\t{2}\t{3}", x.Name, x.BortNumber, x.CountOfSeats, x.FlightRange))).ToList();
          
            Console.ReadLine();

        }
    }
}
