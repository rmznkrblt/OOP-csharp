using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product)//101
        {
            Console.WriteLine(product.ProductName + " edded.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " updated.");
        }
    }
}
