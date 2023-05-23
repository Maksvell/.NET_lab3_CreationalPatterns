using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IClient
    {
        public void SaleBookToKiosk();
        public void SaleMagazineToKiosk();
        public void SaleBookToLibrary();
        public void SaleMagazineToLibrary();
        public void ShowProfit();
    }
}
