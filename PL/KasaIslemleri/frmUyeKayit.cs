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
    public partial class frmUyeKayit : Form
    {
        public frmUyeKayit()
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

        private void txtAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtSoyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtSehir_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtTCKNo_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

      
    }
}





//string tckimlik;
//                try
//                {
//                    tckimlik = txtTCKNo.Text;
//                    int index = 0;
//int toplam = 0;
//                    foreach (char n in tckimlik)
//                    {
//                        if (index< 10)
//                        {
//                            toplam += Convert.ToInt32(char.ToString(n));
//                        }
//                        index++;
//                    }
//                    if (toplam % 10 == Convert.ToInt32(tckimlik[10].ToString()))
//                    {
//                        MessageBox.Show("Geçerli TC Kimlik Numarası");
//                    }
//                    else
//                    {
//                        MessageBox.Show("Geçersiz Tc Kimlik Numarası");
//                    }
//                }
//                catch
//                {
//                    MessageBox.Show("Girdiğiniz Tc kimlik numarası 11 haneli değil");
//                }