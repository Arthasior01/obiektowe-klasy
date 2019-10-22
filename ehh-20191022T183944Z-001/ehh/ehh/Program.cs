using System;

namespace ehh
{
    class Program
    {
        static void Main()
        {
            Car c1 = new Car(10, "BMW");
            c1.wypisz();
            Console.WriteLine(Car.iloscKol);
            //Console.WriteLine("Podaj pojemnosc silnika i marke");
            //Car c2 = Car.Create();
            //c2.wypisz();
            //Console.WriteLine("Podaj pojemnosc silnika i marke");
            //Car c3 = Car.Create();
            //c3.wypisz();
            Car c2 = new Car(5, "Smart");
            c2 = c1;
        }

    }
     public class Car
    {
        private double pojemnoscSilnika;
        private string marka;
        public static int iloscKol;
        
        public Car(double pojemnoscSilnika, string marka)
        {
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.marka = marka;
        }
        static Car()
        {
            iloscKol = 4;
        }
        public void wypisz()
        {
            Console.WriteLine("{0}  {1}", marka, pojemnoscSilnika);
        }
        public static Car Create()
        {
            return new Car(Convert.ToDouble(Console.ReadLine()), Convert.ToString(Console.ReadLine()));
        }
        ~Car()
        {
            Console.WriteLine("Zwalniam pamiec");
            Console.ReadKey();
        }
    }
}
