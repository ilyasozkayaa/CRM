using BLL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.Profilim
{
    public partial class frmBilgilerim : Form
    {
        public frmBilgilerim()
        {
            InitializeComponent();
        }

        PersonelMusteriIslemleri per = new PersonelMusteriIslemleri();
        DAL.Context.Personel prsl = new DAL.Context.Personel();

        private void frmBilgilerim_Load(object sender, EventArgs e)
        {

            //int gelenId = per.UsersIdyeGorePersoneliGetirme();
            prsl = per.PersonelGetir(GenelDegiskenTanimlama.Id);
            labelAd.Text = prsl.Ad;
            labelSoyad.Text = prsl.Soyad;
            txtTCKNo.Text = prsl.TCKNo;
            txtDogumYeri.Text = prsl.DogumYeri;
            txtDogumT.Text = prsl.DogumTarihi.ToShortDateString();
            txtEgitimDurumu.Text = prsl.EgitimDurumu;
            txtBaslangicT.Text = prsl.IseGirisTarihi.ToShortDateString(); ;
            txtMedeniHal.Text = prsl.MedeniHal;
            txtAskerlikDurumu.Text = prsl.AskerlikDurumu;
            txtEngel.Text = prsl.EngelDurumu;
            txtTel.Text = prsl.Telefon;
            txtEmail.Text = prsl.Email;
            txtAdres.Text = prsl.Adres;
            circularPictureBox1.ImageLocation = prsl.Image;


        }
    }
}
