using DataAccesLayer;
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
    public partial class FrmKategorics : Form
    {
        LibraryContext db;
        int id;
        Kategori kategori;
        public FrmKategorics()
        {
            InitializeComponent();
            db = new LibraryContext();
            id = -1;
            refresh();
        }
        public void refresh()
        {
            dtgvCategory.DataSource = db.Kategoriler.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Kategori entity = new Kategori();
            entity.Ad = txtType.Text;
            if (id == -1)
            {
                txtType.Text = "";
                db.Kategoriler.Add(entity);
            }
            else
            {
                entity.Id = kategori.Id;
                kategori = db.Kategoriler.Where(c => c.Id == entity.Id).FirstOrDefault();
                kategori.Ad = entity.Ad;
                id = -1;
                txtType.Text = "";
            }
            db.SaveChanges();
            refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dtgvCategory.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kaydın satırını seçiniz", "Güncelleme İşlemi");
                return;
            }
            kategori = (Kategori)dtgvCategory.SelectedRows[0].DataBoundItem;
            txtType.Text = kategori.Ad;
            id = kategori.Id;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtType.Text = "";
            if (dtgvCategory.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz kaydın satırını seçiniz", "Silme İşlemi");
                return;
            }
            kategori = (Kategori)dtgvCategory.SelectedRows[0].DataBoundItem;
            db.Kategoriler.Remove(kategori);
            db.SaveChanges();
            refresh();
        }
    }
}
