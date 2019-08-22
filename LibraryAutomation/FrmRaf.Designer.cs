namespace LibraryAutomation
{
    partial class FrmRaf
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtgvShelf = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtShelf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBookShelf = new System.Windows.Forms.ComboBox();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rafNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitaplikIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rafDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rafBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitaplikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShelf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rafDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rafBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(581, 276);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(151, 44);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(581, 355);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(151, 44);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dtgvShelf
            // 
            this.dtgvShelf.AutoGenerateColumns = false;
            this.dtgvShelf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvShelf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.rafNoDataGridViewTextBoxColumn,
            this.kitaplikIdDataGridViewTextBoxColumn});
            this.dtgvShelf.DataSource = this.rafDataBindingSource;
            this.dtgvShelf.Location = new System.Drawing.Point(93, 251);
            this.dtgvShelf.Name = "dtgvShelf";
            this.dtgvShelf.RowTemplate.Height = 24;
            this.dtgvShelf.Size = new System.Drawing.Size(434, 187);
            this.dtgvShelf.TabIndex = 15;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(347, 182);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 44);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtShelf
            // 
            this.txtShelf.Location = new System.Drawing.Point(232, 140);
            this.txtShelf.Name = "txtShelf";
            this.txtShelf.Size = new System.Drawing.Size(266, 22);
            this.txtShelf.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(122, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kitaplık No : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(122, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Raf No : ";
            // 
            // cmbBookShelf
            // 
            this.cmbBookShelf.DataSource = this.kitaplikBindingSource;
            this.cmbBookShelf.DisplayMember = "Ad";
            this.cmbBookShelf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookShelf.Location = new System.Drawing.Point(232, 88);
            this.cmbBookShelf.Name = "cmbBookShelf";
            this.cmbBookShelf.Size = new System.Drawing.Size(266, 24);
            this.cmbBookShelf.TabIndex = 19;
            this.cmbBookShelf.ValueMember = "Id";
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            // 
            // rafNoDataGridViewTextBoxColumn
            // 
            this.rafNoDataGridViewTextBoxColumn.DataPropertyName = "RafNo";
            this.rafNoDataGridViewTextBoxColumn.HeaderText = "RafNo";
            this.rafNoDataGridViewTextBoxColumn.Name = "rafNoDataGridViewTextBoxColumn";
            // 
            // kitaplikIdDataGridViewTextBoxColumn
            // 
            this.kitaplikIdDataGridViewTextBoxColumn.DataPropertyName = "KitaplikId";
            this.kitaplikIdDataGridViewTextBoxColumn.HeaderText = "Kitaplık No";
            this.kitaplikIdDataGridViewTextBoxColumn.Name = "kitaplikIdDataGridViewTextBoxColumn";
            this.kitaplikIdDataGridViewTextBoxColumn.Width = 140;
            // 
            // rafDataBindingSource
            // 
            this.rafDataBindingSource.DataSource = typeof(DataAccesLayer.RafData);
            // 
            // rafBindingSource
            // 
            this.rafBindingSource.DataSource = typeof(DataAccesLayer.Raf);
            // 
            // kitaplikBindingSource
            // 
            this.kitaplikBindingSource.DataSource = typeof(DataAccesLayer.Kitaplik);
            // 
            // FrmRaf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 536);
            this.Controls.Add(this.cmbBookShelf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dtgvShelf);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtShelf);
            this.Controls.Add(this.label1);
            this.Name = "FrmRaf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRaf";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShelf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rafDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rafBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dtgvShelf;
        private System.Windows.Forms.BindingSource rafBindingSource;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtShelf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBookShelf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rafNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitaplikIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rafDataBindingSource;
        private System.Windows.Forms.BindingSource kitaplikBindingSource;
    }
}