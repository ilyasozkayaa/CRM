using BLL.Model;
using DAL.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.Urunler
{
    public partial class frmUrunEkle : Form
    {
        public frmUrunEkle()
        {
            InitializeComponent();
        }
        UrunIslemleri Uislem = new UrunIslemleri();
        int ktgID = 0;
        int UrunID = 0;
        private void frmUrunEkle_Load(object sender, EventArgs e)
        {
            cbKategori.DataSource = Uislem.KategoriListesi();
            dgvUrunler.DataSource = Uislem.TumUrunleriGetir();
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Ürün Siliniyor!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Uislem.urunSil(UrunID))
                {
                    MessageBox.Show("Silme İşlemi Başarılı.", "Ürün Silindi.");
                    dgvUrunler.DataSource = Uislem.TumUrunleriGetir();
                }
                else
                {
                    MessageBox.Show("Ürün Silinemedi", "Hata!!!");
                }
            }
        }

        private void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kategori ktg = (Kategori)cbKategori.SelectedItem;
            cbBeden.DataSource = Uislem.KategoriyeGoreBedenGetir(ktg.Id);
            cbKalip.DataSource = Uislem.KategoriyeGoreKalipGetir(ktg.Id);
            cbMalzeme.DataSource = Uislem.KategoriyeGoreMalzemeGetir(ktg.Id);
            ktgID = ktg.Id;
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            Urun u = new Urun();

            int StokMiktari = 0;

            if (int.TryParse(txtStokMiktari.Text, out StokMiktari))
            {
                // MessageBox.Show("Değer int türüne çevrildi.");
            }
            else
            {
                MessageBox.Show("Stok Miktarı İçin Sadece Sayısal Değer Giriniz!!!", "Hatalı Veri Girişi");
            }

            int KritikEsik = 0;

            if (int.TryParse(txtKritikEsik.Text, out KritikEsik))
            {
                //  MessageBox.Show("Değer int türüne çevrildi.");
            }
            else
            {
                MessageBox.Show("Kritik Eşik İçin Sadece Sayısal Değer Giriniz!!!", "Hatalı Veri Girişi");
            }

            decimal AlisFiyati = 0;

            if (decimal.TryParse(txtAlisFiyati.Text, out AlisFiyati))
            {
                //  MessageBox.Show("Değer int türüne çevrildi.");
            }
            else
            {
                MessageBox.Show("Alış Fiyatı İçin Sadece Sayısal Değer Giriniz!!!", "Hatalı Veri Girişi");
            }

            decimal SatisFiyati = 0;

            if (decimal.TryParse(txtSatisFiyati.Text, out SatisFiyati))
            {
                u.UrunAdi = txtUrunAdi.Text;
                u.KategoriId = ktgID;
                u.Kalip = cbKalip.SelectedItem.ToString();
                u.Beden = cbBeden.SelectedItem.ToString();
                u.Malzemesi = cbMalzeme.SelectedItem.ToString();
                u.ÜretimYeri = cbUretimYeri.SelectedItem.ToString();
                u.StokMiktarı = StokMiktari;
                u.KritikEsik = KritikEsik;
                u.AlisFiyat = AlisFiyati;
                u.SatisFiyat = SatisFiyati;
                u.Renk = txtRenk.Text;
                u.Silindi = false;
                if (Uislem.UrunEkleKontrol(txtUrunAdi.Text, txtRenk.Text, cbBeden.SelectedItem.ToString(), cbKalip.SelectedItem.ToString()))
                {
                    MessageBox.Show("Bu ürün Zaten Sistemde Kayıtlı.");
                }
                else
                {
                    if (Uislem.urunEkle(u))
                    {
                        MessageBox.Show("Urun Ekleme İşlemi Tamamlandı.", "İşlem Başarılı");
                        dgvUrunler.DataSource = Uislem.TumUrunleriGetir();
                    }
                    else
                    {
                        MessageBox.Show("Urun Ekleme İşlemi Başarısız Oldu", "Hata!!!");
                    }
                }


            }
            else
            {
                MessageBox.Show("Satış Fiyatı İçin Sadece Sayısal Değer Giriniz!!!", "Hatalı Veri Girişi");
            }
        }

        private void dgvUrunler_DoubleClick(object sender, EventArgs e)
        {
            int ktgID = Convert.ToInt32(dgvUrunler.SelectedRows[0].Cells[1].Value);
            Kategori ktg = Uislem.KategoriGetir(ktgID);
            Urun SeciliUrun = Uislem.urunBul(Convert.ToInt32(dgvUrunler.SelectedRows[0].Cells[0].Value));
            cbKategori.SelectedItem = ktg;
            cbBeden.SelectedItem = SeciliUrun.Beden;
            cbKalip.SelectedItem = SeciliUrun.Kalip;
            cbMalzeme.SelectedItem = SeciliUrun.Malzemesi;
            cbUretimYeri.SelectedItem = SeciliUrun.ÜretimYeri;
            txtUrunAdi.Text = SeciliUrun.UrunAdi;
            txtRenk.Text = SeciliUrun.Renk;
            txtStokMiktari.Text = SeciliUrun.StokMiktarı.ToString(); ;
            txtKritikEsik.Text = SeciliUrun.KritikEsik.ToString();
            txtAlisFiyati.Text = SeciliUrun.AlisFiyat.ToString();
            txtSatisFiyati.Text = SeciliUrun.SatisFiyat.ToString();
            UrunID = SeciliUrun.Id;
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            Urun u = new Urun();

            int StokMiktari = 0;

            if (int.TryParse(txtStokMiktari.Text, out StokMiktari))
            {
                // MessageBox.Show("Değer int türüne çevrildi.");
            }
            else
            {
                MessageBox.Show("Stok Miktarı İçin Sadece Sayısal Değer Giriniz!!!", "Hatalı Veri Girişi");
            }

            int KritikEsik = 0;

            if (int.TryParse(txtKritikEsik.Text, out KritikEsik))
            {
                //  MessageBox.Show("Değer int türüne çevrildi.");
            }
            else
            {
                MessageBox.Show("Kritik Eşik İçin Sadece Sayısal Değer Giriniz!!!", "Hatalı Veri Girişi");
            }

            decimal AlisFiyati = 0;

            if (decimal.TryParse(txtAlisFiyati.Text, out AlisFiyati))
            {
                //  MessageBox.Show("Değer int türüne çevrildi.");
            }
            else
            {
                MessageBox.Show("Alış Fiyatı İçin Sadece Sayısal Değer Giriniz!!!", "Hatalı Veri Girişi");
            }

            decimal SatisFiyati = 0;

            if (decimal.TryParse(txtSatisFiyati.Text, out SatisFiyati))
            {
                if (Uislem.UrunGuncellemeKontrol(UrunID, txtUrunAdi.Text, txtRenk.Text, cbBeden.SelectedItem.ToString(), cbKalip.SelectedItem.ToString()))
                {
                    MessageBox.Show("Bu Ürün Zaten KAyıtlı.", "İşlem Gerçekleşmedi.");
                }
                else
                {
                    u.Id = UrunID;
                    u.UrunAdi = txtUrunAdi.Text;
                    u.KategoriId = ktgID;
                    u.Kalip = cbKalip.SelectedItem.ToString();
                    u.Beden = cbBeden.SelectedItem.ToString();
                    u.Malzemesi = cbMalzeme.SelectedItem.ToString();
                    u.ÜretimYeri = cbUretimYeri.SelectedItem.ToString();
                    u.StokMiktarı = StokMiktari;
                    u.KritikEsik = KritikEsik;
                    u.AlisFiyat = AlisFiyati;
                    u.SatisFiyat = SatisFiyati;
                    u.Renk = txtRenk.Text;
                    u.Silindi = false;
                    if (Uislem.urunGuncelle(u))
                    {
                        MessageBox.Show("Ürün Güncelleme İşlemi Tamamlandı.", "İşlem Başarılı");
                        dgvUrunler.DataSource = Uislem.TumUrunleriGetir();
                    }
                    else
                    {
                        MessageBox.Show("Ürün Ekleme İşlemi Başarısız Oldu", "Hata!!!");
                    }
                }


            }
            else
            {
                MessageBox.Show("Satış Fiyatı İçin Sadece Sayısal Değer Giriniz!!!", "Hatalı Veri Girişi");
            }
        }
    }
}
