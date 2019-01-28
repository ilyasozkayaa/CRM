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
        UrunIslemleri uIslem = new UrunIslemleri();
        int ktgID = 0;
        //private void FrmKategoriEkle(object sender, EventArgs e)
        //{
            
        //}

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelHeader1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKatagoriEkle_Click(object sender, EventArgs e)
        {
            Kategori EklenecekKtgr = new Kategori();
            EklenecekKtgr.KategoriAdi = txtKategoriAd.Text;
            EklenecekKtgr.Aciklama = txtAciklama.Text;
            if( uIslem.KategoriEkle(EklenecekKtgr))
            {
                MessageBox.Show("Kayıt Ekleme İşlemi Tamamlandı", "İşlem Başarılı");
            }
            else
            {
                MessageBox.Show("Ekleme İşlemi Esnasında Bir Sorunla Karşılaşıldı, Bilgileri Doğru Girdiğinizi Kontrol Ediniz!!!", "Hata!");
            }
                
            dgKatagoriListe.DataSource = uIslem.kategorileriGetir();
        }

        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            uIslem.KategoriSil(ktgID);

            dgKatagoriListe.DataSource = uIslem.kategorileriGetir();
        }

        private void dgKatagoriListe_DoubleClick(object sender, EventArgs e)
        {
            txtAciklama.Text = dgKatagoriListe.SelectedRows[0].Cells[2].Value.ToString();
            txtKategoriAd.Text = dgKatagoriListe.SelectedRows[0].Cells[1].Value.ToString();
            ktgID =Convert.ToInt32( dgKatagoriListe.SelectedRows[0].Cells[0].Value);
            
        }

        private void btnKategoriGuncelle_Click(object sender, EventArgs e)
        {
            Kategori k= new Kategori();
            k.Id = ktgID;
            k.Aciklama = txtAciklama.Text;
            k.KategoriAdi = txtKategoriAd.Text;
            uIslem.KategoriGuncelle(k);
            dgKatagoriListe.DataSource = uIslem.kategorileriGetir();
        }
    }
}
