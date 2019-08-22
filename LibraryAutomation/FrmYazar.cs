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
    public partial class FrmYazar : Form
    {
        LibraryContext db;
        Yazar yazar;
        int id;
        public FrmYazar()
        {
            InitializeComponent();
            db = new LibraryContext();
            id = -1;
            refresh();
        }
        public void refresh()
        {
            dtgvAuthor.DataSource = db.Yazarlar.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            Yazar entity = new Yazar();
            entity.Ad = txtAd.Text;
            if (id==-1)
            {
                txtAd.Text = "";
                db.Yazarlar.Add(entity);
            }
            else
            {
                entity.Id = yazar.Id;
                yazar = db.Yazarlar.Where(c => c.Id == entity.Id).FirstOrDefault();
                yazar.Ad = entity.Ad;
                id = -1;
                txtAd.Text = "";
            }
            db.SaveChanges();
            refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            if (dtgvAuthor.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz kaydın satırını seçiniz","Silme İşlemi");
                return;
            }
            yazar = (Yazar)dtgvAuthor.SelectedRows[0].DataBoundItem;
            db.Yazarlar.Remove(yazar);
            db.SaveChanges();
            refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (dtgvAuthor.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kaydın satırını seçiniz", "Güncelleme İşlemi");
                return;
            }
             yazar = (Yazar)dtgvAuthor.SelectedRows[0].DataBoundItem;
             txtAd.Text = yazar.Ad;
             id = yazar.Id;
        }
    }
}
