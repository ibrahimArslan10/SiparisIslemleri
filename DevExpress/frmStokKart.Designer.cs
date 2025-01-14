namespace DevExpress
{
    partial class frmStokKart
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
            this.lsbStokKart = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStokKodu = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.nupBirimFiyat = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStokAdi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupBirimFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // lsbStokKart
            // 
            this.lsbStokKart.FormattingEnabled = true;
            this.lsbStokKart.ItemHeight = 20;
            this.lsbStokKart.Location = new System.Drawing.Point(12, 30);
            this.lsbStokKart.Name = "lsbStokKart";
            this.lsbStokKart.Size = new System.Drawing.Size(201, 364);
            this.lsbStokKart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stok Kodu";
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(17, 63);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Size = new System.Drawing.Size(211, 27);
            this.txtStokKodu.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.nupBirimFiyat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStokAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtStokKodu);
            this.groupBox1.Location = new System.Drawing.Point(246, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 324);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stok Kart Bilgileri";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(17, 258);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(211, 46);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Bilgileri Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // nupBirimFiyat
            // 
            this.nupBirimFiyat.Location = new System.Drawing.Point(23, 205);
            this.nupBirimFiyat.Name = "nupBirimFiyat";
            this.nupBirimFiyat.Size = new System.Drawing.Size(205, 27);
            this.nupBirimFiyat.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Birim Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stok Adı";
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.Location = new System.Drawing.Point(17, 123);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.Size = new System.Drawing.Size(211, 27);
            this.txtStokAdi.TabIndex = 4;
            // 
            // frmStokKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 448);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lsbStokKart);
            this.Name = "frmStokKart";
            this.Text = "frmStokKart";
            this.Load += new System.EventHandler(this.frmStokKart_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupBirimFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lsbStokKart;
        private Label label1;
        private TextBox txtStokKodu;
        private GroupBox groupBox1;
        private Button btnKaydet;
        private NumericUpDown nupBirimFiyat;
        private Label label3;
        private Label label2;
        private TextBox txtStokAdi;
    }
}