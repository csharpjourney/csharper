using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriAdi = "Test";
            string[] kategoriler = new string[] { "elektronik", "mutfak", "market" };
            Console.WriteLine("Hello World! : " + kategoriAdi);

            for (int i = 0; i < kategoriler.Length; i++)
            {
                Console.WriteLine("kategori " + i + " : " + kategoriler[i]);
            }

            int sayi1 = 13;

            Console.WriteLine("Sayi 1  : "+sayi1);

            bool isLoggedIn = true;

            if(isLoggedIn == true)
            {
                Console.WriteLine("Logged in");
            } else
            {
                Console.WriteLine("Logged out");
            }

            bool durumu = false;

            string sonuc = durumu ? "Onaylanmış" : "Beklemede";
            Console.WriteLine("Sonuc: "+sonuc);

            // string sonuc = <mantıksal kontrol> ? <true ise dönen değer> : <false ise dönen değer>;

            string sonuc2 = durumu == true ? "Onaylanmış" : "Beklemede";

            foreach (string kategori in kategoriler)
            {
                Console.WriteLine("kateori : "+kategori);
            }
        }
    }
}
