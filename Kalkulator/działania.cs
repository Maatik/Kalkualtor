using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kalkulator
{
    class Kalkulator
    {
        double a = 0;
        double b = 0;
        string rodz_dzialanie = "";
        double wynik;

        public Kalkulator(double a, double b, string rodz_dzialanie)
        {
            this.a = a;
            this.b = b;
            this.rodz_dzialanie = rodz_dzialanie;
        }
      

        public double Dodowanie(double a , double b)
        {
            
            wynik = a + b;
            return wynik;
        }
        public double Odejmowanie(double a, double b)
        {
            
            
            
                wynik = a - b;
            
            return wynik;
        }
        public double Mnożenie(double a, double b)
        {
            
            wynik = a * b;
            return wynik;
        }
        public double Dzielenie(double x, double y)
        {
            

           
                wynik = x / y;
            
            
            return wynik;
        }
        public double Dodowanie(double a, double b, double c)
        {
            
            wynik = a + b + c;
            return wynik;
        }
        public double Odejmowanie(double a, double b, double c)
        {
            
            if (a > b)
            {
                wynik = a - b - c;
            }
            else if (b > a)
            {
                wynik = b - a - c;
            }
            else
            {
                wynik = a - a - c;
            }
            return wynik;
        }
        public double Mnożenie(double a, double b, double c)
        {
            
            wynik = a * b*c;
            return wynik;
        }
        public void Zapis()
        {
            string path1 = "C:\\Users\\mjankiewicz\\Desktop\\TEST1.txt";
            string path = "C:\\Users\\mjankiewicz\\Desktop\\TEST.txt";
            File.AppendAllText(path1, "Rodzaj dzialania: " + rodz_dzialanie + '\n' + "a = " + a + '\n' + "b = " + b + '\n' + "wynik = " + wynik + '\n' + "==============" + '\n');
            FileStream fileStream = new FileStream(path,FileMode.OpenOrCreate, FileAccess.ReadWrite);
            
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                

                writer.Write("Rodzaj dzialania: " + rodz_dzialanie + '\n' + "a = " + a + '\n' + "b = " + b + '\n' + "wynik = " + wynik);

                Console.WriteLine("Zapisano!");
            }
            fileStream.Close();
            

        }

    }
}
