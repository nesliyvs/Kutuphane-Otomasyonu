using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories
{
    public class BookRepository
    {
        LibraryContext db;
        public BookRepository()
        {
            db = new LibraryContext();
        }

        public List<KitapData> List()
        {
            List<KitapData> bookData = (from d in db.Kitaplar.Include("Yazar").Include("Raf").Include("Kategori").Include("Kitaplik")
                                select new KitapData
                                  { Ad = d.Ad,
                                    YazarName = d.YazarId.Ad,
                                    KategoriName = d.KategoriId.Ad,
                                    IsbnNo = d.IsbnNo,
                                    RafName = d.RafId.RafNo,
                                    Id = d.Id,
                                    KitaplikName=d.KitaplikId.Ad}).ToList();
                                
            return bookData;
        }

        //public void Add(Kitap entity)
        //{
        //  Kitap book = db.Kitaplar.Add(entity);
        //    db.SaveChanges();
        //}
      
        public void Delete(int id)
        {
            Kitap book = db.Kitaplar.Where(c => c.Id == id).FirstOrDefault();
            db.Kitaplar.Remove(book);
            db.SaveChanges();
        }
        //public void Update(Kitap entity)
        //{
        //    Kitap book = db.Kitaplar.Where(c => c.Id == entity.Id).FirstOrDefault();
        //    book.IsbnNo = entity.IsbnNo;
        //    book.KategoriId = entity.KategoriId;
        //    book.Ad = entity.Ad;
        //    book.RafId = entity.RafId;
        //    book.YazarId = entity.YazarId;
        //    db.SaveChanges();
        //}

        public List<KitapData> FilterList(string name,string yazarName,string catName,string IsbnNo,string rafName,string kitaplikName)
        {
            List<KitapData> bookData = (from c in db.Kitaplar where c.Ad.Contains(name) &&
                                    c.KategoriId.Ad.Contains(catName) &&
                                    c.KitaplikId.Ad.Contains(kitaplikName) &&
                                    c.RafId.RafNo.Contains(rafName) &&
                                    c.YazarId.Ad.Contains(yazarName) &&
                                    c.IsbnNo.Contains(IsbnNo)
                                    select  new KitapData{
                                    Ad = c.Ad,
                                    YazarName = c.YazarId.Ad,   
                                    KategoriName = c.KategoriId.Ad,
                                    IsbnNo = c.IsbnNo,
                                    RafName = c.RafId.RafNo,
                                    Id = c.Id,
                                    KitaplikName = c.KitaplikId.Ad}).ToList();

            return bookData;
        }
    }
}
