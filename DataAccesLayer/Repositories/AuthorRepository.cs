using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories
{
    
   public  class AuthorRepository
    {
        LibraryContext db;
        public AuthorRepository()
        {
            db = new LibraryContext();
            
        }

        public List<Yazar> List()
        {
            List<Yazar> yazarList = db.Yazarlar.ToList();
            return yazarList;
        }
    }
}
