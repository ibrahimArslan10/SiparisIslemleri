namespace DevExpress
{
    partial class frmKayitlar
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
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.btnStokKart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKayitlar = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKayitlar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSiparisEkle.Location = new System.Drawing.Point(6, 16);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(150, 33);
            this.btnSiparisEkle.TabIndex = 0;
            this.btnSiparisEkle.Text = "Yeni Sipariş Ekle";
            this.btnSiparisEkle.UseVisualStyleBackColor = false;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // btnStokKart
            // 
            this.btnStokKart.BackColor = System.Drawing.Color.Yellow;
            this.btnStokKart.Location = new System.Drawing.Point(270, 16);
            this.btnStokKart.Name = "btnStokKart";
            this.btnStokKart.Size = new System.Drawing.Size(150, 33);
            this.btnStokKart.TabIndex = 1;
            this.btnStokKart.Text = "Stok Kart Liste";
            this.btnStokKart.UseVisualStyleBackColor = false;
            this.btnStokKart.Click += new System.EventHandler(this.btnStokKart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSiparisEkle);
            this.groupBox1.Controls.Add(this.btnStokKart);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 56);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // dgvKayitlar
            // 
            this.dgvKayitlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKayitlar.Location = new System.Drawing.Point(15, 95);
            this.dgvKayitlar.Name = "dgvKayitlar";
            this.dgvKayitlar.RowHeadersWidth = 51;
            this.dgvKayitlar.RowTemplate.Height = 29;
            this.dgvKayitlar.Size = new System.Drawing.Size(420, 381);
            this.dgvKayitlar.TabIndex = 3;
            this.dgvKayitlar.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvKayitlar_CellMouseDoubleClick);
            // 
            // frmKayitlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 488);
            this.Controls.Add(this.dgvKayitlar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKayitlar";
            this.Text = "Sipariş Kayıtları";
            this.Load += new System.EventHandler(this.frmKayitlar_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKayitlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSiparisEkle;
        private Button btnStokKart;
        private GroupBox groupBox1;
        private DataGridView dgvKayitlar;
    }
}