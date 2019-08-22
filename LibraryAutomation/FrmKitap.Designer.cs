namespace LibraryAutomation
{
    partial class FrmKitap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtgvBook = new System.Windows.Forms.DataGridView();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtbookName1 = new System.Windows.Forms.TextBox();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtShelf = new System.Windows.Forms.TextBox();
            this.txtBookShelf = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCat = new System.Windows.Forms.Button();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.btnShelf = new System.Windows.Forms.Button();
            this.btnBookShelf = new System.Windows.Forms.Button();
            this.kitapDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kitapBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kitapDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitaplikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapDataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvBook
            // 
            this.dtgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBook.Location = new System.Drawing.Point(41, 135);
            this.dtgvBook.Name = "dtgvBook";
            this.dtgvBook.RowTemplate.Height = 24;
            this.dtgvBook.Size = new System.Drawing.Size(959, 268);
            this.dtgvBook.TabIndex = 0;
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(417, 429);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(185, 53);
            this.btnADD.TabIndex = 1;
            this.btnADD.Text = "Kitap Ekle";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(417, 488);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(185, 53);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Kitap Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(417, 547);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(185, 54);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Kitap Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtbookName1
            // 
            this.txtbookName1.Location = new System.Drawing.Point(67, 76);
            this.txtbookName1.Name = "txtbookName1";
            this.txtbookName1.Size = new System.Drawing.Size(100, 22);
            this.txtbookName1.TabIndex = 4;
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(190, 76);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(100, 22);
            this.txtAuthorName.TabIndex = 5;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(309, 76);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(100, 22);
            this.txtIsbn.TabIndex = 6;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(428, 76);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(100, 22);
            this.txtCategory.TabIndex = 7;
            // 
            // txtShelf
            // 
            this.txtShelf.Location = new System.Drawing.Point(562, 76);
            this.txtShelf.Name = "txtShelf";
            this.txtShelf.Size = new System.Drawing.Size(100, 22);
            this.txtShelf.TabIndex = 8;
            // 
            // txtBookShelf
            // 
            this.txtBookShelf.Location = new System.Drawing.Point(686, 76);
            this.txtBookShelf.Name = "txtBookShelf";
            this.txtBookShelf.Size = new System.Drawing.Size(100, 22);
            this.txtBookShelf.TabIndex = 9;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(831, 67);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(128, 40);
            this.btnFilter.TabIndex = 10;
            this.btnFilter.Text = "Filtrele";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kitap Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Yazar Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "IsbnNo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Kategori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(574, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Raf no";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(699, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kitaplık No";
            // 
            // btnCat
            // 
            this.btnCat.Location = new System.Drawing.Point(73, 527);
            this.btnCat.Name = "btnCat";
            this.btnCat.Size = new System.Drawing.Size(183, 53);
            this.btnCat.TabIndex = 17;
            this.btnCat.Text = "Kategori Ekleme";
            this.btnCat.UseVisualStyleBackColor = true;
            this.btnCat.Click += new System.EventHandler(this.btnCat_Click);
            // 
            // btnAuthor
            // 
            this.btnAuthor.Location = new System.Drawing.Point(73, 442);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(183, 53);
            this.btnAuthor.TabIndex = 18;
            this.btnAuthor.Text = "Yazar Ekleme";
            this.btnAuthor.UseVisualStyleBackColor = true;
            this.btnAuthor.Click += new System.EventHandler(this.btnAuthor_Click);
            // 
            // btnShelf
            // 
            this.btnShelf.Location = new System.Drawing.Point(776, 527);
            this.btnShelf.Name = "btnShelf";
            this.btnShelf.Size = new System.Drawing.Size(183, 53);
            this.btnShelf.TabIndex = 19;
            this.btnShelf.Text = "Raf Ekleme";
            this.btnShelf.UseVisualStyleBackColor = true;
            this.btnShelf.Click += new System.EventHandler(this.btnShelf_Click);
            // 
            // btnBookShelf
            // 
            this.btnBookShelf.Location = new System.Drawing.Point(776, 442);
            this.btnBookShelf.Name = "btnBookShelf";
            this.btnBookShelf.Size = new System.Drawing.Size(183, 53);
            this.btnBookShelf.TabIndex = 20;
            this.btnBookShelf.Text = "Kitaplık Ekleme";
            this.btnBookShelf.UseVisualStyleBackColor = true;
            this.btnBookShelf.Click += new System.EventHandler(this.btnBookShelf_Click);
            // 
            // kitapDataBindingSource1
            // 
            this.kitapDataBindingSource1.DataSource = typeof(DataAccesLayer.KitapData);
            // 
            // kitapBindingSource1
            // 
            this.kitapBindingSource1.DataSource = typeof(DataAccesLayer.Kitap);
            // 
            // kitapDataBindingSource
            // 
            this.kitapDataBindingSource.DataSource = typeof(DataAccesLayer.KitapData);
            // 
            // kitapBindingSource
            // 
            this.kitapBindingSource.DataSource = typeof(DataAccesLayer.Kitap);
            // 
            // kitaplikBindingSource
            // 
            this.kitaplikBindingSource.DataSource = typeof(DataAccesLayer.Kitaplik);
            // 
            // FrmKitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 613);
            this.Controls.Add(this.btnBookShelf);
            this.Controls.Add(this.btnShelf);
            this.Controls.Add(this.btnAuthor);
            this.Controls.Add(this.btnCat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtBookShelf);
            this.Controls.Add(this.txtShelf);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.txtbookName1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.dtgvBook);
            this.Name = "FrmKitap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKitap";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapDataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvBook;
        private System.Windows.Forms.BindingSource kitapBindingSource;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtbookName1;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtShelf;
        private System.Windows.Forms.TextBox txtBookShelf;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource kitapDataBindingSource;
        private System.Windows.Forms.BindingSource kitapBindingSource1;
        private System.Windows.Forms.BindingSource kitaplikBindingSource;
        private System.Windows.Forms.BindingSource kitapDataBindingSource1;
        private System.Windows.Forms.Button btnCat;
        private System.Windows.Forms.Button btnAuthor;
        private System.Windows.Forms.Button btnShelf;
        private System.Windows.Forms.Button btnBookShelf;
    }
}