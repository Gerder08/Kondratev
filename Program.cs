using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kondratev
{
    
    public class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Word");
            var Vector = new Vect(1, 3, 4, 8);
            Console.WriteLine(Vector.ToString());
            Console.WriteLine(Vector.ToString("A"));
        }
           
    }
}
