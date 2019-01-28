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
        Degiskentanimla deg = new Degiskentanimla();
        private void frmBilgilerim_Load(object sender, EventArgs e)
        {
            
            per.PersonelGetir(deg.Id);
            int gelenId = per.UsersIdyeGorePersoneliGetirme(deg.Id);
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

        private void panelGenelGilgi_Paint(object sender, PaintEventArgs e)
        {
            int gelenId = per.UsersIdyeGorePersoneliGetirme(deg.Id);
            prsl = per.PersonelGetir(gelenId);
            foreach (Control oda in panelGenelBilgi.Controls)
            {
                if (oda.GetType() == typeof(TextBox))
                {
                    txtTCKNo.Text = prsl.TCKNo;
                    txtDogumYeri.Text = prsl.DogumYeri;
                    txtDogumTarihi.Text = prsl.DogumTarihi.ToShortDateString();
                    txtEgitimDurumu.Text = prsl.EgitimDurumu;
                }
            }




           
            //prsl = per.PersonelGetir(gelenId);
            //txtTCKNo.Text = prsl.TCKNo;
            //txtDogumYeri.Text = prsl.DogumYeri;
            //txtDogumTarihi.Text = prsl.DogumTarihi.ToShortDateString();
            //txtEgitimDurumu.Text = prsl.EgitimDurumu;

        }

        //private void panelIsBilgileri_Paint(object sender, PaintEventArgs e)
        //{
        //    int gelenId = per.UsersIdyeGorePersoneliGetirme(deg.Id);
        //    prsl = per.PersonelGetir(gelenId);
        //    txtBaslangic.Text = prsl.IseGirisTarihi.ToShortDateString();
        //    txtMedeniHal.Text = prsl.MedeniHal;
        //    txtAskerlik.Text = prsl.AskerlikDurumu;
        //    txtEngel.Text = prsl.EngelDurumu;

        //}

        private void panelIletisimBilgileri_Paint(object sender, PaintEventArgs e)
        {
            int gelenId = per.UsersIdyeGorePersoneliGetirme(deg.Id);
            prsl = per.PersonelGetir(gelenId);
            txtTel.Text = prsl.Telefon;
            txtEmail.Text = prsl.Email;
            txtAdres.Text = prsl.Adres;
        }

        private void panelIsBilgileri_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelGenelPerformans_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
