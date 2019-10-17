using System;

namespace program
{
    class Program
    {

        static void Main(string[] args)
        {
            string carName;
            carName = "Mój samochód";
            Console.WriteLine(carName);
            Car car1 = new Car();
            car1.marka = "Audi";
            car1.rok = 2019;
            Console.WriteLine(car1.marka);
            Console.WriteLine(car1.rok);
 
            Car car2 = new Car();
            car2.marka = "Bmw";
            car2.rok = 2017;
            Console.WriteLine(car2.marka);
            Console.WriteLine(car2.rok);

            car1 = car2;
            Console.WriteLine(car1.marka);//Zamiana car2 na car1
            Console.WriteLine(car1.rok);//Zamiana car2 na car1
            Console.WriteLine("Srednie Spalanie wynosi: ");
            Console.WriteLine(ObliczSpalanie(3,100));
            Console.WriteLine(ObliczKosztPrzejazdu(ObliczSpalanie(3,100), 3.2));


            Osoba dyrektor = new Osoba();
            dyrektor.Imie = "Alina";
            dyrektor.nazwisko = "Kowalska";
            dyrektor.rokUrodzenia = 1965;
            Console.WriteLine(dyrektor.Imie);




        }

        private static double  ObliczSpalanie( double srednieSpalanie, double dlugoscTrasy)
        {
           return  srednieSpalanie * dlugoscTrasy;
        }
        public static double ObliczKosztPrzejazdu(double dlugosctrasy, double cenaPaliwa)
        {
            return dlugosctrasy * cenaPaliwa;
        }
    }
}
class Car
{
    public string marka;
    public int rok;
    private string model;
    private int iloscDrzwi;
    private int pojemnoscSilnika;
    public int srednieSpalanie;



}
