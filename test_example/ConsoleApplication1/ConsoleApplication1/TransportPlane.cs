using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class TransportPlane:Plane
    {
        public TransportPlane(string name)
            : base(name)
        {
        }
        public override void LetsGo()
        {
            Console.WriteLine("Its a transport Plane");
        }

    }
}
