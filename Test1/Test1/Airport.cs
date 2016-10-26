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
        private List<Plane> _listOfPlane = new List<Plane>();
        public List<Plane> ListOfPlane
        {
            get { return _listOfPlane; }
            set { _listOfPlane = value; }
        }
        public Airport(string name)
        {
            _name = name;
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
                Console.Write("type your string: ");
                inputString = Console.ReadLine();
                if (inputString != "")
                {
                    substring = inputString.Split(',');
                    name = substring[0];
                    bortNumber = substring[1];
                    countOfSeats = int.Parse(substring[2]);
                    flightRange = int.Parse(substring[3]);
                    this.ListOfPlane.Add(new Plane(name, bortNumber, countOfSeats, flightRange));
                }
            }
            while (inputString != "");
        }

        public void GetListOfPlains()
        {
            Console.WriteLine("Airport" + this.Name);
            foreach (var x in this.ListOfPlane)
            {
                Console.WriteLine(x.Name + " "+x.BortNumber+" "+x.CountOfSeats+ " " + x.FlightRange);

            }
        }

    }
}
