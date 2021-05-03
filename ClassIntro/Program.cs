using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Kurs 1 adı";
            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Kurs 2 Adı";

            Kurs[] kurslar = new Kurs[]
            {
                kurs1, kurs2
            };




        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
    }
}
