using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class pnlGorevKarti : UserControl
    {
        public pnlGorevKarti()
        {
            InitializeComponent();
            this.Size = MinimumSize;
            
           
                int a = clbGorevİcerik.SelectedItems.Count / clbGorevİcerik.Items.Count;
                progressBar1.Value = a * 100;
                lblYuzde.Text = "%" + progressBar1.Value.ToString();    


        }
        private bool isCollapsed;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                this.Height += 10;
                if (this.Size == this.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {

                this.Height -= 10;
                if (this.Size == this.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void pnlheader_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Start();
        }
        
        private void clbGorevİcerik_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            double a = clbGorevİcerik.CheckedItems.Count/ clbGorevİcerik.Items.Count;
            progressBar1.Value = (int)a * 100;
            lblYuzde.Text = "%" + progressBar1.Value.ToString();
        }
    }
}
