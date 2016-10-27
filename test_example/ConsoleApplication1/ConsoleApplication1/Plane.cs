using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  public abstract class Plane:IPlane
    {
      
      public string Name { get; protected set; }

      public virtual void LetsGo()
      {
          ;
      }
     
      public Plane(string name)
      {
          Name = name;
      }  
      

    }
}
