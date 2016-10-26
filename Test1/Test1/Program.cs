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
            Airport airport = new Airport("Шереметьево");            
            airport.AddPlains();            
            Console.WriteLine("Ввод окончен");
            airport.PrintListOfPlanes();
            Console.WriteLine("******************************");
            Console.WriteLine("\nВывод самолетов в алфавитном порядке по бортовому номеру: ");
            airport.SortByBortNumber().ToConsole(x=>(String.Format("{0}\t{1}\t{2}\t{3}", x.Name, x.BortNumber, x.CountOfSeats, x.FlightRange))).ToList();
            Console.WriteLine("\nВывод самолетов с максимальным количеством мест: ");
            airport.GetListOfPlainsByMaxSeats().ToConsole(x => (String.Format("{0}\t{1}\t{2}\t{3}", x.Name, x.BortNumber, x.CountOfSeats, x.FlightRange))).ToList();
            Console.WriteLine("\nМинимальная дальность полета: {0}\n Максимальная дальность полета: {1}\n Средняя дальность полета: {2}", airport.GetMinFlightRange(), airport.GetMaxFlightRange(), airport.GetAvgFlightRange());


            Console.WriteLine("\nВывод самолетов по букве в бортовом номере: ");
            airport.GetListOfPlainsByLetter().ToConsole(x => (String.Format("{0}\t{1}\t{2}\t{3}", x.Name, x.BortNumber, x.CountOfSeats, x.FlightRange))).ToList();
            Console.ReadLine();

        }
    }
}
