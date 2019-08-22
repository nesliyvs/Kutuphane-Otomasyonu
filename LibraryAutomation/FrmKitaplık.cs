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
    public partial class FrmKitaplık : Form
    {
        LibraryContext db;
        Kitaplik kitaplik;
        int id;
        public FrmKitaplık()
        {
            id = -1;
            InitializeComponent();
            db = new LibraryContext();
            refresh();
        }

        public void refresh()
        {
            dtgvBookShelf.DataSource = db.Kitapliklar.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Kitaplik entity = new Kitaplik();
            entity.Ad = txtBookNo.Text;
            if (id == -1)
            {
                db.Kitapliklar.Add(entity);
            }
            else
            {
                entity.Id = kitaplik.Id;
                kitaplik = db.Kitapliklar.Where(c => c.Id == entity.Id).FirstOrDefault();
                kitaplik.Ad = entity.Ad;
                id = -1;
                txtBookNo.Text = "";
            }
            db.SaveChanges();
            refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if (dtgvBookShelf.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kaydın satırını seçiniz", "Güncelleme İşlemi");
                return;
            }
            kitaplik = (Kitaplik)dtgvBookShelf.SelectedRows[0].DataBoundItem;
            txtBookNo.Text = kitaplik.Ad;
            id = kitaplik.Id;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtBookNo.Text = "";
            if (dtgvBookShelf.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz kaydın satırını seçiniz", "Silme İşlemi");
                return;
            }
            kitaplik = (Kitaplik)dtgvBookShelf.SelectedRows[0].DataBoundItem;
            db.Kitapliklar.Remove(kitaplik);
            db.SaveChanges();
            refresh();
        }
    }
}
