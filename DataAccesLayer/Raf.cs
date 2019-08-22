using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class Raf
    {
        public int Id { get; set; }
        public string RafNo { get; set; }
        public List<Kitap> KitapId  { get; set; }
        public Kitaplik KitaplikId { get; set; }


    }
}
