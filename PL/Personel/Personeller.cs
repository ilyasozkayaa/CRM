using BLL.Model;
using DAL.Context;
using PL.Personeller;
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
    public partial class Personeller : Form
    {
        public Personeller()
        {
            InitializeComponent();
        }
        CRMContext ent = new CRMContext();
        PersonelMusteriIslemleri pmi = new PersonelMusteriIslemleri();

        private void BtnListele_Click(object sender, EventArgs e)
        {
            DgvPersoneller.DataSource = pmi.personelleriGetir();
            DgvPersoneller.Columns[0].Visible=false;
            DgvPersoneller.Columns[17].Visible = false;
            DgvPersoneller.Columns[18].Visible = false;


        }

        private void BtnYeniPersonel_Click(object sender, EventArgs e)
        {
            frmPersonel frm = new frmPersonel();
            frm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSorgula_Click(object sender, EventArgs e)
        {
            DgvPersoneller.DataSource = pmi.PersonelGetir(txtAdı.Text, txtSoyadı.Text);
        }

        private void BtnÇıkışVerme_Click(object sender, EventArgs e)
        {
            int ID = 0;

            if (int.TryParse(txtID.Text, out ID))
            {
               if( pmi.personelSil(ID))
                {
                    MessageBox.Show("Personelin İşine Son Verilmiştir!");
                }
               else
                {
                    MessageBox.Show("Personelin İşine Son Verilemedi! ");
                }
                  

            }
            else
            {
                MessageBox.Show(" Girdiğiniz ID geçersizdir.");
            }
           
        }

        private void DgvPersoneller_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtID.Text = DgvPersoneller.SelectedRows[0].Cells[0].Value.ToString();
                txtAdı.Text = DgvPersoneller.SelectedRows[0].Cells[1].Value.ToString();
                txtSoyadı.Text = DgvPersoneller.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {

                string message = ex.Message;
                MessageBox.Show("Personel Seçme İşlemi Gerçekleşmedi!!!");
            }
            

        }
    }
}


    


