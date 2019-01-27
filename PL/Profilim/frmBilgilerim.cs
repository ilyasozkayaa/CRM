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
    
        Degiskentanimla deg = new Degiskentanimla();
        private void frmBilgilerim_Load(object sender, EventArgs e)
        {
            PersonelMusteriIslemleri per = new PersonelMusteriIslemleri();
            DAL.Context.Personel prsl = new DAL.Context.Personel();
            //per.PersonelGetir(deg.Id);
            int gelenId=per.UsersIdyeGorePersoneliGetirme(deg.Id);
            prsl = per.PersonelGetir(gelenId);
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
            //circularPictureBox1.Image = prsl.Image.




            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void circularPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

       

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
