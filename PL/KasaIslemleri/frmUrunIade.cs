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
        UrunIslemleri Uislem = new UrunIslemleri();
        private void frmUrunIade_Load(object sender, EventArgs e)
        {
            cbIade.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<SatisDetay> sd = new List<SatisDetay>();
            if (textBox1.Text.Trim() != "")
            {
                sd = Uislem.SatısDetaylariniGetir(Convert.ToInt32(textBox1.Text));
                if (sd != null)
                {
                    dgvSatisDetaylar.DataSource = sd;
                }
            }
        }
        Urun IadeEdilenUrun = new Urun();

        private void dgvSatisDetaylar_DoubleClick(object sender, EventArgs e)
        {
            IadeEdilenUrun = Uislem.urunBul(Convert.ToInt32(dgvSatisDetaylar.SelectedRows[0].Cells[2].Value));
            txtUrunId.Text = dgvSatisDetaylar.SelectedRows[0].Cells[3].Value.ToString();
            txtAdet.Text = dgvSatisDetaylar.SelectedRows[0].Cells[3].Value.ToString();
            txtUrunAd.Text = IadeEdilenUrun.UrunAdi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int IadeAdet = 0;

            if (int.TryParse(txtİadeAdet.Text, out IadeAdet))
            {
                if (txtİadeAdet.Text.Trim() != "" && Convert.ToInt32(txtAdet.Text) >= IadeAdet)
                {
                    // Uislem.StokEkle(IadeEdilenUrun.Id, IadeAdet);
                    if (Uislem.TekKategorideIade(Convert.ToInt32(dgvSatisDetaylar.SelectedRows[0].Cells[0].Value), IadeEdilenUrun.Id, IadeAdet))
                    {
                        UrunIade iade = new UrunIade();
                        iade.IadeAdedi = IadeAdet;
                        iade.IadeSebebi = cbIade.SelectedItem.ToString();
                        iade.IadeTarihi = DateTime.Now;
                        iade.SatisId = Convert.ToInt32(textBox1.Text);
                        iade.UrunID = IadeEdilenUrun.Id;
                        iade.Ucret = (Convert.ToDecimal(dgvSatisDetaylar.SelectedRows[0].Cells[4].Value)/Convert.ToDecimal(dgvSatisDetaylar.SelectedRows[0].Cells[3].Value))*IadeAdet;
                        Uislem.UrunIadeHareket(iade);
                        MessageBox.Show("İade İşlemi Gerçekleşti, Müşterimize "+iade.Ucret+" TL İade Ediniz!!!", "İşlem Başarılı");
                        dgvSatisDetaylar.DataSource = Uislem.SatısDetaylariniGetir(Convert.ToInt32(textBox1.Text));
                    }
                }
                else
                {
                    MessageBox.Show("Satın Alınandan Fazlasını İade Edemezsiniz!!!", "Hatalı İşlme.");
                }


            }
            else
            {
                MessageBox.Show("Iade Adedi İçin Sayısal Değer Giriniz!", "Hatalı Veri Girişi.");
            }

        }
    }
}
