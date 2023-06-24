using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int uplywajacyCzas = 332;
            string sformatowanyCzas = FormatujCzas(uplywajacyCzas);
            Console.WriteLine(sformatowanyCzas);
            Console.ReadKey();
        }
        public static string FormatujCzas(int sekundy)
        {
            int godziny = sekundy / 3600;
            int minuty = (sekundy % 3600) / 60;
            int pozostaleSekundy = sekundy % 60;

            string sformatowanyCzas = $"{godziny:00}:{minuty:00}:{pozostaleSekundy:00}";
            return sformatowanyCzas;
        }
    }
}
