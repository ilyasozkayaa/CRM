using PL.Kampanyalar;
using PL.KasaIslemleri;
using PL.Personel;
using PL.Profilim;
using PL.Properties;
using PL.Urunler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class frmAnasayfa : Form
    {
        int PanelWidth;
        bool hidden;

        private bool Acikmi;
        public frmAnasayfa()
        {
            InitializeComponent();
            PanelWidth = flpMenu.Width;
            hidden = false;
            this.WindowState= FormWindowState.Maximized;           
        }
        private void FormAc(Form AF)
        {
            foreach (Control F in this.pnlContent.Controls)
            {
                if (F is Form)
                {
                    Form MF = (Form)F;
                    MF.Close();
                }
            }
            AF.TopLevel = false;
            this.pnlContent.Controls.Add(AF);
            AF.Dock = DockStyle.Fill;
            AF.Show();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            timer3.Start();
            lblTarih.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lbltoday.Text = DateTime.Today.ToShortDateString();
        }       

  
     

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
 
        private void timer1_Tick(object sender, EventArgs e)
        {
            AcKapa(panel3,timer1,btnProfile);           
        }
       
        private void AcKapa(Panel p,Timer t,Button b)
        {
            b.Image = Resources.uparrow;
            if (Acikmi)
            {
                p.Height += 10;
                if (p.Size == p.MaximumSize)
                {
                    t.Stop();
                    Acikmi = false;
                }
            }
            else
            {
                b.Image = Resources.downbutton;
                p.Height -= 10;
                if (p.Size == p.MinimumSize)
                {
                    t.Stop();
                    Acikmi = true;
                }
            }
        }
      

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                flpMenu.Width = flpMenu.Width += 80;
                if (flpMenu.Width>=PanelWidth)
                {
                    timer2.Stop();
                    hidden = false;
                    this.Refresh();
                }


            }
            else
            {
                flpMenu.Width = flpMenu.Width -= 80;
                if (flpMenu.Width <=0)
                {
                    timer2.Stop();
                    hidden = true;
                    this.Refresh();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnBilgiler_Click(object sender, EventArgs e)
        {
            frmBilgilerim frm = new frmBilgilerim();
            FormAc(frm);
        }

        private void btnGörevlerim_Click(object sender, EventArgs e)
        {
            frmGorevlerim frm = new frmGorevlerim();
            FormAc(frm);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized
                         ? FormWindowState.Normal
                         : FormWindowState.Maximized;
        }
        
        private void btnPersonicon_Click(object sender, EventArgs e)
        {
            btnPersonicon.Image = Resources.notifred;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            timer4.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            AcKapa(pnlPersoneSekme,timer4,btnPersonel);
        }

        private void btnPersoneller_Click(object sender, EventArgs e)
        {
            Personel.Personeller frm = new Personel.Personeller();
            FormAc(frm);
        }

        private void btnGorevAta_Click(object sender, EventArgs e)
        {
            GorevAtama frm = new GorevAtama();
            FormAc(frm);
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            frmSatisIslemleri frm = new frmSatisIslemleri();
            FormAc(frm);
        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            timer5.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            AcKapa(pnlUrun, timer5,btnUrun);
        }

        private void btnKategoriekle_Click(object sender, EventArgs e)
        {
            frmKategoriEkle frm = new frmKategoriEkle();
            FormAc(frm);
        }

        private void btnUrunEk_Click(object sender, EventArgs e)
        {
            frmUrunEkle frm = new frmUrunEkle();
            FormAc(frm);
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            frmUrunStokİslemleri frm = new frmUrunStokİslemleri();
            FormAc(frm);
        }

        private void btnUrun1_Click(object sender, EventArgs e)
        {
            frmSatisIslemleri frm = new frmSatisIslemleri();
            FormAc(frm);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            Raporlar frm = new Raporlar();
            FormAc(frm);
        }

        private void btnKampanya_Click(object sender, EventArgs e)
        {
            frmKampanyalar frm = new frmKampanyalar();
            FormAc(frm);
        }
    }
}
