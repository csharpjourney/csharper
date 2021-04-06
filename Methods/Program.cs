using System;
using System.Collections.Generic;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> _products = new List<Product> {
                new Product(1, "klavye"),
                new Product(2, "mouse")
            };
            Console.WriteLine("Hello World!");
            foreach (var p in _products)
            {
                Console.WriteLine(p._ProductName);

            }
            SayHello("Mustafa");
            int toplam = Toplama(5, 9);
            Console.WriteLine("Toplam : "+ toplam);
            int number1 = 20;
            int number2 = 100;
            int result = Add3(number1, number2);
            Console.WriteLine("Result 2 : "+ result);
            Console.WriteLine("Number1 : "+number1);
            Add(1,2,3);

        }

        static int Add3(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static void Add(params int[] numbers)
        {
            Console.WriteLine("Sum : " + numbers.Sum());
        }

        static void SayHello(string name)
        {
            Console.WriteLine("Hello "+name);
        }

        static int Toplama(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
    }

    class Product
    {
        public int _ProductId { get; set; }
        public string _ProductName { get; set; }

        public Product(int ProductId, string ProductName)
        {
            _ProductId = ProductId;
            _ProductName = ProductName;
        }
    }
}
