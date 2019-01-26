using PL.Properties;
using System;
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

        private void cpbPersEkle_Click(object sender, EventArgs e)
        {
            KullaniciDetay kd = new KullaniciDetay();
            kd.lblAdi.Text = txtPersonelId.Text;
            kd.lblSoyAdi.Text = txtPersonelAdi.Text;
            kd.circularPictureBox1.Image = Resources.icons8_businessman_48;
            pnlPersList.Controls.Add(kd);
        }

        private void btnKartEkle_Click(object sender, EventArgs e)
        {
            pnlGorevKarti gk = new pnlGorevKarti();
            gk.clbGorevİcerik = clbGorevBolum;
            gk.lblGorevAdi = lblGorevAdi;
            gk.cpbMember.Image = Resources.icons8_businessman_48;
            pnlGorevKartlarim.Controls.Add(gk);
        }
    }
}
