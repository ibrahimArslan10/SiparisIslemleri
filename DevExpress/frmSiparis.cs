using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DevExpress
{
    public partial class frmSiparis : Form
    {
        public frmSiparis()
        {
            InitializeComponent();
        }

        List<Siparis> siparisler;
        List<StokKartlari> stokKart;
        string jsonFile = "Siparis.json";
        private void btnSatirEkle_Click(object sender, EventArgs e)
        {
            if (dgvSiparisler.Rows.Count == 0)
            {
                dgvSiparisler.ColumnCount = 6;
                dgvSiparisler.Columns[0].Name = "Sıra";
                dgvSiparisler.Columns[1].Name = "Stok Adı";
                dgvSiparisler.Columns[2].Name = "Stok Kodu";
                dgvSiparisler.Columns[3].Name = "BirimFiyat";
                dgvSiparisler.Columns[4].Name = "Miktar";
                dgvSiparisler.Columns[5].Name = "Ara Toplam";
                dgvSiparisler.Rows.Add();
                dgvSiparisler.Rows[0].Cells[0].Value = 1;
            }
            else
            {
                dgvSiparisler.Rows.Insert(dgvSiparisler.Rows.Count, 1);
                dgvSiparisler.Rows[dgvSiparisler.Rows.Count - 1].Cells[0].Value = dgvSiparisler.Rows.Count;
            }

        }

        private void dgvSiparisler_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvSiparisler.CurrentCell.ColumnIndex == 2)
            {
                try
                {
                    int stokKodu = Convert.ToInt32(dgvSiparisler.CurrentRow.Cells[2].EditedFormattedValue);

                    StokKartlari obj = stokKart.Find(x => (x.StokKodu == stokKodu));
                    dgvSiparisler.CurrentRow.Cells[1].Value = obj.StokAdi;
                    dgvSiparisler.CurrentRow.Cells[3].Value = obj.StokKodu;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Uygulama Hatası : " + ex.Message.ToString());
                }
            }
        }

        private void frmSiparis_Load(object sender, EventArgs e)
        {
            dgvSiparisler.AllowUserToAddRows = false;
            string json = File.ReadAllText(jsonFile);
            siparisler = JsonConvert.DeserializeObject<List<Siparis>>(json);
            string jFile = "StokKart.json";
            string js = File.ReadAllText(jFile);
            stokKart = JsonConvert.DeserializeObject<List<StokKartlari>>(js);
        }

        private void ToplamFiyat()
        {
            int toplam = 0;
            for (int i = 0; i < dgvSiparisler.Rows.Count; i++)
            {
                toplam += Convert.ToInt32(dgvSiparisler.Rows[i].Cells[5].Value);
            }
            lbToplamFiyat.Text = toplam.ToString();
        }


        private void dgvSiparisler_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSiparisler.CurrentCell.ColumnIndex == 4)
                {
                    int birimFiyat = Convert.ToInt32(dgvSiparisler.CurrentRow.Cells[3].Value);
                    int miktar = Convert.ToInt32(dgvSiparisler.CurrentRow.Cells[4].EditedFormattedValue);
                    int araToplam = birimFiyat * miktar;
                    dgvSiparisler.CurrentRow.Cells[5].Value = Convert.ToDecimal(araToplam);
                    ToplamFiyat();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Uygulama Hatası : " + ex.Message.ToString());
            }
        }
        bool yeniKayit = true;

        private void btnSiparisKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Siparis siparis = new Siparis();
                siparis.EvrakNo = txtEvrakNo.Text;
                siparis.Tarih = dtpTarih.Value;
                siparis.Toplam = Convert.ToInt32(lbToplamFiyat.Text);
                List<StokKart> stokKartlari = new List<StokKart>();
                for (int i = 0; i < dgvSiparisler.Rows.Count; i++)
                {
                    StokKart stokKart = new StokKart();
                    stokKart.Sira = Convert.ToInt32(dgvSiparisler.Rows[i].Cells[0].Value);
                    stokKart.StokAdi = dgvSiparisler.Rows[i].Cells[1].Value.ToString();
                    stokKart.StokKodu = Convert.ToInt32(dgvSiparisler.Rows[i].Cells[2].Value);
                    stokKart.BirimFiyat = Convert.ToInt32(dgvSiparisler.Rows[i].Cells[3].Value);
                    stokKart.Miktar = Convert.ToInt32(dgvSiparisler.Rows[i].Cells[4].Value);
                    stokKart.AraToplam = Convert.ToInt32(dgvSiparisler.Rows[i].Cells[5].Value);
                    stokKartlari.Add(stokKart);
                }
                siparis.StokKartlari = stokKartlari;

                if (yeniKayit == true)
                    siparisler.Add(siparis);
                else
                {
                    int index = siparisler.FindIndex(x => (x.Tarih.ToShortDateString() == dtpTarih.Value.ToShortDateString()));
                    siparisler[index].StokKartlari = stokKartlari;
                    siparisler[index].Toplam = Convert.ToInt32(lbToplamFiyat.Text);
                }

                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(jsonFile))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, siparisler);
                }
                yeniKayit = true;
                MessageBox.Show("Sipariş Başarıyla Eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Uygulama Hatası : " + ex.Message.ToString());
            }
        }

        public void Listele(DateTime tarih)
        {
            if (siparisler == null)
            {
                string json = File.ReadAllText(jsonFile);
                siparisler = JsonConvert.DeserializeObject<List<Siparis>>(json);
                dtpTarih.Value = tarih;
            }

            Siparis obj = siparisler.Find(x => (x.Tarih.ToShortDateString() == tarih.ToShortDateString()));
            if (obj != null)
            {
                txtEvrakNo.Text = obj.EvrakNo;
                var list = new BindingList<StokKart>(obj.StokKartlari);
                dgvSiparisler.DataSource = list;
                lbToplamFiyat.Text = obj.Toplam.ToString();
                yeniKayit = false;
            }
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            Listele(dtpTarih.Value);
        }

       
      
    }
}
