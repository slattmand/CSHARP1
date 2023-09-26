using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            korclass kor1 = new korclass(3.13);
            kor1.setKerulet(kor1.getSugar());
            kor1.setTerulet();

            Console.WriteLine("A {0:0.0000}cm sugarú kör kerülete {1:0.0000}cm, területe {2:0.0000}cm2", kor1.getSugar(), kor1.getKerulet(), kor1.getTerulet());

            Console.ReadKey();

            

        }
    }
}
