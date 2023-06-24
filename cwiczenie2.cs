using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj współrzędne punktu początkowego:");
            Console.Write("x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj współrzędne punktu końcowego:");
            Console.Write("x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2: ");
            double y2 = double.Parse(Console.ReadLine());

            double dlugoscOdcinka = ObliczDlugoscOdcinka(x1, y1, x2, y2);

            Console.WriteLine("Długość odcinka wynosi: " + dlugoscOdcinka);
            Console.ReadKey();
        }

        static double ObliczDlugoscOdcinka(double x1, double y1, double x2, double y2)
        {
            double dlugosc = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return dlugosc;
        }
    }
}
