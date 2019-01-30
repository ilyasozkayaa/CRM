using BLL.Model;
using DAL.Context;
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

namespace PL.Personeller
{
    public partial class frmPersonel : Form
    {
        public frmPersonel()
        {
            InitializeComponent();
        }
        string dosyayolu;
        PersonelMusteriIslemleri pmi = new PersonelMusteriIslemleri();
        CRMContext ent = new CRMContext();




        private void btnKaydet_Click(object sender, EventArgs e)
        {
            User user = new User();
            DAL.Context.Personel personelList = new DAL.Context.Personel();
            string KullaniciAdi, KullaniciSifre;
            KullaniciAdi = txtSoyad.Text + txtAd.Text.Substring(0, 1);
            KullaniciSifre = txtSoyad.Text.Substring(0, 1) + dtpDogumT.Value.Year + txtTCKNo.Text.Substring(3);
            txtKullaniciAd.Text = KullaniciAdi;
            txtKullaniciSifre.Text = KullaniciSifre;
            user.KullaniciAdi = KullaniciAdi;
            user.Parola = KullaniciSifre;
            user.YetkiDüzeyi = cbPozisyon.SelectedItem.ToString();
            bool result = pmi.UserEkle(user);
            if (result)
            {
                MessageBox.Show("User kaydı  basarılı");

            }
            else
            {
                MessageBox.Show("User kaydı basarısız");
            }

            personelList.Ad = txtAd.Text;
            personelList.Soyad = txtSoyad.Text;
            personelList.TCKNo = txtTCKNo.Text;
            personelList.Telefon = txtTelefon.Text;
            personelList.DogumTarihi = dtpDogumT.Value;
            personelList.DogumYeri = cbDogumYeri.SelectedItem.ToString();
            personelList.Adres = txtAdres.Text;
            personelList.Email = txtEmail.Text;
            personelList.AskerlikDurumu = cbAskerlik.SelectedItem.ToString();
            personelList.EgitimDurumu = cbEgitim.SelectedItem.ToString();
            personelList.EngelDurumu = cbEngel.ToString();
            personelList.MedeniHal = cbMedeni.SelectedItem.ToString();
            personelList.Image = GenelDegiskenTanimlama.imagePath;
            personelList.Cinsiyet = cbCinsiyet.SelectedItem.ToString();
            personelList.IseGirisTarihi = dateİseGiris.Value;
            personelList.IstenCikisTarihi = dateİseGiris.Value;
            personelList.UserId = user.Id;



            bool sonuc = pmi.personelEkle(personelList);
            if (sonuc)
            {
                MessageBox.Show("Personel kaydı basarılı");

            }
            else
            {
                MessageBox.Show("Personel kaydı basarısız");
            }


        }

        private void pbFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya1 = new OpenFileDialog();
            dosya1.ShowDialog();
            dosyayolu = dosya1.FileName;
            pbFoto.ImageLocation = dosyayolu;
            MessageBox.Show(dosyayolu);

            SaveFileDialog dosya = new SaveFileDialog();  //yeni bir kaydetme diyaloğu oluşturuyoruz.

            dosya.Filter = "jpeg dosyası(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";//.bmp veya .jpg olarak kayıt imkanı sağlıyoruz.

            dosya.Title = "Kayıt";//diğaloğumuzun başlığını belirliyoruz.  
            //File.Copy(dosyayolu, hedef);
            File.Move(dosyayolu, "C: \\Users\\ÖZLEM\\Desktop\\CRM\\DAL\\resm\\" + txtAd.Text + "" + txtSoyad.Text + ".jpg");
            string hedef = Path.Combine("C: \\Users\\ÖZLEM\\Desktop\\CRM\\DAL\\resm\\" + txtAd.Text + "" + txtSoyad.Text + ".jpg");
            GenelDegiskenTanimlama.imagePath = hedef;
        }

        //private void btnKaydetDeneme_Click(object sender, EventArgs e)
        //{

        //    if (string.IsNullOrEmpty(txtTCKNo.Text) || string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text))
        //    {
        //        MessageBox.Show("Eksik Bilgi Girişi!.", "Zorunlu Alanları Doldurunuz!.");
        //    }
        //    else
        //    {
        //        if (txtTCKNo.TextLength == 11)
        //        {

        //            if (pmi.Sec(txtTCKNo.Text) != null)
        //            {
        //                MessageBox.Show("Sistemde kayıtlı.");

        //            }
        //            else
        //            {
        //                User user = new User();
        //                DAL.Context.Personel personelList = new DAL.Context.Personel();
        //                personelList.Ad = txtAd.Text.Substring(0, 1).ToUpper() + txtAd.Text.Substring(1).ToLower();
        //                personelList.Soyad = txtSoyad.Text.Substring(0, 1).ToUpper() + txtSoyad.Text.Substring(1).ToLower(); ;
        //                personelList.TCKNo = txtTCKNo.Text;
        //                personelList.Telefon = txtTelefon.Text;
        //                personelList.DogumTarihi = dtpDogumT.Value;
        //                personelList.DogumYeri = cbDogumYeri.SelectedItem.ToString();
        //                personelList.Adres = txtAdres.Text;
        //                personelList.Email = txtEmail.Text;
        //                personelList.AskerlikDurumu = cbAskerlik.SelectedItem.ToString();
        //                personelList.EgitimDurumu = cbEgitim.SelectedItem.ToString();
        //                personelList.EngelDurumu = cbEngel.ToString();
        //                personelList.MedeniHal = cbMedeni.SelectedItem.ToString();
        //                personelList.Image = GenelDegiskenTanimlama.imagePath;
        //                personelList.Cinsiyet = cbCinsiyet.SelectedItem.ToString();
        //                if (cbCinsiyet.SelectedItem.ToString() == "K") cbAskerlik.Visible = false;
        //                personelList.IseGirisTarihi = dateİseGiris.Value;
        //                personelList.IstenCikisTarihi = dateİseGiris.Value;
        //                personelList.UserId = user.Id;


        //                bool sonuc = pmi.personelEkle(personelList);
        //                if (sonuc)
        //                {
        //                    MessageBox.Show("Personel kaydı basarılı");

        //                }
        //                else
        //                {
        //                    MessageBox.Show("Personel kaydı basarısız");
        //                }

        //                    }

        //                }
        ////            }
        ////        }
    }
}

