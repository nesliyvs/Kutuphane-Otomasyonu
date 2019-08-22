
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories
{
    public class ShelfRepository
    {
        LibraryContext db;
        public ShelfRepository()
        {
            db = new LibraryContext();
        }

        public List<Raf> List(int id)
        {

            List<Raf> rafList = db.Raflar.Where(c => c.KitaplikId.Id == id).ToList();

            return rafList;
        }
    }
}
