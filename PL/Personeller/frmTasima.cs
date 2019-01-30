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

namespace PL.Personeller
{
    public partial class frmTasima : Form
    {
        public frmTasima()
        {
            InitializeComponent();
        }
     PersonelMusteriIslemleri mIslem = new PersonelMusteriIslemleri();
        

        private void BtnKaydet_Click(object sender, EventArgs e)
        {


            if (TxtMaskedTelefon.Text.Trim().Length >= 10 && txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "" && txtTCKNo.Text.Trim() != "" && txtEMail.Text.Trim()!="" &&txtAdres.Text.Trim()!="" && txtSehir.Text.Trim()!="")
            {
                Musteri musterı = new Musteri();
                musterı.Ad = txtAdi.Text;
                musterı.Soyad = txtSoyadi.Text;
                musterı.TCKNo = txtTCKNo.Text;
                musterı.DogumTarihi = DTimePicker.Value;
                musterı.Telefon = TxtMaskedTelefon.Text;
                musterı.EMail = txtEMail.Text;
                musterı.Adres = txtAdres.Text;
                musterı.Sehir = txtSehir.Text;
                if( mIslem.musteriEkle(musterı))
                {
                    MessageBox.Show("Musteri Ekleme İşlemi Tamamlandı.", "İşlem Başarılı.");
                }
                else
                {
                    MessageBox.Show("Musteri Ekleme İşlemi Başarısız.", "Hata!!!");
                }
            }
            else
            {
                MessageBox.Show("Telefon numarasını doğru girdiğinize emin misiniz ?", "Hatalı Veri Girişi");
            }
        }
    }
}
