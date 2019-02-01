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

namespace PL.Urunler
{
    public partial class frmUrunStokİslemleri : Form
    {
        public frmUrunStokİslemleri()
        {
            InitializeComponent();
        }
        UrunIslemleri Uislem = new UrunIslemleri();
        Genel gnl = new Genel();
        int IslemYapılacakUrunID = 0;
        private void BtnSorgula_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtUrunId.Text, out IslemYapılacakUrunID))
            {
                Urun u = Uislem.urunBul(IslemYapılacakUrunID);
                lblID.Text = txtUrunId.Text;
                lblAdet.Text = u.StokMiktarı.ToString();
                lblBeden.Text = u.Beden;
                lblAD.Text = u.UrunAdi;
                lblRenk.Text = u.Renk;
            }
            else
            {
                MessageBox.Show("Ürün Kodunu Doğru Girdiğinize Emin misiniz?","Hata!!!");
            }
        }

        private void btnStokEkle_Click(object sender, EventArgs e)
        {
            
        }


        private void frmUrunStokİslemleri_Load(object sender, EventArgs e)
        {
            dgvUrunler.DataSource = Uislem.TumUrunleriGetir();
            dgvUrunler.Columns[0].Visible = false;
            dgvUrunler.Columns[1].Visible = false;
            dgvUrunler.Columns[12].Visible = false;
        }

        private void dgvUrunler_DoubleClick(object sender, EventArgs e)
        {
            IslemYapılacakUrunID = Convert.ToInt32(dgvUrunler.SelectedRows[0].Cells[0].Value);
            lblID.Text = dgvUrunler.SelectedRows[0].Cells[0].Value.ToString();
            lblAD.Text = dgvUrunler.SelectedRows[0].Cells[2].Value.ToString();
            lblBeden.Text = dgvUrunler.SelectedRows[0].Cells[4].Value.ToString();
            lblRenk.Text = dgvUrunler.SelectedRows[0].Cells[6].Value.ToString();
            lblAdet.Text = dgvUrunler.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void btnStokEkle_Click_1(object sender, EventArgs e)
        {
            int Miktar = 0;

            if (int.TryParse(txtEklenenStok.Text, out Miktar))
            {
                if (Uislem.StokEkle(IslemYapılacakUrunID, Miktar))
                {
                    MessageBox.Show("Stok Ekleme İşlemi Tamamlandı", "İşlem Başarılı");
                    dgvUrunler.DataSource = Uislem.TumUrunleriGetir();
                    txtSonStok.Text = Uislem.urunBul(IslemYapılacakUrunID).StokMiktarı.ToString();
                    gnl.Temizle(panel1);
                }
                else
                {
                    MessageBox.Show("Stok Arttırma İşlemi  Başarısız.", "Hata!!!");
                }
            }
            else
            {
                MessageBox.Show("Eklenecek Stok Adedini Sayısal Değer Girmelisiniz!", "Hata!!!");
            }
        }

        private void txtEklenenStok_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
