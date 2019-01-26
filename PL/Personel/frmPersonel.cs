using BLL.Model;
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

        

        
        private void pbFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya1 = new OpenFileDialog();
            dosya1.ShowDialog();
            dosyayolu = dosya1.FileName;
            pbFoto.ImageLocation = dosyayolu;

        }

        private void btnResimKaydet_Click(object sender, EventArgs e)
        {
           
            SaveFileDialog dosya = new SaveFileDialog();  //yeni bir kaydetme diyaloğu oluşturuyoruz.

            dosya.Filter = "jpeg dosyası(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";//.bmp veya .jpg olarak kayıt imkanı sağlıyoruz.

            dosya.Title = "Kayıt";//diğaloğumuzun başlığını belirliyoruz.

            dosya.FileName = "resim.jpeg";//kaydedilen resmimizin adını 'resim' olarak belirliyoruz.

            //pbFoto.Image.Save("C: \\Users\\ÖZLEM\\Desktop\\CRM\\DAL\\resm");
            //dosya.InitialDirectory = "C: \\Users\\ÖZLEM\\Desktop\\CRM\\DAL\\resm";

           

            
            
        
                string hedef = Path.Combine("C: \\Users\\ÖZLEM\\Desktop\\CRM\\DAL\\resm", dosya.FileName);
                File.Copy(dosyayolu, hedef);
             

            }

        private void panelPersonelResim_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }
    }
    }

