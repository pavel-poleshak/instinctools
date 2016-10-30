using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
  public abstract class Plane:IPlane
    {
      public string Name { get; private set; }
      public string BortNumber { get; private set; }
      public int CountOfSeats { get; private set; }
      public int FlightRange { get; private set; }

      public Plane(string name, string bortNumber, int countOfSeats, int flightRange)
      {
          Name = name;
          BortNumber = bortNumber;
          CountOfSeats = countOfSeats;
          FlightRange = flightRange;
      }

      public virtual void LetsGo()
      { }
    }
}
