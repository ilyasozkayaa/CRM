using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.Personeller
{
    public partial class frmPersonel : Form
    {
        public frmPersonel()
        {
            InitializeComponent();
        }
        string dosyayolu;
        Bitmap bmp;
    
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            dosyayolu = openFileDialog1.FileName;
            bmp = new Bitmap(dosyayolu);
            pictureBox1.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.jpg)|*.jpg";
            saveFileDialog1.ShowDialog();
            bmp.Save(saveFileDialog1.FileName);
        }
    }
}
