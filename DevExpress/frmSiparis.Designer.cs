namespace DevExpress
{
    partial class frmSiparis
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
            this.txtEvrakNo = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.dgvSiparisler = new System.Windows.Forms.DataGridView();
            this.btnSatirEkle = new System.Windows.Forms.Button();
            this.btnSiparisKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbToplamFiyat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEvrakNo
            // 
            this.txtEvrakNo.Location = new System.Drawing.Point(35, 12);
            this.txtEvrakNo.Name = "txtEvrakNo";
            this.txtEvrakNo.Size = new System.Drawing.Size(235, 27);
            this.txtEvrakNo.TabIndex = 0;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(36, 56);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(234, 27);
            this.dtpTarih.TabIndex = 1;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // dgvSiparisler
            // 
            this.dgvSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisler.Location = new System.Drawing.Point(36, 113);
            this.dgvSiparisler.Name = "dgvSiparisler";
            this.dgvSiparisler.RowHeadersWidth = 51;
            this.dgvSiparisler.RowTemplate.Height = 29;
            this.dgvSiparisler.Size = new System.Drawing.Size(816, 254);
            this.dgvSiparisler.TabIndex = 2;
            this.dgvSiparisler.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSiparisler_CellLeave);
            this.dgvSiparisler.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSiparisler_CellMouseDoubleClick);
            // 
            // btnSatirEkle
            // 
            this.btnSatirEkle.Location = new System.Drawing.Point(683, 47);
            this.btnSatirEkle.Name = "btnSatirEkle";
            this.btnSatirEkle.Size = new System.Drawing.Size(169, 29);
            this.btnSatirEkle.TabIndex = 3;
            this.btnSatirEkle.Text = "Yeni Satır Ekle";
            this.btnSatirEkle.UseVisualStyleBackColor = true;
            this.btnSatirEkle.Click += new System.EventHandler(this.btnSatirEkle_Click);
            // 
            // btnSiparisKaydet
            // 
            this.btnSiparisKaydet.Location = new System.Drawing.Point(6, 15);
            this.btnSiparisKaydet.Name = "btnSiparisKaydet";
            this.btnSiparisKaydet.Size = new System.Drawing.Size(471, 61);
            this.btnSiparisKaydet.TabIndex = 4;
            this.btnSiparisKaydet.Text = "Sipariş Bilgilerini Kaydet";
            this.btnSiparisKaydet.UseVisualStyleBackColor = true;
            this.btnSiparisKaydet.Click += new System.EventHandler(this.btnSiparisKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sipariş Toplam Bilgileri";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbToplamFiyat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(35, 408);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 82);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // lbToplamFiyat
            // 
            this.lbToplamFiyat.AutoSize = true;
            this.lbToplamFiyat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbToplamFiyat.ForeColor = System.Drawing.Color.Red;
            this.lbToplamFiyat.Location = new System.Drawing.Point(118, 26);
            this.lbToplamFiyat.Name = "lbToplamFiyat";
            this.lbToplamFiyat.Size = new System.Drawing.Size(53, 28);
            this.lbToplamFiyat.TabIndex = 1;
            this.lbToplamFiyat.Text = "0,00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Toplam Fiyat:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSiparisKaydet);
            this.groupBox2.Location = new System.Drawing.Point(368, 408);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 82);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // frmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 507);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSatirEkle);
            this.Controls.Add(this.dgvSiparisler);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.txtEvrakNo);
            this.Name = "frmSiparis";
            this.Text = "frmSiparis";
            this.Load += new System.EventHandler(this.frmSiparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtEvrakNo;
        private DateTimePicker dtpTarih;
        private DataGridView dgvSiparisler;
        private Button btnSatirEkle;
        private Button btnSiparisKaydet;
        private Label label1;
        private GroupBox groupBox1;
        private Label lbToplamFiyat;
        private Label label2;
        private GroupBox groupBox2;
    }
}