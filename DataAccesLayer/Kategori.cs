using System.Collections.Generic;

namespace DataAccesLayer
{
    public class Kategori
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public List<Kitap> KitapId { get; set; }

    }
}