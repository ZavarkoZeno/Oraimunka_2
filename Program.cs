using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oraimunka_2
{
    internal class Program
    {
    static void Main(string[] args)
        { }
        public static void udvozol()
        {
             DateTime Now = DateTime.Now;
            int ora = Now.Hour;

            Console.Write("Adja meg az időt");

        if (ora < 12)
            {
                Console.WriteLine("Jó reggelt!");
            }
        else if (ora < 18)
            {
                Console.WriteLine("Jó napot!");
            }
        else
            {
                Console.WriteLine("Jó estét!");
            }
        }

        public static void kamat()
        {
            Console.Write("Kérem, adja meg az összeget (Ft): ");
            double principal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Kérem, adja meg az időtartamát (év): ");
            int years = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kérem, adja meg a kamatlábat (százalék): ");
            double interestRate = Convert.ToDouble(Console.ReadLine());

            double amount = principal * Math.Pow((1 + interestRate / 100), years);

            Console.WriteLine($"A lekötés végén a pénzösszeg: {amount:F2} Ft");

            Console.WriteLine("Nyomj meg egy billentyűt a kilépéshez...");
            Console.ReadKey();
        }

        public static void futas()
        {
            double kezdosebesseg;
            do
            {
                Console.Write("Kérem, adja meg a kezdő sebességet (3.00 - 5.00 m/s): ");
                kezdosebesseg = Convert.ToDouble(Console.ReadLine());
            } while (kezdosebesseg < 3.00 || kezdosebesseg > 5.00);

            for (int tavolsag = 0; tavolsag <= 100; tavolsag += 10)
            {
                double sebesseg;

                if (tavolsag < 50)
                {
                    sebesseg = kezdosebesseg + (tavolsag / 50.0) * (5.00 - kezdosebesseg);
                }
                else if (tavolsag > 90)
                {
                    sebesseg = kezdosebesseg + (50.0 / 50.0) * (5.00 - kezdosebesseg) - ((tavolsag - 90) / 10.0) * (5.00 - kezdosebesseg);
                }
                else
                {

                    sebesseg = 5.00;
                }

                double KmH = sebesseg * 3.6;

                Console.WriteLine($"Táv: {tavolsag} m, Sebesség: {KmH:F2} km/h");
            }

            Console.WriteLine("Nyomj meg egy billentyűt a kilépéshez...");
            Console.ReadKey();
        }
        
    }
}
