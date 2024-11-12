using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_dotNET
{
 
    public class Car : IDriveable
    {
        public void Drive()
        {
            Console.WriteLine("Driving...");
        }
    
    }

}
