using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Object[] oArrObjects = new Object[3];
            oArrObjects[0] = "1st Element";
            oArrObjects[1] = 101;

            Customer oCustomer =  new Customer();
            oCustomer.ID = 1002;
            oCustomer.Name = "Sreemonta";

            oArrObjects[2] = oCustomer;

            foreach (object item in oArrObjects)
            {
                Console.WriteLine(item);
            }
            Console.Read();

        }
    }
}
