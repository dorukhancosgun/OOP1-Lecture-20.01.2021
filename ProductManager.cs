using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product) // icine string ad yazmisim gibi dusun.
        {
            Console.WriteLine(product.ProductName + " eklendi.");

        }

        public void Update(Product product) // public void pythondaki metotlardir
        {
            Console.WriteLine(product.ProductName + " guncellendi.");
        }
        
        public int Topla(int sayi1 + int sayi2) 
        {
            return sayi1 + sayi2;
        }
        public void Topla2(int sayi1 + int sayi2) // void fonksiyon dondurmez
        {
            Console.WriteLine(sayi1 + sayi2); 
        }

    }

}
