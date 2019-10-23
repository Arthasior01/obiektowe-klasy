using System;

namespace cwiczenia4
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba o1 = new Osoba("Mateusz", "Kowalewski", 1997, "Olsztyn");
            o1.wypisz();
            Student s1 = new Student("Marcin", "Krzemiński", 1997, "Olsztyn", 2, 3, 150990);
            s1.wypiszstudenta();
            Console.WriteLine(s1.obliczWiek());
            //StudentPierwszegoRoku spr1 = new StudentPierwszegoRoku("Michał", "Lasko", 1998, "Olsztyn", 3, 2, 150909);
            //spr1.wypiszstudenta2();
            Student student1 = new Student("Adam", "Kowalski", 1999, "Poznań", 2, 5, 192939);
            Student student2 = new Student("Jan", "Nowak", 1995, "Warszawa", 1, 3, 1232412);
            Osoba osoba1 = new Osoba("Piotr", "Papaj", 2137, "Lwowie");
            Osoba osoba2 = new Osoba("Karol", "Wojtyła", 1920, "Wadowice");
            student1 = osoba1;
            osoba2 = student2;

        }
    }
    class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected int rokUrodzenia;
        protected string miejsceZamieszkania;

        public Osoba(string imie, string nazwisko, int rokUrodzenia, string miejsceZamieszkania)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
            this.miejsceZamieszkania = miejsceZamieszkania;
        }
        public void wypisz()
        {
            Console.WriteLine("{0}  {1}  {2}  {3}", imie, nazwisko, rokUrodzenia, miejsceZamieszkania);
        }
        public int obliczWiek()
        {
            return 2019 - rokUrodzenia;
        }

    }
    class Student : Osoba
    {
        protected int rok;
        protected int numerGrupy;
        protected int numerAlbumu;

        public Student(string imie, string nazwisko, int rokUrodzenia, string miejsceZamieszkania, int rok, int numerGrupy, int numerAlbumu)
            : base(imie, nazwisko, rokUrodzenia, miejsceZamieszkania)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
            this.miejsceZamieszkania = miejsceZamieszkania;
            this.rok = rok;
            this.numerGrupy = numerGrupy;
            this.numerAlbumu = numerAlbumu;
        }
        public void wypiszstudenta()
        {
            Console.WriteLine("{0}  {1}  {2}  {3}  {4}  {5}  {6}", imie, nazwisko, rokUrodzenia, miejsceZamieszkania, rok, numerGrupy, numerAlbumu);
        }

    }
    //class StudentPierwszegoRoku : Student
    //{
    //    public StudentPierwszegoRoku(string imie, string nazwisko, int rokUrodzenia, string miejsceZamieszkania, int rok, int numerGrupy, int numerAlbumu) : base(imie, nazwisko, rokUrodzenia, miejsceZamieszkania, rok, numerGrupy, numerAlbumu)
    //    {
    //        this.imie = imie;
    //        this.nazwisko = nazwisko;
    //        this.rokUrodzenia = rokUrodzenia;
    //        this.miejsceZamieszkania = miejsceZamieszkania;
    //        this.rok = 1;
    //        this.numerGrupy = numerGrupy;
    //        this.numerAlbumu = numerAlbumu;
    //    }
    //    public void wypiszstudenta2()
    //    {
    //        Console.WriteLine("{0}  {1}  {2}  {3}  {4}  {5}  {6}", imie, nazwisko, rokUrodzenia, miejsceZamieszkania, rok, numerGrupy, numerAlbumu);
    //    }
    //}
}
