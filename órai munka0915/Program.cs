using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace órai_munka0915
{
    class Kor
    {
        public int r;
        public double Kerulet()
        {
            return 2 * r * Math.PI;
        }
        public double Terulet()
        {
            return Math.Pow(r,2) * Math.PI;
        }
    }
    class Teglalap
    {
        public int a;
            public int b;
        public int Kerulet()
        {
            return 2 * (a + b);
        }
        public int Terulet()
        {
            return a * b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Teglalap oldal = new Teglalap();
            Console.WriteLine("Írd be a téglalap A oldalát: ");
            oldal.a = int.Parse(Console.ReadLine());
            Console.WriteLine("Írd be a téglalap B oldalát: ");
            oldal.b = int.Parse(Console.ReadLine());

            Console.WriteLine("A téglalap kerülete {0}.",oldal.Kerulet());
            Console.WriteLine("A téglalap területe {0}.",oldal.Terulet());

            Console.WriteLine();

            Kor k = new Kor();

            Console.WriteLine("Írd be a kör sugarát: ");
            k.r = int.Parse(Console.ReadLine());

            Console.WriteLine("A kör kerülete {0}.",k.Kerulet());
            Console.WriteLine("A kör területe {0}.",k.Terulet());


            Console.ReadKey();
        }
    }
}
