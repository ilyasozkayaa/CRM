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
        private void frmKampanyalar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ppi.promosyonlarıGetir();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[1].Width = 350;
            dataGridView1.Columns[2].Width = 220;
            dataGridView1.Columns[3].Width = 220;
            dataGridView1.Columns[4].Width = 220;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //List<Promosyon> PromosyonListesi = new List<Promosyon>();
            DateTime GununTarihi = DateTime.Now;
            MessageBox.Show(GununTarihi.ToString());
            foreach (Promosyon p in ppi.promosyonlarıGetir())
            {
                if(p.BaslangıcTarihi.Month<=GununTarihi.Month && p.BaslangıcTarihi.Day <= GununTarihi.Day && p.BitisTarihi.Month >= GununTarihi.Month && p.BitisTarihi.Day >= GununTarihi.Day)
                {
                    MessageBox.Show("Promosyon var >> " + "   " + p.PromosyonAdi);
                }
                else
                {
                    MessageBox.Show("Bu Tarihte Promosyon Yok");
                }
            }
        
        }
    }
}
