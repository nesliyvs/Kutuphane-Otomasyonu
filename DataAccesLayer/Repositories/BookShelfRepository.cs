using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories
{
   public class BookShelfRepository
    {
        LibraryContext db;
        public BookShelfRepository()
        {
            db = new LibraryContext();
            
        }

        public List<Kitaplik> List()
        {
            List<Kitaplik> kitaplikList = db.Kitapliklar.ToList();
            
            return kitaplikList;
        }
    }
}
