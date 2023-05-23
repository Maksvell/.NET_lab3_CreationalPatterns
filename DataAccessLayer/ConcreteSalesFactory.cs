using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class KioskSalesFactory : ISalesFactory
    {
        public IBook CreateBook()
        {
            return new KioskBook();
        }

        public IMagazine CreateMagazine()
        {
            return new KioskMagazine();
        }
    }

    public class LibrarySalesFactory : ISalesFactory
    {
        public IBook CreateBook()
        {
            return new LibraryBook();
        }
        public IMagazine CreateMagazine()
        {
            return new LibraryMagazine();
        }
    }
}
