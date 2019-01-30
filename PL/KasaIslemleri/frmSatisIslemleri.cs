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

namespace PL.KasaIslemleri
{
    public partial class frmSatisIslemleri : Form
    {
        public frmSatisIslemleri()
        {
            InitializeComponent();
        }
        PersonelMusteriIslemleri pmi = new PersonelMusteriIslemleri();
        public static int MusteriID = 1177;
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

        private void txtTelNO_TextChanged(object sender, EventArgs e)
        {
            if (txtTelNO.Text.Trim().Length == 10)
            {
                Musteri m = new Musteri();
                m = pmi.MusteriKayitlimi(txtTelNO.Text);
                if (m != null)
                {
                    MusteriID = m.Id;
                    MessageBox.Show("Müşteri Adı : " + m.Ad);
                    frmUyeMusteri frm = new frmUyeMusteri();
                    FormAc(frm);
                    btnUyesiz.Enabled = false;
                    btnYeniMust.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Bu telefon numarası sistemde kayıtlı değil!", "Yeni Müşteri");
                }
            }
        }
    }
}
