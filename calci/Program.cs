using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b value: ");
            int j = Convert.ToInt32(Console.ReadLine());


            ADD add1 = new ADD();
            add1.add(ref i, ref j);

            Console.ReadLine();
        }
    }
}
