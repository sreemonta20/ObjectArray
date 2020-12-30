using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectArray
{
    public class Customer
    {
        public int ID { get; set; }
        public String Name { get; set; }

        public override string ToString()
        {
            return "Customer ID is "+this.ID+" and Name is "+ this.Name;
        }
    }
}
