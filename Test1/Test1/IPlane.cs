using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public interface IPlane
    {
      string Name { get; }
      string BortNumber { get;  }
      int CountOfSeats { get;  }
      int FlightRange { get; }
      void LetsGo();
        
    }
}
