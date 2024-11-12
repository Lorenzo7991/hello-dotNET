using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_dotNET
{
    public class Bike : IDriveable
    {
        public void Drive()
        {
            Console.WriteLine("Riding...");
        }

    }



}
