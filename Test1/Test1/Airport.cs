using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{

    public class Airport
    {
        public string Name
        {
            get;
            private set;
        }

        public ICollection<IPlane> ListOfPlane
        {
            get;
            private set;
        }
        
        public Airport(string name, ICollection<IPlane> listOfPlane)
        {
            Name = name;
            ListOfPlane = listOfPlane;            
        }
          
        public void GetDataFromConsole()
        {
            string typeOfPlane = null;
            string planeSpec = null;
            do
            {
                Console.Write("Тип самолета: (T/P): ");
                typeOfPlane = Console.ReadLine().Trim().ToUpper();
                if (typeOfPlane != String.Empty)
                {
                    if (!((typeOfPlane.Equals("T")) || (typeOfPlane.Equals("P"))))
                    {
                        Console.WriteLine("Параметр введен неверно. Повторите ввод.");

                        GetDataFromConsole();
                    }                   
                    string[] substring = null;
                    string name = null;
                    string bortNumber = null;
                    int countOfSeats = 0;
                    int flightRange = 0;
                   
                        Console.Write("Введите данные самолета (например.: Boeing 747,LX-100,250,3400): ");
                        planeSpec = Console.ReadLine();
                        if (planeSpec != String.Empty)
                        {
                            try
                            {
                                substring = planeSpec.Split(',');
                                name = substring[0];
                                bortNumber = substring[1];
                                countOfSeats = int.Parse(substring[2]);
                                flightRange = int.Parse(substring[3]);
                                AddPlane(name, bortNumber, countOfSeats, flightRange, typeOfPlane);
                            }
                            catch (IndexOutOfRangeException)
                            {
                                Console.WriteLine("Некорректно введенная строка. Повторите ввод");
                                GetDataFromConsole();                                
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine(ex.Message + "Параметр <количество мест>, <дальность полета> должен принимать целочисленное значение. Повторите ввод");
                                GetDataFromConsole();                                
                            }
                        }
                }

            }
             

            while (typeOfPlane != String.Empty);
            Console.WriteLine("Ввод окончен");
            
            
        }
        protected IPlane GetObjectByType(string name, string bortNumber, int countOfSeats, int flightRange, string type)
        {
            switch (type)
            {
                case "T": return new TransportPlane(name, bortNumber, countOfSeats, flightRange);
                case "P": return new PassengerPlane(name, bortNumber, countOfSeats, flightRange);
                default: throw new Exception("неизвестный тип");
            }
        }

        protected void AddPlane(string _name, string bortNumber, int countOfSeats, int flightRange, string _type)
        {
            string name = _name;
            string type = _type;
            ListOfPlane.Add(GetObjectByType(name, bortNumber, countOfSeats, flightRange, type));
        }

        public bool HasPlanes()
        {
            if (ListOfPlane.Count == 0) { return true; }
            else return false;
        }

        public IEnumerable<IPlane> GetListOfPlanes()
        { 
            return ListOfPlane; 
        }

        public IEnumerable<IPlane> DoSomething<T>() where T : IPlane
        {
            var list = from p in ListOfPlane
                       where (p.GetType() == typeof(T))
                       select p;
            return list;
        }


        public IEnumerable<IPlane> SortByBortNumber()
        {
            IEnumerable<IPlane> sortedList= ListOfPlane.OrderBy(x => x.BortNumber);
            return sortedList;
        }

        public IEnumerable<IPlane> GetListOfPlainsByMaxSeats()
        {

            int maxSeat = ListOfPlane.Max(x => x.CountOfSeats);
            IEnumerable<IPlane> list = from p in ListOfPlane
                                       where (p.CountOfSeats == maxSeat)
                                       select p;
            return list;
        }



        public int GetMinFlightRange()
        {

            int minFlightrange = ListOfPlane.Min(x => x.FlightRange);
            return minFlightrange;
        }
        
        
        public int GetMaxFlightRange()
        {
            int maxFlightrange = ListOfPlane.Max(x => x.FlightRange);
            return maxFlightrange;
        }
        public double GetAvgFlightRange()
        {
            double avgFlightrange = ListOfPlane.Average(x => x.FlightRange);
            return avgFlightrange;
        }


        public IEnumerable<IPlane> GetListOfPlainsByLetter()
        {
            Console.WriteLine("Введите символ или набор символов для поиска:");
            string template = Console.ReadLine().ToUpper();
            Console.WriteLine("\n {0,10}\t{1,10}\t{2,10}\t{3,10}", "Название", "Бортовой номер", "Кол-во мест", "Дальность полета");
            IEnumerable<IPlane> list = from p in this.ListOfPlane
                                      where (p.BortNumber.ToUpper().Contains(template))
                                      select p;
            return list;
        }


        public void PrintPlanesAndGroupByTypes()
        {
            Console.WriteLine("Пассажирские самолеты\n {0,10}\t{1,10}\t{2,10}\t{3,10}", "Название", "Бортовой номер", "Кол-во мест", "Дальность полета");
            DoSomething<PassengerPlane>().ToConsole(x => (String.Format("\n{0,10}\t{1,10}\t{2,10}\t{3,10}",x.Name, x.BortNumber, x.CountOfSeats, x.FlightRange))).ToList();
            Console.WriteLine("Транспортные самолеты\n {0,10}\t{1,10}\t{2,10}\t{3,10}", "Название", "Бортовой номер", "Кол-во мест", "Дальность полета");
            DoSomething<TransportPlane>().ToConsole(x => (String.Format("\n {0,10}\t{1,10}\t{2,10}\t{3,10}", x.Name, x.BortNumber, x.CountOfSeats, x.FlightRange))).ToList();
        }

        


      

    }
}
