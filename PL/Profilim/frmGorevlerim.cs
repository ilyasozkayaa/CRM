using BLL.Model;
using DAL.Context;
using PL.Properties;
using System;
using System.Collections;
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
    public partial class frmGorevlerim : Form
    {
        public frmGorevlerim()
        {
            InitializeComponent();
        }
        PersonelMusteriIslemleri pmi = new PersonelMusteriIslemleri();
        GorevHareketler gh = new GorevHareketler();
        private void frmGorevlerim_Load(object sender, EventArgs e)
        {
            ArrayList grvId = new ArrayList();
            List<GorevDetay> grvdtys = new List<GorevDetay>();
            GorevDetay gty = new GorevDetay();
            GorevKayit gk = new GorevKayit();
            
            grvId = gh.GorevIdArrayGetir(GenelDegiskenler.PersonId);
            foreach (int item in grvId)
            {
                CircularPictureBox cpbx = new CircularPictureBox();
                Gorev grv = new Gorev();
                pnlGorevKarti grvk = new pnlGorevKarti();
                grv =gh.GorevGetir(item);
                grvdtys = gh.GorevDetayGetirbyGorevId(item);                
                grvk.lblGorevAdi.Text = grv.GorevAdi;
                grvk.lblBaslangic.Text = grv.BaslangicTarihi.ToShortDateString();
                grvk.lblBitis.Text = grv.BitisTarihi.ToShortDateString();

                //cpbx.Image = Resources.icons8_businessman_48;
                //cpbx.Dock = DockStyle.Left;
                //grvk.pnlMembers.Controls.Add(cpbx);
                  

                foreach (GorevDetay Gorevbolum in grvdtys)
                    { 
                         grvk.clbDetay.Items.Add(Gorevbolum.DetayAdi);
                    if (grv.Tamamlandi)
                    {
                        flpBitmis.Controls.Add(grvk);
                    }
                    else
                    {
                        if (grv.BaslangicTarihi>DateTime.Today)
                        {
                            flpYapilacak.Controls.Add(grvk);
                        }
                        else
                        {
                            flpYapilan.Controls.Add(grvk);
                        }
                    }
                         
                    }
            }

        }

     
    }
}
