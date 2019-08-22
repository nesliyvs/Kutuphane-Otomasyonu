using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
   public class Deneme
    
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public Yazar YazarId { get; set; }
        public string IsbnNo { get; set; }
        public Kategori KategoriId { get; set; }
        public Raf RafId { get; set; }


    }
}

