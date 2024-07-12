using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ProductApp.Models;

namespace ProductApp
{
    internal class Program
    {
        static void PrintDetails(Product p)
        {
            Console.WriteLine($"id: {p.Id} \n" +
                $"name: {p.ProductName} \n" +
                $"price: {p.Price}  \n" +
                $"discount: {p.DiscountPercent} \n"+
                $"new Price: {p.CalculateNewPrice()}");
        }
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Television";
            product1.Id = 100;
            product1.Price = 15000;
            product1.DiscountPercent = 20;

            PrintDetails(product1);

            Console.WriteLine("+++++++++++++++++++++");

            Product product2 = new Product();
            product2.ProductName = "WashingMachine";
            product2.Id = 101;
            product2.Price = 10000;
            product2.DiscountPercent = 10;

            PrintDetails(product2);



            Console.WriteLine("+++++++++++++++++++++");

        }
    }
}
