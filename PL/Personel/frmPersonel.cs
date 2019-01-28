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
        //Bitmap bmp;

        PersonelMusteriIslemleri pmi = new PersonelMusteriIslemleri();
        Degiskentanimla gen = new Degiskentanimla();
        CRMContext ent = new CRMContext();

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DAL.Context.Personel personelList = new DAL.Context.Personel();
           User user = new User();
            string KullaniciAdi, KullaniciSifre;
            personelList.Ad      = txtAd.Text;
            personelList.Soyad   = txtSoyad.Text;
            personelList.TCKNo   = txtTCKNo.Text;
            personelList.Telefon = txtTelefon.Text;
            personelList.DogumTarihi = dtpDogumT.Value;
            personelList.DogumYeri = cbDogumYeri.SelectedItem.ToString();
            personelList.Adres     = txtAdres.Text;
            personelList.Email     = txtEmail.Text;
            personelList.AskerlikDurumu = cbAskerlik.SelectedItem.ToString();
            personelList.EgitimDurumu = cbEgitim.SelectedItem.ToString();
            personelList.EngelDurumu = cbEngel.ToString();
            personelList.MedeniHal = cbMedeniHal.SelectedItem.ToString();
            personelList.Image     = gen.imagePath;
            personelList.Cinsiyet  = cbCinsiyet.SelectedItem.ToString();
            personelList.IseGirisTarihi = dateİseGiris.Value;
            personelList.IstenCikisTarihi = dateİseGiris.Value;
            personelList.UserId = cbPozisyon.SelectedIndex;
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

            bool sonuc = pmi.personelEkle(personelList);
            if (sonuc)
            {
                MessageBox.Show("kayıt basarılı");
               
            }
            else
            {
                MessageBox.Show("kayıt basarısız");
            }


        }

        private void pbFoto_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dosya1 = new OpenFileDialog();
            dosya1.ShowDialog();
            dosyayolu = dosya1.FileName;
            pbFoto.ImageLocation = dosyayolu;
            MessageBox.Show(dosyayolu);

            SaveFileDialog dosya = new SaveFileDialog();  //yeni bir kaydetme diyaloğu oluşturuyoruz.

            dosya.Filter = "jpeg dosyası(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";//.bmp veya .jpg olarak kayıt imkanı sağlıyoruz.

            dosya.Title = "Kayıt";//diğaloğumuzun başlığını belirliyoruz.

            //dosya.FileName = "resim.jpeg";//kaydedilen resmimizin adını 'resim' olarak belirliyoruz.



            
            //File.Copy(dosyayolu, hedef);
            File.Move(dosyayolu, "C: \\Users\\ÖZLEM\\Desktop\\CRM\\DAL\\resm\\" +txtAd.Text+""+txtSoyad.Text+".jpg");
            string hedef = Path.Combine("C: \\Users\\ÖZLEM\\Desktop\\CRM\\DAL\\resm\\"+txtAd.Text+""+ txtSoyad.Text+".jpg");
            gen.imagePath = hedef;

        }

        private void panelPersonelResim_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

