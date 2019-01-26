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




      

        private void panelPersonelResim_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DAL.Context.Personel personelList = new DAL.Context.Personel();
            personelList.Ad = txtAd.Text;
            personelList.Soyad = txtSoyad.Text;
            personelList.TCKNo = txtTCKNo.Text;
            personelList.Telefon = txtTelefon.Text;
            personelList.DogumTarihi = dtpDogumT.Value;
            personelList.DogumYeri = cbDogumYeri.SelectedItem.ToString();
            personelList.Adres = txtAdres.Text;
            personelList.Email = txtEmail.Text;
            personelList.Image = gen.imagePath;
            personelList.Cinsiyet = cbCinsiyet.SelectedValue.ToString();
            personelList.IseGirisTarihi = dateİseGiris.Value;
            personelList.IstenCikisTarihi = dateİseGiris.Value;
            bool sonuc = pmi.personelEkle(personelList);
            if (sonuc)
            {
                MessageBox.Show("kayı basarılı");
            }
            else
            {
                MessageBox.Show("kayı basarısız");
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
            File.Move(dosyayolu, "C: \\Users\\ÖZLEM\\Desktop\\CRM\\DAL\\resm" +txtAd.Text+""+txtSoyad.Text+".jpg");
            string hedef = Path.Combine("C: \\Users\\ÖZLEM\\Desktop\\CRM\\DAL\\resm\\"+txtAd.Text+""+ txtSoyad.Text+".jpg");
            gen.imagePath = hedef;

        }
    }
}

