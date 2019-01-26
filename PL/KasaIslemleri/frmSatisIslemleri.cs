using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.KasaIslemleri
{
    public partial class frmSatisIslemleri : Form
    {
        public frmSatisIslemleri()
        {
            InitializeComponent();
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
        private void btnUyemusteri_Click(object sender, EventArgs e)
        {
            frmUyeMusteri frm = new frmUyeMusteri();
            FormAc(frm);
        }

        private void btnUyesiz_Click(object sender, EventArgs e)
        {
            frmUyeMusteri frm = new frmUyeMusteri();
            frm.pnlMusteri.Visible = false;
            FormAc(frm);
        }

        private void btnYeniMust_Click(object sender, EventArgs e)
        {
            frmUyeKayit frm = new frmUyeKayit();
            FormAc(frm);
        }

        private void btnIade_Click(object sender, EventArgs e)
        {
            frmUrunIade frm = new frmUrunIade();
            FormAc(frm);
        }
    }
}
