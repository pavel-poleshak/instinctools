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
                Console.Write("Insert plane data (ex.: Boeing 747,LX-100,250,3400): ");
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

        public void PrintListOfPlanes()
        {
            
            if (this.GetListOfPlains().ToArray().Length == 0)
            {
                Console.WriteLine("List of planes is null");
            }
            else
            {
                this.GetListOfPlains().ToConsole(x => (String.Format("{0}\t{1}\t{2}\t{3}", x.Name, x.BortNumber, x.CountOfSeats, x.FlightRange))).ToList();
            }
        }
        //public void GetListOfPlains()
        //{
        //    Console.WriteLine("Airport:" + " " + this.Name);
        //    foreach (var x in this.ListOfPlane)
        //    {
        //        Console.Write("\t ");
        //        Console.WriteLine(x.Name + " " + x.BortNumber + " " + x.CountOfSeats + " " + x.FlightRange);

        //    }
        //}

    }
}
