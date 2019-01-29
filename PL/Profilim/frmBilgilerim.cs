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
            txtTCKNo.Text = prsl.TCKNo;
            txtDogumYeri.Text = prsl.DogumYeri;
            txtDogumTarihi.Text = prsl.DogumTarihi.ToShortDateString();
            txtEgitimDurumu.Text = prsl.EgitimDurumu;
            txtBaslangic.Text = prsl.IseGirisTarihi.ToShortDateString();
            txtMedeniHal.Text = prsl.MedeniHal;
            txtAskerlik.Text = prsl.AskerlikDurumu;
            txtEngel.Text = prsl.EngelDurumu;
            txtTel.Text = prsl.Telefon;
            txtEmail.Text = prsl.Email;
            txtAdres.Text = prsl.Adres;
            circularPictureBox1.ImageLocation = prsl.Image;





        }
    }
}
     
