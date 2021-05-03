using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Console.WriteLine("Hello World!");
        }
    }

    class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        public Customer()
        {
            Console.WriteLine("constructor calıstı : Customer");
        }
    }
}
