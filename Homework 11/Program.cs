using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

namespace Homework_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Studentclass student = new Studentclass("Aytac Abbasova", 76);
            //Console.WriteLine("Birthdate daxil edin: ");
            //student.BirthDate= DateTime.Parse(Console.ReadLine());
            //Console.WriteLine("GroupNo daxil edin: ");
            //student.GroupNo = Console.ReadLine();


            //student.ShowInfo();

            Console.WriteLine("Product sayini daxil edin: ");
            string productnumStr=Console.ReadLine();
            int productnum=Convert.ToInt32(productnumStr);

            Productclass[] products = new Productclass[productnum];


            for (int i=0; i<productnumStr.Length; i++)
            {
                Console.WriteLine("Mehsulun adini daxil edin: ");
                string newnameStr=Console.ReadLine();
                int newname=Convert.ToInt32(newnameStr);

                Console.WriteLine("Mehsulun qiymetin daxil edin: ");
                string newpriceStr = Console.ReadLine();
                int newprice=Convert.ToInt32(newpriceStr);
                break;
            }

            Productclass product = new Productclass("Milka");

            Console.WriteLine($"Product name: {product.Name} - Price: {product.Price}");

        }
    }
}
