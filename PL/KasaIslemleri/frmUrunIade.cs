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
    public partial class frmUrunIade : Form
    {
        public frmUrunIade()
        {
            InitializeComponent();
        }

        UrunIslemleri uislem = new UrunIslemleri();
        private void frmUrunIade_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = uislem.SatisDetaylarinHepsiniGetir();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int Sayi = 0;

            if (int.TryParse(textBox1.Text, out Sayi))
            {
                MessageBox.Show("Değer int türüne çevrildi.");
            }
            else
            {
                MessageBox.Show("Çevirme işlemi yapılamadı.");
            }
            dataGridView1.DataSource = uislem.SatisDetayGetir(Sayi);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Urun İadeEdilecekUrun = new Urun();
            İadeEdilecekUrun = uislem.urunBul(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value));
            txtUrunAdi.Text = İadeEdilecekUrun.UrunAdi;
            txtUrunId.Text = İadeEdilecekUrun.Id.ToString();
            txtAdet.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (uislem.TekKategorideIade(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value), Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value), Convert.ToInt32(txtIadeAdedi.Text)))
                {
                    MessageBox.Show("İade İşlemi Gerçekleşti", "İşlem Başarılı");
                }
                else
                {
                    MessageBox.Show("İşlem Gerçekleşemedi!!!", "İade İşlemi Esnasında Bir Hata Oluştu!!!");
                }
            }
            catch (Exception ex)
            {

                string mesaj = ex.Message;
            }
            

        }
    }
}
