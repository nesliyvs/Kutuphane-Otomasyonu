using DataAccesLayer;
using DataAccesLayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAutomation
{
    public partial class FrmKitapEdit : Form
    {
        int id;
        LibraryContext db;
        int value ;

        public FrmKitapEdit()

        {
            id = -1;
            InitializeComponent();
            db = new LibraryContext();
            cmbKategori.DataSource = db.Kategoriler.ToList();
            cmbKitaplık.DataSource = db.Kitapliklar.ToList();
            cmbYazar.DataSource = db.Yazarlar.ToList();
            cmbRaf.Enabled = false;
           
        }

        public FrmKitapEdit(KitapData book)
        {
            InitializeComponent();
            db = new LibraryContext();
            cmbKategori.DataSource = db.Kategoriler.ToList();
            cmbKategori.ValueMember = "Id";
            cmbKategori.DisplayMember = "Ad";
            cmbKitaplık.DataSource = db.Kitapliklar.ToList();
            cmbYazar.DataSource = db.Yazarlar.ToList();
            cmbRaf.DataSource = db.Raflar.ToList();
            cmbRaf.Enabled = false;
            txtIsbnNo.Text = book.IsbnNo;
            txtKitapAdi.Text = book.Ad;
            cmbKategori.Text = book.KategoriName;
            cmbYazar.Text = book.YazarName;
            cmbRaf.Text = book.RafName;
            cmbKitaplık.Text = book.KitaplikName;
            id = book.Id;            
        }
     

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kitap entity = new Kitap();
            entity.Ad = txtKitapAdi.Text;
            entity.IsbnNo = txtIsbnNo.Text;
            entity.KategoriId=(Kategori)cmbKategori.SelectedItem;
            entity.RafId = (Raf)cmbRaf.SelectedItem;
            entity.YazarId = (Yazar)cmbYazar.SelectedItem;
            entity.KitaplikId = (Kitaplik)cmbKitaplık.SelectedItem;
            if (id == -1)
            {
                db.Kitaplar.Add(entity);
                db.SaveChanges();
                
            }

            else

            {
                entity.Id = id;
                Kitap book = db.Kitaplar.Where(c => c.Id == entity.Id).FirstOrDefault();
                book.IsbnNo = entity.IsbnNo;
                book.KategoriId = entity.KategoriId;
                book.Ad = entity.Ad;
                book.RafId = entity.RafId;
                book.YazarId = entity.YazarId;
                book.KitaplikId = entity.KitaplikId;
                db.SaveChanges();
            }

            Close();

        }

        private void cmbKitaplık_SelectionChangeCommitted(object sender, EventArgs e)
        {
            value = Convert.ToInt32(cmbKitaplık.SelectedValue);
            var raflist = db.Raflar.Where(c => c.KitaplikId.Id == value).ToList();
            cmbRaf.DataSource = raflist;
            if (raflist.Count == 0)
            {
                cmbRaf.Enabled = false;
                cmbRaf.Text = "";
            }
            else
            {
                cmbRaf.Enabled = true;
            }
        }
    }
}
