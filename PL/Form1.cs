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

namespace PL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CRMContext ent = new CRMContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            ent.Database.CreateIfNotExists();
            //dgv1.DataSource = ent.Uruns.ToList();
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
