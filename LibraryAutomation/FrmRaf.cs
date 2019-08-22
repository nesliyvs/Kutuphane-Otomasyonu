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
    public partial class FrmRaf : Form
    {
        LibraryContext db;
        RafData rafData;
        Raf raf;
        int id;
        public FrmRaf()
        {
            id = -1;
            InitializeComponent();
            db = new LibraryContext();
            cmbBookShelf.DataSource = db.Kitapliklar.ToList();
            refresh();
        }

        public void refresh()
        {
            List<RafData> rafList = (from d in db.Raflar.Include("Kitaplik")
                                     select new RafData {Id=d.Id,
                                                         KitaplikId=d.KitaplikId.Ad,
                                                         RafNo=d.RafNo }).ToList();
            dtgvShelf.DataSource = rafList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            Raf entity = new Raf();
            entity.RafNo = txtShelf.Text;
            entity.KitaplikId =(Kitaplik)cmbBookShelf.SelectedItem;

            if (id == -1)
            {
                txtShelf.Text = "";
                db.Raflar.Add(entity);
            }
            else
            {
                entity.Id = rafData.Id;
                raf = db.Raflar.Where(c => c.Id == entity.Id).FirstOrDefault();
                raf.RafNo = entity.RafNo;
                raf.KitaplikId = entity.KitaplikId;
                txtShelf.Text = "";
                id = -1;
            }
            db.SaveChanges();
            refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtgvShelf.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kaydın satırını seçiniz", "Güncelleme İşlemi");
                return;
            }
            rafData = (RafData)dtgvShelf.SelectedRows[0].DataBoundItem;
            id = rafData.Id;
            txtShelf.Text = rafData.RafNo;
            cmbBookShelf.Text = rafData.KitaplikId;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtShelf.Text = "";
            if (dtgvShelf.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz kaydın satırını seçiniz", "Silme İşlemi");
                return;
            }
            rafData= (RafData)dtgvShelf.SelectedRows[0].DataBoundItem;
            raf = db.Raflar.Where(c => c.Id == rafData.Id).FirstOrDefault();
            db.Raflar.Remove(raf);
            db.SaveChanges();
            refresh();
        }

        
    }
}
