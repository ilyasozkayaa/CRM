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

            btnOnay.Visible = false;
            prsl = per.PersonelGetir(GenelDegiskenTanimlama.Id);
            labelAd.Text = prsl.Ad;
            labelSoyad.Text = prsl.Soyad;
            txtTCKNo.Text = prsl.TCKNo;
            txtDogumYeri.Text = prsl.DogumYeri;
            txtDogumT.Text = prsl.DogumTarihi.ToShortDateString();
            txtEgitimDurumu.Text = prsl.EgitimDurumu;
            txtBaslangicT.Text = prsl.IseGirisTarihi.ToShortDateString();
            txtMedeniHal.Text = prsl.MedeniHal;
            txtAskerlikDurumu.Text = prsl.AskerlikDurumu;
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
            txtTCKNo.ReadOnly = false;
            txtDogumYeri.ReadOnly = false;
            txtDogumT.ReadOnly = false;
            txtEgitimDurumu.ReadOnly = false;
            txtBaslangicT.ReadOnly = false;
            txtMedeniHal.ReadOnly = false;
            txtAskerlikDurumu.ReadOnly = false;
            txtEngel.ReadOnly = false;
            txtTel.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtAdres.ReadOnly = false;

        }

        private void btnOnay_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Güncelemek istiyor musunuz?", "Güncellensin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                DAL.Context.Personel person = new DAL.Context.Personel();
                person.Ad = labelAd.Text;
                person.Soyad = labelSoyad.Text;
                person.TCKNo = txtTCKNo.Text;
                person.Telefon = txtTel.Text;
                person.DogumTarihi = Convert.ToDateTime(txtDogumT.Text);
                person.DogumYeri = txtDogumYeri.Text;
                person.Adres = txtAdres.Text;
                person.Email = txtEmail.Text;
                person.MedeniHal = txtMedeniHal.Text;
                person.AskerlikDurumu = txtAskerlikDurumu.Text;
                person.EngelDurumu = txtEngel.Text;
                person.EgitimDurumu = txtEgitimDurumu.Text;
                person.Id = GenelDegiskenTanimlama.Id;
                per.personelGüncelle(person);
                btnOnay.Visible = false;
                btnGuncelle.Visible = true;
                MessageBox.Show("Personel Bilgileri Güncellendi.", "Güncelleme Tamamlandı.");

                txtTCKNo.ReadOnly = true;
                txtDogumYeri.ReadOnly = true;
                txtDogumT.ReadOnly = true;
                txtEgitimDurumu.ReadOnly = true;
                txtBaslangicT.ReadOnly = true;
                txtMedeniHal.ReadOnly = true;
                txtAskerlikDurumu.ReadOnly = true;
                txtEngel.ReadOnly = true;
                txtTel.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtAdres.ReadOnly = true;
            }
            else
            {



                MessageBox.Show("Güncelleme işlemi Gerçekleşmedi !");
                DAL.Context.Personel prsl = new DAL.Context.Personel();
                prsl = per.PersonelGetir(GenelDegiskenTanimlama.Id);
                txtTCKNo.Text = prsl.TCKNo;
                txtTel.Text = prsl.Telefon;
                txtDogumT.Text = prsl.DogumTarihi.ToString();
                txtDogumYeri.Text = prsl.DogumYeri;
                txtAdres.Text = prsl.Adres;
                txtEmail.Text = prsl.Email;
                txtMedeniHal.Text = prsl.MedeniHal;
                txtAskerlikDurumu.Text = prsl.AskerlikDurumu;
                txtEngel.Text = prsl.EngelDurumu;
                txtEgitimDurumu.Text = prsl.EgitimDurumu;
                prsl.Id = GenelDegiskenTanimlama.Id;

                txtTCKNo.ReadOnly = true;
                txtDogumYeri.ReadOnly = true;
                txtDogumT.ReadOnly = true;
                txtEgitimDurumu.ReadOnly = true;
                txtBaslangicT.ReadOnly = true;
                txtMedeniHal.ReadOnly = true;
                txtAskerlikDurumu.ReadOnly = true;
                txtEngel.ReadOnly = true;
                txtTel.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtAdres.ReadOnly = true;
                btnOnay.Visible = false;
                btnGuncelle.Visible = true;

            }

        }
    }
}
