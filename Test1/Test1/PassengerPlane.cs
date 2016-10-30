using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class PassengerPlane:Plane
    {
        public PassengerPlane(string name, string bortNumber, int countOfSeats, int flightRange)
            : base(name, bortNumber, countOfSeats, flightRange)
        { }

        public override void LetsGo()
        {
            Console.WriteLine("Its a Passenger Plane!");
        }


    }
}
