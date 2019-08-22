namespace LibraryAutomation
{
    partial class FrmKitapEdit
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
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIsbnNo = new System.Windows.Forms.TextBox();
            this.cmbYazar = new System.Windows.Forms.ComboBox();
            this.yazarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yazarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitaplikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rafBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.kategoriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnKaydet = new System.Windows.Forms.Button();
            this.rafDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbRaf = new System.Windows.Forms.ComboBox();
            this.rafBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbKitaplık = new System.Windows.Forms.ComboBox();
            this.kitaplikBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kitaplikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.yazarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rafBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rafDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rafBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplikBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplikBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(303, 65);
            this.txtKitapAdi.Multiline = true;
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(315, 35);
            this.txtKitapAdi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(180, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(180, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Isbn No : ";
            // 
            // txtIsbnNo
            // 
            this.txtIsbnNo.Location = new System.Drawing.Point(303, 132);
            this.txtIsbnNo.Multiline = true;
            this.txtIsbnNo.Name = "txtIsbnNo";
            this.txtIsbnNo.Size = new System.Drawing.Size(315, 38);
            this.txtIsbnNo.TabIndex = 4;
            // 
            // cmbYazar
            // 
            this.cmbYazar.BackColor = System.Drawing.SystemColors.Window;
            this.cmbYazar.DataSource = this.yazarBindingSource1;
            this.cmbYazar.DisplayMember = "Ad";
            this.cmbYazar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYazar.FormattingEnabled = true;
            this.cmbYazar.Location = new System.Drawing.Point(303, 201);
            this.cmbYazar.Name = "cmbYazar";
            this.cmbYazar.Size = new System.Drawing.Size(315, 24);
            this.cmbYazar.TabIndex = 6;
            this.cmbYazar.ValueMember = "Id";
            // 
            // yazarBindingSource1
            // 
            this.yazarBindingSource1.DataSource = typeof(DataAccesLayer.Yazar);
            // 
            // yazarBindingSource
            // 
            this.yazarBindingSource.DataSource = typeof(DataAccesLayer.Yazar);
            // 
            // kitaplikBindingSource
            // 
            this.kitaplikBindingSource.DataSource = typeof(DataAccesLayer.Kitaplik);
            // 
            // rafBindingSource
            // 
            this.rafBindingSource.DataSource = typeof(DataAccesLayer.Raf);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(180, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Raf No : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(180, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kitaplık No : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(180, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Yazar Adı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(180, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Kategori : ";
            // 
            // cmbKategori
            // 
            this.cmbKategori.DataSource = this.kategoriBindingSource1;
            this.cmbKategori.DisplayMember = "Ad";
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(303, 256);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(315, 24);
            this.cmbKategori.TabIndex = 14;
            this.cmbKategori.ValueMember = "Id";
            // 
            // kategoriBindingSource1
            // 
            this.kategoriBindingSource1.DataSource = typeof(DataAccesLayer.Kategori);
            // 
            // kategoriBindingSource
            // 
            this.kategoriBindingSource.DataSource = typeof(DataAccesLayer.Kategori);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(502, 436);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(115, 41);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // rafDataBindingSource
            // 
            this.rafDataBindingSource.DataSource = typeof(DataAccesLayer.RafData);
            // 
            // cmbRaf
            // 
            this.cmbRaf.DataSource = this.rafBindingSource1;
            this.cmbRaf.DisplayMember = "RafNo";
            this.cmbRaf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRaf.FormattingEnabled = true;
            this.cmbRaf.Location = new System.Drawing.Point(302, 383);
            this.cmbRaf.Name = "cmbRaf";
            this.cmbRaf.Size = new System.Drawing.Size(315, 24);
            this.cmbRaf.TabIndex = 18;
            this.cmbRaf.ValueMember = "Id";
            // 
            // rafBindingSource1
            // 
            this.rafBindingSource1.DataSource = typeof(DataAccesLayer.Raf);
            // 
            // cmbKitaplık
            // 
            this.cmbKitaplık.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.kitaplikBindingSource, "Ad", true));
            this.cmbKitaplık.DataSource = this.kitaplikBindingSource2;
            this.cmbKitaplık.DisplayMember = "Ad";
            this.cmbKitaplık.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKitaplık.FormattingEnabled = true;
            this.cmbKitaplık.Location = new System.Drawing.Point(302, 318);
            this.cmbKitaplık.Name = "cmbKitaplık";
            this.cmbKitaplık.Size = new System.Drawing.Size(316, 24);
            this.cmbKitaplık.TabIndex = 19;
            this.cmbKitaplık.ValueMember = "Id";
            this.cmbKitaplık.SelectionChangeCommitted += new System.EventHandler(this.cmbKitaplık_SelectionChangeCommitted);
            // 
            // kitaplikBindingSource2
            // 
            this.kitaplikBindingSource2.DataSource = typeof(DataAccesLayer.Kitaplik);
            // 
            // kitaplikBindingSource1
            // 
            this.kitaplikBindingSource1.DataSource = typeof(DataAccesLayer.Kitaplik);
            // 
            // FrmKitapEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 536);
            this.Controls.Add(this.cmbKitaplık);
            this.Controls.Add(this.cmbRaf);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbYazar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIsbnNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKitapAdi);
            this.Name = "FrmKitapEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKitapEdit";
            ((System.ComponentModel.ISupportInitialize)(this.yazarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rafBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rafDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rafBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplikBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplikBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIsbnNo;
        private System.Windows.Forms.ComboBox cmbYazar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.BindingSource yazarBindingSource;
        private System.Windows.Forms.BindingSource kitaplikBindingSource;
        private System.Windows.Forms.BindingSource rafBindingSource;
        private System.Windows.Forms.BindingSource kategoriBindingSource;
        private System.Windows.Forms.BindingSource rafDataBindingSource;
        private System.Windows.Forms.ComboBox cmbRaf;
        private System.Windows.Forms.ComboBox cmbKitaplık;
        private System.Windows.Forms.BindingSource kitaplikBindingSource1;
        private System.Windows.Forms.BindingSource yazarBindingSource1;
        private System.Windows.Forms.BindingSource kategoriBindingSource1;
        private System.Windows.Forms.BindingSource rafBindingSource1;
        private System.Windows.Forms.BindingSource kitaplikBindingSource2;
    }
}