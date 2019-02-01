﻿using BLL.Model;
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
            if (txtSatısID.Text.Trim() != "")
            {
                sd = Uislem.SatısDetaylariniGetir(Convert.ToInt32(txtSatısID.Text));
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
            txtUrunId.Text = dgvSatisDetaylar.SelectedRows[0].Cells[2].Value.ToString();
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
                    decimal para = Convert.ToDecimal(dgvSatisDetaylar.SelectedRows[0].Cells[4].Value);
                    int Satisadet = Convert.ToInt32(dgvSatisDetaylar.SelectedRows[0].Cells[3].Value);
                    decimal ıadeUcret = (para / Satisadet) * IadeAdet;
                    if (Uislem.TekKategorideIade(Convert.ToInt32(dgvSatisDetaylar.SelectedRows[0].Cells[0].Value), IadeEdilenUrun.Id, IadeAdet))
                    {
                        UrunIade iade = new UrunIade();
                        iade.IadeAdedi = IadeAdet;
                        iade.IadeSebebi = cbIade.SelectedItem.ToString();
                        iade.IadeTarihi = DateTime.Now;
                        iade.SatisId = Convert.ToInt32(txtSatısID.Text);
                        iade.UrunID = IadeEdilenUrun.Id;
                        iade.Ucret = ıadeUcret;
                        Uislem.UrunIadeHareket(iade);
                        dgvSatisDetaylar.DataSource = Uislem.SatısDetaylariniGetir(Convert.ToInt32(txtSatısID.Text));
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

        private void txtSatısID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); //sadece rakam girişi
        }

        private void txtİadeAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


      


    }
}
