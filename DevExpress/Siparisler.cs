using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress
{
    public class Siparis
    {
        public string EvrakNo { get; set; }

        public DateTime Tarih { get; set; }

        public int Toplam { get; set; }

        public List<StokKart> StokKartlari { get; set; }


    }
    public class StokKart
    {
        public int Sira { get; set; }
        public string StokAdi { get; set; }

        public int StokKodu { get; set; }

        public decimal BirimFiyat { get; set; }
        public int Miktar { get; set; }

        public decimal AraToplam { get; set; }
    }


}
