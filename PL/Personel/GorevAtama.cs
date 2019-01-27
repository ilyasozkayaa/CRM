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
        List<KullaniciDetay> a = new List<KullaniciDetay>();
     
        private void cpbPersEkle_Click(object sender, EventArgs e)
        {
         
            
            pers.Add(txtPersonelId.Text);
            int pid = Convert.ToInt32(txtPersonelId.Text);
            KullaniciDetay b = new KullaniciDetay();
            //DAL.Context.Personel p = new DAL.Context.Personel();
            //p = pb.PersonelGetir(pid);
            //a.lblAdi.Text = p.Ad;
            //a.lblSoyAdi.Text = p.Soyad;
            b.circularPictureBox1.Image = Resources.icons8_businessman_48;




            pnlPersList.Controls.Add(b);
            

            txtPersonelId.Clear();
            txtPersonelId.Focus();

        }
        Gorev grv = new Gorev();
        private void btnKartEkle_Click(object sender, EventArgs e)
        {
            
            
            grv.BaslangicTarihi = dtpGiris.Value;
            grv.BitisTarihi = dtpGiris.Value;
            grv.GorevAdi = lblGorevAdi.Text;            
            
            hareket.GorevEkle(grv);          
           
            pnlGorevKarti gk = new pnlGorevKarti();
            gk.clbGorevİcerik = clbGorevBolum;
            gk.lblGorevAdi = lblGorevAdi;
            gk.cpbMember.Image = Resources.icons8_businessman_48;
            pnlGorevKartlarim.Controls.Add(gk);

            List<GorevKayit> gkd = new List<GorevKayit>();            
           
                foreach (string p in pers)
                {
                    GorevKayit gkyt = new GorevKayit();
                    gkyt.PersonelId = Convert.ToInt32(p);
                    gkyt.GorevId = grv.Id;
                    gkd.Add(gkyt);
                }

                hareket.GorevKayıtEkle(gkd);
            
           

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
            }
            else
                MessageBox.Show("Detay alanı boş geçilemez.", "Items", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnGorevAta_Click(object sender, EventArgs e)
        {
            btnGorevAta.Enabled = false;
        }
    }
}
