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
            Airport airport = new Airport("Шереметьево", new List<IPlane>());           
            airport.GetDataFromConsole();
           
            try
            {

                Console.WriteLine("Самолеты аэропорта\n {0,10}\t{1,10}\t{2,10}\t{3,10}", "Название", "Бортовой номер", "Кол-во мест", "Дальность полета");
                airport.GetListOfPlanes().ToConsole(x => (String.Format("\n{0,10}\t{1,10}\t{2,10}\t{3,10}", x.Name, x.BortNumber, x.CountOfSeats, x.FlightRange))).ToList(); 
                
                airport.PrintPlanesAndGroupByTypes();
                Console.WriteLine("\nВывод самолетов в алфавитном порядке по бортовому номеру: \n {0,10}\t{1,10}\t{2,10}\t{3,10}", "Название", "Бортовой номер", "Кол-во мест", "Дальность полета");
                airport.SortByBortNumber().ToConsole(x => (String.Format("{0,10}\t{1,10}\t{2,10}\t{3,10}", x.Name, x.BortNumber, x.CountOfSeats, x.FlightRange))).ToList();
                Console.WriteLine("\nВывод самолетов с максимальным количеством мест: \n {0,10}\t{1,10}\t{2,10}\t{3,10}", "Название", "Бортовой номер", "Кол-во мест", "Дальность полета");
                airport.GetListOfPlainsByMaxSeats().ToConsole(x => (String.Format("\n{0,10}\t{1,10}\t{2,10}\t{3,10}", x.Name, x.BortNumber, x.CountOfSeats, x.FlightRange))).ToList();
                Console.WriteLine("\nМинимальная дальность полета: {0}\n Максимальная дальность полета: {1}\n Средняя дальность полета: {2}", airport.GetMinFlightRange(), airport.GetMaxFlightRange(), airport.GetAvgFlightRange());


                Console.WriteLine("\nВывод самолетов по букве в бортовом номере:");
                airport.GetListOfPlainsByLetter().ToConsole(x => (String.Format("\n{0,10}\t{1,10}\t{2,10}\t{3,10}",  x.Name, x.BortNumber, x.CountOfSeats, x.FlightRange))).ToList();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

        }
    }
}
