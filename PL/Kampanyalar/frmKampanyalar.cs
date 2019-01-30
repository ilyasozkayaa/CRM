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

namespace PL.Kampanyalar
{
    public partial class frmKampanyalar : Form
    {
        public frmKampanyalar()
        {
            InitializeComponent();
        }
        CRMContext ent = new CRMContext();
        PromosyonPrimIslemleri ppi = new PromosyonPrimIslemleri();

        int prmID = 0;

        private void frmKampanyalar_Load(object sender, EventArgs e)
        {
            dgvpromosyonlar.DataSource = ppi.promosyonlarıGetir();
            dgvpromosyonlar.Columns[0].Visible = false;
            dgvpromosyonlar.Columns[5].Visible = false;
            dgvpromosyonlar.Columns[1].Width = 350;
            dgvpromosyonlar.Columns[2].Width = 220;
            dgvpromosyonlar.Columns[3].Width = 220;
            dgvpromosyonlar.Columns[4].Width = 220;
        }

        private void btnPromosyonEkle_Click(object sender, EventArgs e)
        {
          
                if (txtPromosyonAdi.Text.Trim() != "" && txtPromosyonOranı.Text.Trim() != "")
            {
                if (ppi.PromosyonEkleKontrol(txtPromosyonAdi.Text))
                {
                    MessageBox.Show("Bu Promosyon Zaten Var.", "İşlem Yapılmadı.");
                }
                else
                {
                    Promosyon Yeniprm = new Promosyon();
                    Yeniprm.PromosyonAdi = txtPromosyonAdi.Text;
                   // Yeniprm.PromosyonOrani = txtPromosyonOranı.Text;

                    if (ppi.promosyonEkle(Yeniprm))
                    {
                        MessageBox.Show("Kayıt İşlemi Tamamlandı.", "Kayıt Başarılı");
                        dgvpromosyonlar.DataSource = ppi.promosyonlarıGetir();

                    }
                    else
                    {
                        MessageBox.Show("Kayıt İşlemi Tamamlanamadı!!!", "Kayıt Başarısız");
                    }
                }

            }
            else
            {
                MessageBox.Show("Gerekli Alanları Doldurunuz!!!");
            }
        }

        private void btnPromosyonSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Bilgileri Silinmek Üzere!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ppi.promosyonSil(Convert.ToInt32(prmID)))
                {
                    MessageBox.Show("Promosyon Silindi.", "Silme İşlemi Başarılı.");
                    dgvpromosyonlar.DataSource = ppi.promosyonlarıGetir();
                }
                else
                {
                    MessageBox.Show("Promosyon Silme İşlemi Başarısız", "Hata!!!");
                }
            }
        }

        private void btnPromosyonGuncelle_Click(object sender, EventArgs e)
        {
            if (txtPromosyonAdi.Text.Trim() != "" && txtPromosyonOranı.Text.Trim() != "")
            {
                if (ppi.PromosyonGuncelleKontrol(prmID, txtPromosyonAdi.Text))
                {
                    MessageBox.Show("Bu İsimde Bir Promosyon Zaten Var.", "İşlem Gerçekleşmedi.");
                }
                else
                {
                    Promosyon DegisecekPRM = new Promosyon();
                    DegisecekPRM.PromosyonAdi = txtPromosyonAdi.Text;
                   // DegisecekPRM.PromosyonOrani = txtPromosyonOranı.Text;
                    DegisecekPRM.Id = prmID;
                    if (ppi.promosyonGuncelle(DegisecekPRM))
                    {
                        MessageBox.Show("Promosyon Güncellendi.", "İşlem Başarılı.");
                        dgvpromosyonlar.DataSource = ppi.promosyonlarıGetir();
                    }
                    else
                    {
                        MessageBox.Show("Promosyon Güncellenemedi", "İşlem Başarısız");
                    }
                }


            }
            else
            {
                MessageBox.Show("Gerekli Alanları Doldurunuz.", "İşlem Gerçekleşmedi.");
            }
        }

        private void dgvpromosyonlar_DoubleClick(object sender, EventArgs e)
        {
            prmID = Convert.ToInt32(dgvpromosyonlar.SelectedRows[0].Cells[0].Value);
            txtPromosyonAdi.Text = dgvpromosyonlar.SelectedRows[0].Cells[1].Value.ToString();
            txtPromosyonOranı.Text = dgvpromosyonlar.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<Promosyon> GununPromosyonu = ppi.AktifPromosyonlar(DateTime.Now);

                foreach (Promosyon  p in GununPromosyonu)
            {
                MessageBox.Show("Günün Promosyonu >>" + " " + p.PromosyonAdi + " " +" Oranı = " +  p.PromosyonOrani);
            }
        }
    }
}
