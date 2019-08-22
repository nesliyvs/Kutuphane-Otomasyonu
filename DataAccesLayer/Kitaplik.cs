using System.Collections.Generic;

namespace DataAccesLayer
{
    public class Kitaplik
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public List<Raf> RafId { get; set; }
    }
}