using PL.Personeller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.Personel
{
    public partial class Personeller : Form
    {
        public Personeller()
        {
            InitializeComponent();
        }

        
        private void FormAc(Form AF)
        {
            foreach (Control F in this.panel3.Controls)
            {
                if (F is Form)
                {
                    Form MF = (Form)F;
                    MF.Close();
                }
            }
            AF.TopLevel = false;
            this.panel3.Controls.Add(AF);
            AF.Dock = DockStyle.Fill;
            AF.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPersonel form = new frmPersonel();
            form.ShowDialog();
        }
    }
}
