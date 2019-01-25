using Crmdenemeee.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crmdenemeee
{
    public partial class Form1 : Form
    {
        int PanelWidth;
        bool hidden;

        private bool isCollapsed;
        public Form1()
        {
            InitializeComponent();
            PanelWidth = flpMenu.Width;
            hidden = false;
           
        
            
        }

  
                    
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }       

  
     

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
 
        private void timer1_Tick(object sender, EventArgs e)
        {
             btnProfile.Image = Resources.uparrow;
            if (isCollapsed)
            {
                panel3.Height += 10;
                if (panel3.Size == panel3.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {


                btnProfile.Image = Resources.downbutton;
                panel3.Height -= 10;
                if (panel3.Size == panel3.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }
       

      

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                flpMenu.Width = flpMenu.Width += 80;
                if (flpMenu.Width>=PanelWidth)
                {
                    timer2.Stop();
                    hidden = false;
                    this.Refresh();
                }


            }
            else
            {
                flpMenu.Width = flpMenu.Width -= 80;
                if (flpMenu.Width <=0)
                {
                    timer2.Stop();
                    hidden = true;
                    this.Refresh();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnBilgiler_Click(object sender, EventArgs e)
        {

        }

        private void btnGörevlerim_Click(object sender, EventArgs e)
        {

        }
    }
}
