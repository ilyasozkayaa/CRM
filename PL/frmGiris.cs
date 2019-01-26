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

namespace PL
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        Genel Gnl = new Genel();

        private void frmGiris_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim()!="" && txtParola.Text.Trim()!="")
            {
                if(Gnl.giris(txtId.Text,txtParola.Text)!=0)
                {                   
                    Form frm = new frmAnasayfa();
                    frm.Show();                   
                }
                else
                {
                    MessageBox.Show("Bilgilerinizi kontrol ediniz!!!", "Hatalı Giriş!");
                }
            }
            else
            {
                MessageBox.Show("Şifre ve Parolanızı Giriniz!!!", "Eksik bilgi Girişi Yaptınız!");
            }
           
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
