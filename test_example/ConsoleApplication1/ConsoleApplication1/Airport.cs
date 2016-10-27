using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  public  class Airport
    {
      public ICollection<IPlane> ListOfPlane { get; set; }
      public Airport(ICollection<IPlane> list)
      {
          ListOfPlane = list;
      }
     
      

      public void GetDataFromConsole()
      {
          string typeOfPlane = null;
          
          
          Console.Write("Тип самолета: (T/P): ");
          typeOfPlane = Console.ReadLine().Trim().ToUpper();
          
          if (!((typeOfPlane.Equals("T")) || (typeOfPlane.Equals("P"))))
          {
              Console.WriteLine("Параметр введен неверно. Повторите ввод.");
              GetDataFromConsole();             
          }
          Console.Write("Введите параметры: ");
          string name =Console.ReadLine().Trim();
          AddPlane(name, typeOfPlane);
      }
      protected IPlane GetObjectByType(string name, string type)
      {
          switch (type)
          {
              case "T": return new TransportPlane(name); 
              case "P": return new PassengerPlane(name);
              default: throw new Exception("неизвестный тип");
          }
      }

      protected void AddPlane(string _name, string _type)
      {
          string name = _name;
          string type = _type;
          ListOfPlane.Add(GetObjectByType(name, type));
      }
        

    }
}
