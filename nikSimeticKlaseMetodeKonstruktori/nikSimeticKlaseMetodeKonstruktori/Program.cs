 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nikSimeticKlaseMetodeKonstruktori
{
    class Program
    {
        static void Main(string[] args)
        {
            Proceduralni x = new Proceduralni();
            Objektni y = new Objektni();
            Funkcionalni z = new Funkcionalni();

            Console.WriteLine("Upisite postotak za proceduralni: ");
            x.Postotak = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Upisite postotak za objektni: ");
            y.Postotak = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Upisite postotak za funkcionalni: ");
            z.Postotak = Convert.ToDouble(Console.ReadLine());

            if(x.Postotak + y.Postotak + z.Postotak != 100)
            {
                Console.WriteLine("Neispravni podatci");
            }
            else
            {
                if(x.Postotak > y.Postotak && x.Postotak > z.Postotak)
                {
                    Console.WriteLine("Najzatupljeniji tip jezika je Proceduralni");
                }
                else if(y.Postotak > z.Postotak)
                {
                    Console.WriteLine("Najzzatupljenji tip jezika je Objektni");
                }
                else
                {
                    Console.WriteLine("Najzatupljenji tip jezika je Funkcionalni");
                }
            }
            Console.ReadKey();
        }
    }
}
