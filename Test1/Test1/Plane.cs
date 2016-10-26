using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
  public class Plane
    {
      public string Name { get; set; }
      public string BortNumber { get; set; }
      public int CountOfSeats { get; set; }
      public int FlightRange { get; set; }



        public Plane(string name, string bortNumber, int countOfSeats, int flightRange)
        {
           Name = name;
           BortNumber = bortNumber;
           CountOfSeats = countOfSeats;
           FlightRange = flightRange;
        }

    }
}
