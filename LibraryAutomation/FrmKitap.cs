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
    public partial class FrmKitap : Form
    {
        BookRepository repBook;
        KitapData data;
        public FrmKitap()
        {
            InitializeComponent();
            repBook = new BookRepository();
            refresh();
        }

        public void refresh()
        {
            dtgvBook.DataSource = repBook.List();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            FrmKitapEdit frm = new FrmKitapEdit();
            frm.ShowDialog();
            refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtgvBook.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Silmek istediğiniz Satırı Seçiniz");
                return;
            }
            KitapData book = (KitapData)dtgvBook.SelectedRows[0].DataBoundItem;
            repBook.Delete(book.Id);
            refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtgvBook.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Düzeltmek istediğiniz Satırı Seçiniz");
                return;
            }
            KitapData book = (KitapData)dtgvBook.SelectedRows[0].DataBoundItem;
            FrmKitapEdit frm = new FrmKitapEdit(book);
            frm.ShowDialog();
            refresh();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dtgvBook.DataSource = null;
            dtgvBook.DataSource = repBook.FilterList(txtbookName1.Text, txtAuthorName.Text, 
                txtCategory.Text, txtIsbn.Text, txtShelf.Text, txtBookShelf.Text);
            ClearText();
        }
        public void ClearText()
        {
            txtbookName1.Text = "";
            txtAuthorName.Text = "";
            txtCategory.Text = "";
            txtIsbn.Text = "";
            txtShelf.Text = "";
            txtBookShelf.Text = "";
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            FrmYazar frm = new FrmYazar();
            frm.ShowDialog();
            refresh();
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            FrmKategorics frm = new FrmKategorics();
            frm.ShowDialog();
            refresh();
        }

        private void btnShelf_Click(object sender, EventArgs e)
        {
            FrmRaf frm = new FrmRaf();
            frm.ShowDialog();
            refresh();
        }

        private void btnBookShelf_Click(object sender, EventArgs e)
        {
            FrmKitaplık frm = new FrmKitaplık();
            frm.ShowDialog();
            refresh();
        }
    }
}
