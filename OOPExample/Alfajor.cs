using System;
namespace OOPExample
{
    public class Alfajor
    {
        private double price;
        private string name;

        public Alfajor()
        {
            price = 1;
            name = "dulce de leche";
        }

        public void sell() {

            Console.WriteLine("selling: " + name + " for: " + price);
        }
    }
}
