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
            dataGridView1.DataSource = pmi.personelleriGetir();


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
            dataGridView1.DataSource = pmi.PersonelGetir(txtAdı.Text, txtSoyadı.Text);
        }
    }
}


    


