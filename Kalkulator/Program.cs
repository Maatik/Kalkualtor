using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            string dzialanie = "";
            Console.Write("podaj a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("podaj b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Co chcesz zrobić: ? " + '\n' + "1. Dodawanie wpisz + " + '\n' + "2. Odejmowanie wpisz - " + '\n' + "3. Mnożenie wpisz * " + '\n' + "4. Mnożenie wpisz / ");
            dzialanie = Console.ReadLine();

            Kalkulator kalkulator = new Kalkulator(a, b, dzialanie);

            switch (dzialanie)
            {
                case "+":
                    Console.WriteLine("Dodwanie " + kalkulator.Dodowanie(a, b));
                    break;

                case "-":
                    Console.WriteLine("Odejmowanie " + kalkulator.Odejmowanie(a, b));
                    break;

                case "*":
                    Console.WriteLine("Mnozenie " + kalkulator.Mnożenie(a, b));
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Nie dzielimy przez 0!");
                    }
                    else
                    {
                        Console.WriteLine("Dzielenie " + kalkulator.Dzielenie(a, b));
                    }
                    break;
            }
            kalkulator.Zapis();
            //kalkulator.Dodowanie(a, b);
            //kalkulator.Dzielenie(a, b);
            //kalkulator.Mnożenie(a, b);
            //kalkulator.Odejmowanie(a, b);
            //Console.WriteLine("Dodwanie " +kalkulator.Dodowanie(a, b));
            //Console.WriteLine("Dzielenie " + kalkulator.Dzielenie(a, b));
            //Console.WriteLine("Mnozenie "+ kalkulator.Mnożenie(a, b));
            //Console.WriteLine("Odejmowanie " + kalkulator.Odejmowanie(a, b));
            //Console.WriteLine("Dodwanie " + kalkulator.Dodowanie(a, b,c));
            //Console.WriteLine("Mnozenie " + kalkulator.Mnożenie(a, b,c));
            //Console.WriteLine("Odejmowanie " + kalkulator.Odejmowanie(a, b,c));
            //Console.WriteLine("Odejmowanie " + kalkulator.Dodowanie(3,5,6));

            Console.ReadLine();

        }
    }
}
