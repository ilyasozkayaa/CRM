﻿using BLL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.Profilim
{
    public partial class frmBilgilerim : Form
    {
        public frmBilgilerim()
        {
            InitializeComponent();
        }

        Degiskentanimla deg = new Degiskentanimla();
        private void frmBilgilerim_Load(object sender, EventArgs e)
        {
            PersonelMusteriIslemleri per = new PersonelMusteriIslemleri();
            per.PersonelGetir(deg.Id);
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void circularPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

       

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
