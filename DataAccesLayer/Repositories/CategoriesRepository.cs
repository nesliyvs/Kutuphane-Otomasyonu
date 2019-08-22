using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories
{
   public class CategoriesRepository
    {
        LibraryContext db=new LibraryContext();
       

        public List<Kategori> List()
        {
            List<Kategori> kategoriList = db.Kategoriler.ToList();
            return kategoriList;
        }
    }
}
