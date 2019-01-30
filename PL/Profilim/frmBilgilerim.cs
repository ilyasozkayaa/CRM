using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Model;
using DAL.Context;

namespace PL.Profilim
{
    public partial class frmBilgilerim : Form
    {
        public frmBilgilerim()
        {
            InitializeComponent();
        }
        CRMContext ent = new CRMContext();
        PersonelMusteriIslemleri per = new PersonelMusteriIslemleri();

        DAL.Context.Personel prsl = new DAL.Context.Personel();
        private void frmBilgilerim_Load(object sender, EventArgs e)
        {

            btnOnay.Visible = false;
            //int gelenId = per.UsersIdyeGorePersoneliGetirme();
            prsl = per.PersonelGetir(GenelDegiskenTanimlama.Id);
            labelAd.Text = prsl.Ad;
            labelSoyad.Text = prsl.Soyad;
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            btnOnay.Visible = true;
            btnGuncelle.Visible = false;
            txtTCKNo.ReadOnly =false;
            txtDogumYeri.ReadOnly = false;
            txtDogumTarihi.ReadOnly = false;
            txtEgitimDurumu.ReadOnly = false;
            txtBaslangic.ReadOnly = false;
            txtMedeniHal.ReadOnly = false;
            txtAskerlik.ReadOnly = false;
            txtEngel.ReadOnly = false;
            txtTel.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtAdres.ReadOnly = false;

           

        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Güncellemek İstiyor musunuz");
            DAL.Context.Personel person = new DAL.Context.Personel();
            person.Ad = labelAd.Text;
            person.Soyad = labelSoyad.Text;
            person.TCKNo = txtTCKNo.Text;
            person.Telefon = txtTel.Text;
            person.DogumTarihi = Convert.ToDateTime(txtDogumTarihi.Text);
            person.DogumYeri = txtDogumYeri.Text;
            person.Adres = txtAdres.Text;
            person.Email = txtEmail.Text;
            //person.Image = circularPictureBox1.Image;
            //person.IstenCikisTarihi = p.IstenCikisTarihi;
            person.MedeniHal = txtMedeniHal.Text;
            person.AskerlikDurumu = txtAskerlik.Text;
            person.EngelDurumu = txtEngel.Text;
            person.EgitimDurumu = txtEgitimDurumu.Text;
            person.Id = GenelDegiskenTanimlama.Id;
            per.personelGüncelle(person);
            btnOnay.Visible = false;
            btnGuncelle.Visible = true;
            MessageBox.Show("Güncelleme işleminiz onaylandı.");

            txtTCKNo.ReadOnly = true;
            txtDogumYeri.ReadOnly = true;
            txtDogumTarihi.ReadOnly = true;
            txtEgitimDurumu.ReadOnly = true;
            txtBaslangic.ReadOnly = true;
            txtMedeniHal.ReadOnly = true;
            txtAskerlik.ReadOnly = true;
            txtEngel.ReadOnly = true;
            txtTel.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtAdres.ReadOnly = true;

        }
    }
}
     
