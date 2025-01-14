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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;


namespace DevExpress
{
    public partial class frmKayitlar : Form
    {
        public frmKayitlar()
        {
            InitializeComponent();
        }

        private void dgvKayitlar_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DateTime tarih = Convert.ToDateTime(dgvKayitlar.CurrentRow.Cells[1].Value);
                frmSiparis siparis = new frmSiparis();
                siparis.Listele(tarih);
                siparis.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Uygulama Hatası : " + ex.Message.ToString());
            }
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            frmSiparis siparis = new frmSiparis();
            siparis.ShowDialog();
        }

        private void btnStokKart_Click(object sender, EventArgs e)
        {
            frmStokKart stokKart = new frmStokKart();
            stokKart.ShowDialog();
        }

        private void frmKayitlar_Load(object sender, EventArgs e)
        {
            try
            {
                string jsonFile = "Siparis.json";
                string json = File.ReadAllText(jsonFile);
                List<Siparis> siparis = JsonConvert.DeserializeObject<List<Siparis>>(json);
                var list = new BindingList<Siparis>(siparis);
                dgvKayitlar.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Uygulama Hatası : " + ex.Message.ToString());
            }
        }
    }
}
