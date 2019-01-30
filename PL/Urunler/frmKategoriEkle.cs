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
    public partial class frmKategoriEkle : Form
    {
        public frmKategoriEkle()
        {
            InitializeComponent();
        }
        UrunIslemleri Uislem = new UrunIslemleri();
        Genel gnl = new Genel();
        int ktgID = 0;

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (txtAciklama.Text.Trim() != "" && txtKategoriAd.Text.Trim() != "")
            {
                if (Uislem.KategoriEkleKontrol(txtKategoriAd.Text))
                {
                    MessageBox.Show("Bu Kategori Zaten Var.", "İşlem Yapılmadı.");
                }
                else
                {
                    Kategori Yeniktg = new Kategori();
                    Yeniktg.KategoriAdi = txtKategoriAd.Text;
                    Yeniktg.Aciklama = txtAciklama.Text;

                    if (Uislem.kategoriekle(Yeniktg))
                    {
                        MessageBox.Show("Kayıt İşlemi Tamamlandı.", "Kayıt Başarılı");
                        dgKatagoriListe.DataSource = Uislem.KategoriListesi();
                        gnl.Temizle(panelKategoriEkle);

                    }
                    else
                    {
                        MessageBox.Show("Kayıt İşlemi Tamamlanamadı!!!", "Kayıt Başarısız");
                    }
                }

            }
            else
            {
                MessageBox.Show("Gerekli Alanları Doldurunuz!!!");
            }
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            if (txtKategoriAd.Text.Trim() != "" && txtAciklama.Text.Trim() != "")
            {
                if (Uislem.KategoriGuncelleKontrol(ktgID, txtKategoriAd.Text))
                {
                    MessageBox.Show("Bu İsimde Bir Kategori Zaten Var.", "İşlem Gerçekleşmedi.");
                }
                else
                {
                    Kategori DegisecekKTG = new Kategori();
                    DegisecekKTG.KategoriAdi = txtKategoriAd.Text;
                    DegisecekKTG.Aciklama = txtAciklama.Text;
                    DegisecekKTG.Id = ktgID;
                    if (Uislem.KategoriGuncelle(DegisecekKTG))
                    {
                        MessageBox.Show("Kategori Güncellendi.", "İşlem Başarılı.");
                        dgKatagoriListe.DataSource = Uislem.KategoriListesi();
                        gnl.Temizle(panelKategoriEkle);
                    }
                    else
                    {
                        MessageBox.Show("Kategori Güncellenemedi", "İşlem Başarısız");
                    }
                }


            }
            else
            {
                MessageBox.Show("Gerekli Alanları Doldurunuz.", "İşlem Gerçekleşmedi.");
            }
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Bilgileri Silinmek Üzere!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Uislem.kategoriSil(Convert.ToInt32(ktgID)))
                {
                    MessageBox.Show("Kategori Silindi.", "Silme İşlemi Başarılı.");
                    dgKatagoriListe.DataSource = Uislem.KategoriListesi();
                    gnl.Temizle(panelKategoriEkle);
                }
                else
                {
                    MessageBox.Show("Kategori Silme İşlemi Başarısız", "Hata!!!");
                }
            }
        }

        private void dgKatagoriListe_DoubleClick(object sender, EventArgs e)
        {
            ktgID = Convert.ToInt32(dgKatagoriListe.SelectedRows[0].Cells[0].Value);
            txtKategoriAd.Text = dgKatagoriListe.SelectedRows[0].Cells[1].Value.ToString();
            txtAciklama.Text = dgKatagoriListe.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void frmKategoriEkle_Load(object sender, EventArgs e)
        {
            dgKatagoriListe.DataSource = Uislem.KategoriListesi();
            dgKatagoriListe.Columns[0].Visible = false;
            dgKatagoriListe.Columns[1].Width = 300;
            dgKatagoriListe.Columns[2].Width = 300;
            dgKatagoriListe.Columns[3].Visible = false;
        }

     
    }
}
