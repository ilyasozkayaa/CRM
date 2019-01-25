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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int KullaniciId = 12345;
            int KulaniciSifre = 12345;
            if (KullaniciId.ToString()==txtId.Text && KulaniciSifre.ToString()==txtParola.Text)
            {
                this.Close();
                Form frm = new frmAnasayfa();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Yanlış parola veya kullanıcı adı");

            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
