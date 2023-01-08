using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book();
            book2.booktitle1("Fouyou","Jon_Newkrater");
            Book book3 = new Book();
            book3.booktitle2("Goodnight", "JAME", 2560);
            book1.display();
            book2.display();
            book3.display();
            Console.ReadKey();
        }
    }
}
