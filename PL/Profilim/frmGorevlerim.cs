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
    public partial class frmGorevlerim : Form
    {
        public frmGorevlerim()
        {
            InitializeComponent();
        }

        private void frmGorevlerim_Load(object sender, EventArgs e)
        {
            pnlGorevKarti p = new pnlGorevKarti();
            pnlGorevKarti c = new pnlGorevKarti();
            pnlGorevKarti v = new pnlGorevKarti();
            flpYapilacak.Controls.Add(p);
            flpYapilacak.Controls.Add(c);
            flpYapilan.Controls.Add(v);
            

        }

     
    }
}
