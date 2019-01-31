namespace PL
{
    partial class frmUyeMusteri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlMusteri = new System.Windows.Forms.Panel();
            this.lblMusteriNo = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAD = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dgvSatis = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAraToplam = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.lblKDV = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblIndirimMiktari = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSatis = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCikart = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlMusteri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatis)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "ÜRÜN ID :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(81, 37);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlHeader.Controls.Add(this.pnlMusteri);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1124, 84);
            this.pnlHeader.TabIndex = 5;
            // 
            // pnlMusteri
            // 
            this.pnlMusteri.Controls.Add(this.lblMusteriNo);
            this.pnlMusteri.Controls.Add(this.lblSoyad);
            this.pnlMusteri.Controls.Add(this.lblAD);
            this.pnlMusteri.Controls.Add(this.label16);
            this.pnlMusteri.Controls.Add(this.label17);
            this.pnlMusteri.Controls.Add(this.label18);
            this.pnlMusteri.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMusteri.Location = new System.Drawing.Point(0, 0);
            this.pnlMusteri.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMusteri.Name = "pnlMusteri";
            this.pnlMusteri.Size = new System.Drawing.Size(267, 84);
            this.pnlMusteri.TabIndex = 5;
            // 
            // lblMusteriNo
            // 
            this.lblMusteriNo.AutoSize = true;
            this.lblMusteriNo.Location = new System.Drawing.Point(118, 55);
            this.lblMusteriNo.Name = "lblMusteriNo";
            this.lblMusteriNo.Size = new System.Drawing.Size(46, 17);
            this.lblMusteriNo.TabIndex = 8;
            this.lblMusteriNo.Text = "label3";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(85, 28);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(46, 17);
            this.lblSoyad.TabIndex = 7;
            this.lblSoyad.Text = "label2";
            // 
            // lblAD
            // 
            this.lblAD.AutoSize = true;
            this.lblAD.Location = new System.Drawing.Point(53, 4);
            this.lblAD.Name = "lblAD";
            this.lblAD.Size = new System.Drawing.Size(46, 17);
            this.lblAD.TabIndex = 6;
            this.lblAD.Text = "label1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(1, 55);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "MÜŞTERİ NO :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(4, 1);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 17);
            this.label17.TabIndex = 3;
            this.label17.Text = "ADI :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(4, 28);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 17);
            this.label18.TabIndex = 4;
            this.label18.Text = "SOYADI :";
            // 
            // dgvSatis
            // 
            this.dgvSatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatis.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvSatis.Location = new System.Drawing.Point(0, 0);
            this.dgvSatis.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSatis.MultiSelect = false;
            this.dgvSatis.Name = "dgvSatis";
            this.dgvSatis.ReadOnly = true;
            this.dgvSatis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSatis.Size = new System.Drawing.Size(638, 174);
            this.dgvSatis.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(379, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "ARA TOPLAM :";
            // 
            // lblAraToplam
            // 
            this.lblAraToplam.AutoSize = true;
            this.lblAraToplam.Location = new System.Drawing.Point(535, 185);
            this.lblAraToplam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAraToplam.Name = "lblAraToplam";
            this.lblAraToplam.Size = new System.Drawing.Size(0, 17);
            this.lblAraToplam.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(379, 212);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "KDV :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(379, 239);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "TOPLAM :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.Location = new System.Drawing.Point(535, 293);
            this.lblGenelToplam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(0, 17);
            this.lblGenelToplam.TabIndex = 9;
            // 
            // lblKDV
            // 
            this.lblKDV.AutoSize = true;
            this.lblKDV.Location = new System.Drawing.Point(535, 213);
            this.lblKDV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKDV.Name = "lblKDV";
            this.lblKDV.Size = new System.Drawing.Size(36, 17);
            this.lblKDV.TabIndex = 9;
            this.lblKDV.Text = "%18";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-335, 258);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "KAMPANYA KODU :";
            this.label11.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(535, 244);
            this.lblToplam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(0, 17);
            this.lblToplam.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(379, 293);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "GENEL TOPLAM :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(379, 266);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 17);
            this.label14.TabIndex = 11;
            this.label14.Text = "İNDİRİM :";
            // 
            // lblIndirimMiktari
            // 
            this.lblIndirimMiktari.AutoSize = true;
            this.lblIndirimMiktari.Location = new System.Drawing.Point(535, 270);
            this.lblIndirimMiktari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndirimMiktari.Name = "lblIndirimMiktari";
            this.lblIndirimMiktari.Size = new System.Drawing.Size(0, 17);
            this.lblIndirimMiktari.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtAdet);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 74);
            this.panel2.TabIndex = 12;
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(384, 27);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(100, 22);
            this.txtAdet.TabIndex = 86;
            this.txtAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdet_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 85;
            this.label1.Text = "ADET";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::PL.Properties.Resources.plus_5_321;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(727, 20);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 46);
            this.button3.TabIndex = 84;
            this.button3.Text = "          EKLE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 158);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 411);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCikart);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(857, 158);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 411);
            this.panel4.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.comboBox1);
            this.panel5.Controls.Add(this.btnSatis);
            this.panel5.Controls.Add(this.dgvSatis);
            this.panel5.Controls.Add(this.lblKDV);
            this.panel5.Controls.Add(this.lblToplam);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.lblAraToplam);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.lblIndirimMiktari);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.lblGenelToplam);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(219, 158);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(638, 411);
            this.panel5.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 205);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 84;
            // 
            // btnSatis
            // 
            this.btnSatis.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSatis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatis.ForeColor = System.Drawing.Color.White;
            this.btnSatis.Image = global::PL.Properties.Resources.plus_5_321;
            this.btnSatis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSatis.Location = new System.Drawing.Point(437, 345);
            this.btnSatis.Margin = new System.Windows.Forms.Padding(4);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(130, 46);
            this.btnSatis.TabIndex = 83;
            this.btnSatis.Text = "        Satiş";
            this.btnSatis.UseVisualStyleBackColor = false;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::PL.Properties.Resources.icons8_christmas_gift_filled_32;
            this.button2.Location = new System.Drawing.Point(102, 253);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 57);
            this.button2.TabIndex = 7;
            this.button2.Text = "  KULLAN";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnCikart
            // 
            this.btnCikart.Location = new System.Drawing.Point(19, 61);
            this.btnCikart.Name = "btnCikart";
            this.btnCikart.Size = new System.Drawing.Size(104, 54);
            this.btnCikart.TabIndex = 9;
            this.btnCikart.Text = "Çıkart";
            this.btnCikart.UseVisualStyleBackColor = true;
            this.btnCikart.Click += new System.EventHandler(this.btnCikart_Click);
            // 
            // frmUyeMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 569);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUyeMusteri";
            this.Text = "frmUyeMusteri";
            this.Load += new System.EventHandler(this.frmUyeMusteri_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlMusteri.ResumeLayout(false);
            this.pnlMusteri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatis)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.DataGridView dgvSatis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAraToplam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.Label lblKDV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblIndirimMiktari;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.Panel pnlMusteri;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblMusteriNo;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAD;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCikart;
    }
}