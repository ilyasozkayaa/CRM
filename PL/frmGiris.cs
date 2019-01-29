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
            pnlDegis.Visible =false;
            lblYenile.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonelMusteriIslemleri prm = new PersonelMusteriIslemleri();
            if (txtId.Text.Trim() != "" && txtParola.Text.Trim() != "")
            {
                int GirisId = Gnl.giris(txtId.Text, txtParola.Text);
                GenelDegiskenler.PersonId= prm.UsersIdyeGorePersoneliGetirme(GirisId);
                

                if (GirisId != 0)
                {
                    Form frm = new frmAnasayfa();
                    frm.Show();
                    this.Visible = false;
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
        //Parola yenileme panel bağlantısı
        private void lnkSifre_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtId.Text.Trim()!="")
            {
                pnlDegis.Visible = true;
                circularPictureBox1.Visible = false;
                lblYenile.Visible = true;
            }
            else
            {
                MessageBox.Show("Şifre yenileme işlemi için Personel Id'inizi girmelisiniz!");
            }
           
            
        }
        //Parola yenileme işlemi
        private void button2_Click_1(object sender, EventArgs e)
        {
            pnlDegis.Visible = false;
            circularPictureBox1.Visible = true;
            lblYenile.Visible = false;
            if (txtp.Text.Trim()!="" && txtp2.Text.Trim()!="" && txtp.Text==txtp2.Text)
            {
                if(Gnl.ParolaSifirla(txtId.Text,txtp.Text))
                {
                    MessageBox.Show("Parolanız başarı ile değiştirildi.");
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
    }
}
