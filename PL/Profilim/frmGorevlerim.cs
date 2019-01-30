using BLL.Model;
using DAL.Context;
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
                Gorev grv = new Gorev();
                pnlGorevKarti grvk = new pnlGorevKarti();
                grv =gh.GorevGetir(item);
                grvdtys = gh.GorevDetayGetirbyGorevId(item);                
                grvk.lblGorevAdi.Text = grv.GorevAdi;
                
               
                    foreach (GorevDetay Gorevbolum in grvdtys)
                    {
                         grvk.clbDetay.Items.Add(Gorevbolum.DetayAdi);
                         flpYapilacak.Controls.Add(grvk);
                    }
            }
            
            
   



            //if (true)
            //{
            //    pnlGorevKarti grvk = new pnlGorevKarti();
            //}
            //else
            //{

            //}
            //pnlGorevKarti p = new pnlGorevKarti();
            //pnlGorevKarti c = new pnlGorevKarti();
            //pnlGorevKarti v = new pnlGorevKarti();
            //flpYapilacak.Controls.Add(p);
            //flpYapilacak.Controls.Add(c);
            //flpYapilan.Controls.Add(v);
            

        }

     
    }
}
