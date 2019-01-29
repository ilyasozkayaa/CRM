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
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            if (dt==DateTime.Now)
               
                {
                MessageBox.Show("Anneler Günü İndirimi");
                }
          else 
            {
                MessageBox.Show("Yeni İndirim Bulunmamaktadır.");
            }
        }
    }
}
