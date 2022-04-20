using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingRoots
{
    public class FindingRoots
    {
        public void Roots()
        {
            double a, b, c;
            double d, X1, X2;

            Console.WriteLine("Enter a value of a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a value of b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a value of c: ");
            c = Convert.ToDouble(Console.ReadLine());

            d = (b*b) -(4*a*c);

            X1 = (­b+Math.Sqrt(d))/(2*a);
            X2 = (­b-Math.Sqrt(d))/(2 * a);
            Console.WriteLine("Root X1: " + X1);
            Console.WriteLine("Root X2: " + X2);
        }
        

    }
}
