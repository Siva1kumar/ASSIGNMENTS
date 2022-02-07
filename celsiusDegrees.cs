using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class celsiusDegrees
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter the amount  of celsius:");
            int celisius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kelvin = {0}",celisius+273);
            Console.WriteLine("Fahrenheit={0}", celisius*18/10+32);
        }
    }
}
