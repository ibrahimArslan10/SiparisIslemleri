using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

namespace DevExpress
{
    public partial class frmStokKart : Form
    {
        public frmStokKart()
        {
            InitializeComponent();
        }
        List<StokKartlari> stokKartlari;
        private void Listele()
        {
            try
            {
                lsbStokKart.Items.Clear();
                string jsonFile = "StokKart.json";
                string json = File.ReadAllText(jsonFile);
                stokKartlari = JsonConvert.DeserializeObject<List<StokKartlari>>(json);
                for (int i = 0; i < stokKartlari.Count; i++)
                {
                    lsbStokKart.Items.Add(stokKartlari[i].StokAdi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Uygulama Hatası : " + ex.Message.ToString());
            }
        }

 
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
            StokKartlari stokKart = new StokKartlari();
            stokKart.StokKodu = Convert.ToInt32(txtStokKodu.Text);
            stokKart.StokAdi = txtStokAdi.Text;
            stokKart.BirimFiyat = Convert.ToDecimal(nupBirimFiyat.Text);
            stokKartlari.Add(stokKart);
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(@"StokKart.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, stokKartlari);
            }
            Listele();
            MessageBox.Show("Bilgiler Başarıyla Kaydedildi");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Uygulama Hatası : " + ex.Message.ToString());
            }

        }

        private void frmStokKart_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
