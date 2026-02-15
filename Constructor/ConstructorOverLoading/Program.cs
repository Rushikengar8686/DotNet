using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstructorOverLoading
{
    class Program
    {
        //Multiple Constructor in same class
        class Product
        {
            public String productName;
            public int productId;
            public int price;

            // Default Constrctor
            public Product()
            {
                productName = "T-shirt";
                productId = 101;
                price = 399;
            }

            // Parameterized Constructor
            public Product(String productName1, int productId, int price1)
            {
                productName = productName1;
                productId = productId;
                price = price1;

            }
        }
        static void Main(string[] args)
        {
            // to call Default Constrctor
            Product ProductInfo = new Product();
            Console.WriteLine("Product Name is => " + ProductInfo.productName);
            Console.WriteLine("Product Price is =>  " + ProductInfo.price);

            // now call Parameterized Constrctor
            Product ProductInfo1 = new Product("Apple",102,7900000);
            Console.WriteLine("Product Name is => " + ProductInfo1.productName);
            Console.WriteLine("Product Price is =>  " + ProductInfo1.price);


            Console.ReadLine();

        }
    }
}
