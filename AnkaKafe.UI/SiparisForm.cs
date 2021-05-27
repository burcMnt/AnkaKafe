using AnkaKafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnkaKafe.UI
{
    public partial class SiparisForm : Form
    {
        private readonly KafeVeri _db;
        private readonly Siparis _siparis;
        private readonly BindingList<SiparisDetay> _blSiparisDetaylar;
        public SiparisForm(KafeVeri kafeveri, Siparis siparis)
        {
            _db = kafeveri;
            _siparis = siparis;
            _blSiparisDetaylar = new BindingList<SiparisDetay>(siparis.SiparisDetaylar);
            InitializeComponent();
            dgvSiparisDetay.AutoGenerateColumns = false; //otomatik sütun oluşturmayı kapat
            MasaNoGuncelle();
            FiyatGuncelle();
            UrunleriGoster();
            EkleFormSifirla();
            DetaylariListele();
            _blSiparisDetaylar.ListChanged += _blSiparisDetaylar_ListChanged;
        }

        private void _blSiparisDetaylar_ListChanged(object sender, ListChangedEventArgs e)
        {
            FiyatGuncelle();
        }

        private void UrunleriGoster()
        {
            cboUrun.DataSource = _db.Urunler;
        }

        private void FiyatGuncelle()
        {
            lblOdemeTutar.Text = _siparis.ToplamTutarTl;
        }

        private void MasaNoGuncelle()
        {
            Text = $"Masa {_siparis.MasaNo} Sipariş Bilgileri";
            lblMasaNo.Text = _siparis.MasaNo.ToString("00");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cboUrun.SelectedIndex == -1 || nudAdet.Value < 1) return;

            Urun urun = (Urun)cboUrun.SelectedItem;
            SiparisDetay siparisDetay = new SiparisDetay()
            {
                UrunAd = urun.UrunAd,
                BirimFiyat = urun.BirimFiyat,
                Adet = (int)nudAdet.Value
            };

            _blSiparisDetaylar.Add(siparisDetay);
            EkleFormSifirla();

        }

        private void EkleFormSifirla()
        {
            cboUrun.SelectedIndex = -1;
            nudAdet.Value = 1;
        }

        private void DetaylariListele()
        {
            // dgvSiparisDetay.DataSource = null;
            dgvSiparisDetay.DataSource = _blSiparisDetaylar;
        }



        private void dgvSiparisDetay_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Seçili sipariş detayları silinecektir.Emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            e.Cancel = dr == DialogResult.No;
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            SiparisKapat(SiparisDurum.Iptal, 0);
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            SiparisKapat(SiparisDurum.Odendi, _siparis.ToplamTutar());
        }

        private void SiparisKapat(SiparisDurum siparisDurum, decimal odenenTutar)
        {
            _siparis.OdenenTutar = odenenTutar;
            _siparis.Durum = siparisDurum;
            _siparis.KapanisZamani = DateTime.Now;
            _db.AktifSiparisler.Remove(_siparis);
            _db.GecmisSiparisler.Add(_siparis);
            Close();
        }
    }
}
