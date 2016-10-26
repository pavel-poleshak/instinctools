using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Airport
    {
        private string _name;        

        public List<Plane> ListOfPlane
        {            get; set ;        }
        
        public Airport(string name)
        {
            _name = name;
            ListOfPlane = new List<Plane>();
        }
       
        public string Name
        {
            get { return _name; }
        }

        public void AddPlains()
        {
            string inputString = null;
            string[] substring = null;
            string name = null;
            string bortNumber = null;
            int countOfSeats = 0;
            int flightRange = 0;
            do
            {
                Console.Write("Введите данные самолета (например.: Boeing 747,LX-100,250,3400): ");
                inputString = Console.ReadLine();
                if (inputString != String.Empty)
                {
                    substring = inputString.Split(',');
                    name = substring[0];
                    bortNumber = substring[1];
                    countOfSeats = int.Parse(substring[2]);
                    flightRange = int.Parse(substring[3]);
                    this.ListOfPlane.Add(new Plane(name, bortNumber, countOfSeats, flightRange));
                }
                
            }
            while (inputString != String.Empty);
        }

        public IEnumerable<Plane> GetListOfPlains()
        {
            return this.ListOfPlane;
            
        }


        public bool HasPlanes()
        {
            if (this.GetListOfPlains().ToArray().Length == 0) { return true; }
            else return false;
        }

        public void PrintListOfPlanes()
        {
            
            if (HasPlanes())
            {
                Console.WriteLine("Аэоропорт не имеет самолетов");
            }
            else
            {
                Console.WriteLine(String.Format("Аэропорт {0} включает следующие самолеты:", this.Name));
                this.GetListOfPlains().ToConsole(x => (String.Format("{0}\t{1}\t{2}\t{3}", x.Name, x.BortNumber, x.CountOfSeats, x.FlightRange))).ToList();
                
            }
        }

        public IEnumerable<Plane> SortByBortNumber()
        {
            IEnumerable<Plane> sortedList= this.ListOfPlane.OrderBy(x => x.BortNumber);
            return sortedList;

        }

        public IEnumerable<Plane> GetListOfPlainsByMaxSeats()
        {
            int maxSeat = this.GetListOfPlains().Max(x => x.CountOfSeats);
            IEnumerable<Plane> list = from p in this.ListOfPlane
                                      where (p.CountOfSeats == maxSeat)
                                      select p;
            return list;                          
        }

        public int GetMinFlightRange()
        {
            int minFlightrange = this.GetListOfPlains().Min(x => x.FlightRange);
            return minFlightrange;
        }
        public int GetMaxFlightRange()
        {
            int maxFlightrange = this.GetListOfPlains().Max(x => x.FlightRange);
            return maxFlightrange;
        }
        public double GetAvgFlightRange()
        {
            double avgFlightrange = this.GetListOfPlains().Average(x => x.FlightRange);
            return avgFlightrange;
        }


        public IEnumerable<Plane> GetListOfPlainsByLetter()
        {
            Console.WriteLine("Введите символ или набор символов для поиска:");
            string template = Console.ReadLine().ToUpper();
            IEnumerable<Plane> list = from p in this.ListOfPlane
                                      where (p.BortNumber.ToUpper().Contains(template))
                                      select p;
            return list;
        }

        


      

    }
}
