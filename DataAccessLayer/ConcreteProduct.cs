using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class KioskBook : IBook
    {
        public void Sell()
        {
            Console.WriteLine("Продаж книги через мережу газетних кіосків");
        }
    }
    
    public class KioskMagazine : IMagazine
    {
        public void Sell()
        {
            Console.WriteLine("Продаж журналу через мережу газетних кіосків");
        }
    }



    public class LibraryBook : IBook
    {
        public void Sell()
        {
            Console.WriteLine("Продаж книги через бібліотеку");
        }
    }

    public class LibraryMagazine : IMagazine
    {
        public void Sell()
        {
            Console.WriteLine("Продаж журналу через бібліотеку");
        }
    }

}
