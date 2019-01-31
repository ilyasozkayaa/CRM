using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Model;
using System.Collections;

namespace PL
{
    public partial class pnlGorevKarti : UserControl
    {
        public pnlGorevKarti()
        {
            InitializeComponent();
            this.Size = MinimumSize;







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


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}

