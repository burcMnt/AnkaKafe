using AnkaKafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnkaKafe.UI
{
    public partial class AnaForm : Form
    {

        KafeVeri db = new KafeVeri();
        public AnaForm()
        {
            // OrnekUrunleriEkle(); ilerde kaldırılacak 
            VerileriOku();
            InitializeComponent();
            masalarImageList.Images.Add("bos", Resource.dinner_table);
            masalarImageList.Images.Add("dolu", Resource.third_party);
              Icon = Resource.icon;
            MasalarıOlustur();
           
        }

        private void VerileriOku()
        {
            //veri oku ve deserilizeet
            try
            {
                string json = File.ReadAllText("veri.json");
                db = JsonSerializer.Deserialize<KafeVeri>(json);

            }
            //eger hata alırsan dosya yok yada bozuk
            catch (Exception)
            {

                db = new KafeVeri();
                OrnekUrunleriEkle();
            }
        }

        private void OrnekUrunleriEkle()
        {
            db.Urunler.Add(new Urun() { UrunAd = "Çay", BirimFiyat = 4.00m });
            db.Urunler.Add(new Urun() { UrunAd = "Simit", BirimFiyat = 5.00m });
        }

        private void MasalarıOlustur()
        {
            ListViewItem lvi;
            for (int i = 1; i <= db.MasaAdedi; i++)
            {
                lvi = new ListViewItem();
                lvi.Tag = i;//masa noyu herbir ügenin Tag property'sinde saklayalım
                lvi.Text = "Masa" + i;
                lvi.ImageKey = MasaDolumu(i) ? "dolu":"bos";
                lvwMasalar.Items.Add(lvi);
            }
        }
        private bool MasaDolumu(int masaNo)
        {
            return db.AktifSiparisler.Any(x => x.MasaNo == masaNo);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == tsmiUrunler)
            {
                new UrunlerForm(db).ShowDialog();
            }
            else if (e.ClickedItem == tsmiGecmisSiparisler)
            {
                new GecmisSiparisForm(db).ShowDialog();
            }
        }

        private void lvwMasalar_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem lvi = lvwMasalar.SelectedItems[0];
            int masaNo = (int)lvi.Tag; //unboxing
            lvi.ImageKey = "dolu";

            //todo: eger bu masada önceden bir sipariş yoksa oluştur
            Siparis siparis = SiparisBul(masaNo);

            if (siparis == null)
            {
                siparis = new Siparis() { MasaNo = masaNo };
                db.AktifSiparisler.Add(siparis);
            }
            //todo: bu siparişi başka bir formda aç

            SiparisForm siparisForm = new SiparisForm(db, siparis);
            // siparisForm.Show();   //ShowDialog yazmamamızın sebebi başka masa seçilmez

            siparisForm.MasaTasindi += SiparisForm_MasaTasindi;
            siparisForm.ShowDialog();

            //siparis form kapandıktan sonra sipariş durum kontrol et

            if (siparis.Durum != SiparisDurum.Aktif)
            {
                lvi.ImageKey = "bos";
            }
        }

        private void SiparisForm_MasaTasindi(object sender, MasaTasindiEventArgs e)
        {
            foreach (ListViewItem lvi in lvwMasalar.Items)
            {
                int masaNo = (int)lvi.Tag;
                if (masaNo==e.EskiMasaNo)
                {
                    lvi.ImageKey = "bos";
                }
                else if (masaNo==e.YeniMasaNo)
                {
                    lvi.ImageKey = "dolu";
                }
            }
        }

        private Siparis SiparisBul(int masaNo)
        {
            //return db.AktifSiparisler.FirstOrDefault(s => s.MasaNo == masaNo);

            foreach (Siparis item in db.AktifSiparisler)
            {
                if (item.MasaNo == masaNo)
                {
                    return item;
                }
            }


            return null;
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            VerileriKaydet();
        }

        // https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-how-to?pivots=dotnet-5-0

        private void VerileriKaydet()
        {
            var options = new JsonSerializerOptions() { WriteIndented = true }; //json okunaklı (indendation) kaydeder
            string json = JsonSerializer.Serialize(db);
            File.WriteAllText("veri.json", json);
        }
    }
}
