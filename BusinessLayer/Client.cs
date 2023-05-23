using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class Client : IClient
    {
        private int profit = 0;
        private readonly ISalesFactory kiosk = new KioskSalesFactory();
        private readonly ISalesFactory library = new LibrarySalesFactory();

        public void SaleBookToKiosk()
        {
            IBook book = kiosk.CreateBook();
            book.Sell();
            profit += 10;
        }
        public void SaleMagazineToKiosk()
        {
            IMagazine magazine = kiosk.CreateMagazine();
            magazine.Sell();
            profit += 9;
        }
        public void SaleBookToLibrary()
        {
            IBook book = library.CreateBook();
            book.Sell();
            profit += 6;
        }
        public void SaleMagazineToLibrary()
        {
            IMagazine magazine = library.CreateMagazine();
            magazine.Sell();
            profit += 5;
        }
        public void ShowProfit()
        {
            Console.WriteLine($"Profit: {profit}");
        }
    }
}
