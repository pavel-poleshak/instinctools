using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
  public class Plane:IPlane
    {
      private readonly string _name;
      private readonly string _bortNumber;
      private readonly int _countOfSeats;
      private readonly int _flightRange;

      public string Name { get { return _name; } }
      public string BortNumber { get { return _bortNumber; } }
      public int CountOfSeats { get { return _countOfSeats; } }
      public int FlightRange { get { return _flightRange; } }




      public Plane(string name, string bortNumber, int countOfSeats, int flightRange)
      {
          _name = name;
          _bortNumber = bortNumber;
          _countOfSeats = countOfSeats;
          _flightRange = flightRange;
      }



      public virtual void LetsGo()
      {
          throw new NotImplementedException();
      }
    }
}
