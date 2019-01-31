using BLL.Model;
using DAL.Context;
using PL.KasaIslemleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class frmUyeMusteri : Form
    {
        public frmUyeMusteri()
        {
            InitializeComponent();
        }
        PersonelMusteriIslemleri pmi = new PersonelMusteriIslemleri();
        PromosyonPrimIslemleri ppi = new PromosyonPrimIslemleri();
        UrunIslemleri Uislem = new UrunIslemleri();
        Musteri IslemYapılanMusteri = new Musteri();
        Genel gnl = new Genel();
        int personelID = 2;
        Urun u = new Urun();
        decimal Toplam = 0;
        decimal GenelToplam = 0;
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void frmUyeMusteri_Load(object sender, EventArgs e)
        {

            IslemYapılanMusteri = pmi.musteriGetir(frmSatisIslemleri.MusteriID);
            int personelID = 15;  //Veri Çekilecek
            try
            {
                lblAD.Text = IslemYapılanMusteri.Ad;
                lblSoyad.Text = IslemYapılanMusteri.Soyad;  //uye olmayan musteri eklenecek
                lblMusteriNo.Text = IslemYapılanMusteri.Id.ToString();
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }

            dgvSatis.ColumnCount = 35;
            dgvSatis.Columns[0].Name = "Ürün Adı";
            dgvSatis.Columns[1].Name = "Adet";
            dgvSatis.Columns[2].Name = "Tutar";
            dgvSatis.Columns[3].Name = "UrunID";
            dgvSatis.Columns[4].Name = "UrunSatisFiyat";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Adet = 0;
            try
            {
                u = Uislem.urunBul(Convert.ToInt32(textBox1.Text));
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }

            if (int.TryParse(txtAdet.Text, out Adet))
            {
                if (u == null)
                {
                    MessageBox.Show("Urun ID'yi kontrol ediniz.", "Bu ID'ye Ait Ürün Bulunmamaktadır!!!");
                }
                else
                {
                    dgvSatis.Rows.Add(u.UrunAdi, txtAdet.Text, (Adet * u.SatisFiyat), u.Id, u.SatisFiyat);

                    int Aratoplam = 0;
                    for (int i = 0; i < dgvSatis.RowCount - 1; i++)
                    {
                        Aratoplam += Convert.ToInt32(dgvSatis.Rows[i].Cells[2].Value);
                    }
                    lblAraToplam.Text = Aratoplam.ToString();
                    Toplam = Convert.ToDecimal(Aratoplam + (Aratoplam * 0.18));
                    lblToplam.Text = Toplam.ToString();
                    GenelToplam = Toplam;
                    foreach (Promosyon p in ppi.AktifPromosyonlar(DateTime.Now))
                    {
                        GenelToplam -= GenelToplam * p.PromosyonOrani;
                        lblIndirimMiktari.Text = p.PromosyonAdi + " " + p.PromosyonOrani;
                    }
                    lblGenelToplam.Text = GenelToplam.ToString();
                    gnl.Temizle(panel2);
                }
            }
            else
            {
                MessageBox.Show("Adet miktarını sayısal olarak girdiğinizden emin olunuz!!!", "Hatalı Adet Girişi");
            }

        }

        private void btnSatis_Click(object sender, EventArgs e)
        {

            int SonSatisID = 0;
            Satis YeniSatis = new Satis();
            YeniSatis.MusteriId = IslemYapılanMusteri.Id;
            YeniSatis.Tarih = DateTime.Now;
            YeniSatis.PersonelId = personelID;
            YeniSatis.Silindi = false;
            if (Uislem.SatisEkle(YeniSatis))
            {
                SonSatisID = Uislem.SonSatisIDBul();
                //MessageBox.Show("Satış İşlemi Gerçekleşti.", "Satış Yapıldı.");
            }
            else
            {
                MessageBox.Show("SatisEklemedi");
            }

            SatisDetay sd = new SatisDetay();
            bool stokDurumu = true;
            for (int i = 0; i < dgvSatis.RowCount - 1; i++)
            {
                if(Uislem.SatisStokKontrol(Convert.ToInt32(dgvSatis.Rows[i].Cells[3].Value), Convert.ToInt32(dgvSatis.Rows[i].Cells[1].Value)))
                {
                    
                } 
                else
                {
                    stokDurumu = false;
                }
            }
            if(stokDurumu)
            {
                for (int i = 0; i < dgvSatis.RowCount - 1; i++)
                {
                    sd.PromosyonId = 2;

                    decimal fiyat = (Convert.ToDecimal(dgvSatis.Rows[i].Cells[1].Value) * Convert.ToDecimal(dgvSatis.Rows[i].Cells[4].Value));

                    fiyat += Convert.ToDecimal(fiyat * 18 / 100);
                    if (ppi.AktifPromosyonlar(DateTime.Now) != null)
                    {
                        foreach (Promosyon p in ppi.AktifPromosyonlar(DateTime.Now))
                        {
                            sd.PromosyonId = p.Id;
                            fiyat -= fiyat * p.PromosyonOrani;
                        }
                    }
                    sd.SatısId = SonSatisID;
                    sd.SatisFiyati = fiyat;
                    sd.UrunId = Convert.ToInt32(dgvSatis.Rows[i].Cells[3].Value);
                    sd.Miktar = Convert.ToInt32(dgvSatis.Rows[i].Cells[1].Value);
                    sd.Silindi = false;
                    Uislem.SatisDetayEkle(sd);
                    Uislem.StokAzalt(sd.UrunId, sd.Miktar);
                }
                dgvSatis.Rows.Clear();
                MessageBox.Show("Satış İşlemi Tamamlandı.", "İşlem Başarılı");
                lblAraToplam.Text = "";
                lblToplam.Text = "";
                lblIndirimMiktari.Text = "";
                lblGenelToplam.Text = "";

            
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnCikart_Click(object sender, EventArgs e)
        {
            dgvSatis.Rows.RemoveAt(dgvSatis.SelectedRows[0].Index);
            int Aratoplam = 0;
            for (int i = 0; i < dgvSatis.RowCount - 1; i++)
            {
                Aratoplam += Convert.ToInt32(dgvSatis.Rows[i].Cells[2].Value);
            }
            lblAraToplam.Text = Aratoplam.ToString();
            Toplam = Convert.ToDecimal(Aratoplam + (Aratoplam * 0.18));
            lblToplam.Text = Toplam.ToString();
            GenelToplam = Toplam;
            foreach (Promosyon p in ppi.AktifPromosyonlar(DateTime.Now))
            {
                GenelToplam -= GenelToplam * p.PromosyonOrani;
                lblIndirimMiktari.Text = p.PromosyonAdi + " " + p.PromosyonOrani;
            }
            lblGenelToplam.Text = GenelToplam.ToString();
        }
    }
}






