using BLL.Model;
using DAL.Context;
using PL.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.Personel
{
    public partial class GorevAtama : Form
    {
        public GorevAtama()
        {
            InitializeComponent();
        }

        private void circularPictureBox1_Click(object sender, EventArgs e)
        {
            lblGorevAdi.Text = txtGorevAdi.Text;
            txtGorevAdi.Clear();
            txtGorevBolumu.Focus();
        }

        private void cpbEkle_Click(object sender, EventArgs e)
        {
            
            clbGorevBolum.Items.Add(txtGorevBolumu.Text);
            txtGorevBolumu.Clear();
            txtGorevBolumu.Focus();
        }

        private void circularPictureBox2_Click(object sender, EventArgs e)
        {
            clbGorevBolum.Items.Remove(clbGorevBolum.SelectedItem);
            cbpsil.Visible = false;
        }

        private void GorevAtama_Load(object sender, EventArgs e)
        {
            cbpsil.Visible = false;
        }

        private void clbGorevBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbpsil.Visible = true;
            int a = clbGorevBolum.SelectedIndex;
            if (a!=-1)
            {
                txtGorevBolumu.Text = clbGorevBolum.Items[a].ToString();
                
            }

        }
        GorevHareketler hareket = new GorevHareketler();
        PersonelMusteriIslemleri pb = new PersonelMusteriIslemleri();
        ArrayList pers = new ArrayList();
        KullaniciDetay b = new KullaniciDetay();
        private void cpbPersEkle_Click(object sender, EventArgs e)
        {
         
            
           
            int pid = Convert.ToInt32(txtPersonelId.Text);
            KullaniciDetay b = new KullaniciDetay();
            DAL.Context.Personel p = new DAL.Context.Personel();


            try
            {
                p = pb.PersonelGetir(pid);
                b.lblAdi.Text = p.Ad;
                b.lblSoyAdi.Text = p.Soyad;
                b.circularPictureBox1.Image = Resources.icons8_businessman_48;
                flpPersList.Controls.Add(b);
                pers.Add(p.Id);
            }
            catch (Exception)
            {

                MessageBox.Show("Geçerli bir ID giriniz.");
            }           

            txtPersonelId.Clear();
            txtPersonelId.Focus();

        }


        pnlGorevKarti gk = new pnlGorevKarti();
        private void btnKartEkle_Click(object sender, EventArgs e)
        {          
            
            gk.lblGorevAdi.Text = lblGorevAdi.Text;
            gk.pnlGorevDetay.Controls.Add(clbGorevBolum);
            gk.lblGorevAdi = lblGorevAdi;
            gk.clbDetay.Visible = false;
            gk.pnlMembers.Controls.Add(b.circularPictureBox1);
            pnlGorevKartlarim.Controls.Add(gk);
        }

        private void btnGorevAta_Click(object sender, EventArgs e)
        {
            btnGorevAta.Enabled = false;
            txtPersonelId.Focus();
        }
        Gorev grv = new Gorev();
        private void btnKaydet_Click(object sender, EventArgs e)
        {

            grv.BaslangicTarihi = dtpGiris.Value;
            grv.BitisTarihi = dtpCikis.Value;
            grv.GorevAdi = lblGorevAdi.Text;
            hareket.GorevEkle(grv);



            List<GorevKayit> gkd = new List<GorevKayit>();
            if (pers.Count > 0)
            {
                foreach (int p in pers)
                {
                    GorevKayit gkyt = new GorevKayit();
                    gkyt.PersonelId = p;
                    gkyt.GorevId = grv.Id;
                    gkd.Add(gkyt);
                }

                hareket.GorevKayıtEkle(gkd);
            }
            else
                MessageBox.Show("En az 1 tane personel atanmalı.", "Items", MessageBoxButtons.OK, MessageBoxIcon.Information);


            List<GorevDetay> gd = new List<GorevDetay>();
            if (clbGorevBolum.Items.Count > 0)
            {
                foreach (string Gorevbolum in clbGorevBolum.Items)
                {
                    GorevDetay dty = new GorevDetay();
                    dty.DetayAdi = Gorevbolum;
                    dty.GorevId = grv.Id;
                    gd.Add(dty);
                }
               
                hareket.GorevDetayEkle(gd);
                MessageBox.Show("Görev kartı başarıyla oluşturuldu.");
                gk.Visible = false;
                txtGorevAdi.Clear();
                txtGorevBolumu.Clear();
                txtPersonelId.Clear();
                txtGorevAdi.Focus();
            }
            else
                MessageBox.Show("Detay alanı boş geçilemez.", "Items", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }

        private void cppGsil_Click(object sender, EventArgs e)
        {
            lblGorevAdi.Text="";
        }
    }
}
