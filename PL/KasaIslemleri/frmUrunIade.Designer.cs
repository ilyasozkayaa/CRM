namespace PL.KasaIslemleri
{
    partial class frmUrunIade
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSatisDetaylar = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSatısID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbIade = new System.Windows.Forms.ComboBox();
            this.txtİadeAdet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatisDetaylar)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 43);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(735, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "                                                 ÜRÜN İADE İŞLEMLERİ";
            // 
            // dgvSatisDetaylar
            // 
            this.dgvSatisDetaylar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatisDetaylar.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvSatisDetaylar.Location = new System.Drawing.Point(0, 0);
            this.dgvSatisDetaylar.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSatisDetaylar.MultiSelect = false;
            this.dgvSatisDetaylar.Name = "dgvSatisDetaylar";
            this.dgvSatisDetaylar.ReadOnly = true;
            this.dgvSatisDetaylar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSatisDetaylar.Size = new System.Drawing.Size(644, 185);
            this.dgvSatisDetaylar.TabIndex = 1;
            this.dgvSatisDetaylar.DoubleClick += new System.EventHandler(this.dgvSatisDetaylar_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "SATIŞ ID :";
            // 
            // txtSatısID
            // 
            this.txtSatısID.Location = new System.Drawing.Point(109, 27);
            this.txtSatısID.Margin = new System.Windows.Forms.Padding(4);
            this.txtSatısID.Name = "txtSatısID";
            this.txtSatısID.Size = new System.Drawing.Size(107, 22);
            this.txtSatısID.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtSatısID, "Boş Bırakmayınız !");
            this.txtSatısID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtSatısID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSatısID_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(36, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "ÜRÜN ADI :";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(169, 214);
            this.txtUrunAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.ReadOnly = true;
            this.txtUrunAd.Size = new System.Drawing.Size(91, 22);
            this.txtUrunAd.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(36, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "ÜRÜN ID :";
            // 
            // txtUrunId
            // 
            this.txtUrunId.Location = new System.Drawing.Point(169, 249);
            this.txtUrunId.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.ReadOnly = true;
            this.txtUrunId.Size = new System.Drawing.Size(91, 22);
            this.txtUrunId.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(332, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "İADE SEBEBİ :";
            // 
            // cbIade
            // 
            this.cbIade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIade.FormattingEnabled = true;
            this.cbIade.Items.AddRange(new object[] {
            "BEDEN",
            "DEFO",
            "KALİTE",
            "RENK",
            "İŞLEVSELLİK",
            "DİĞER"});
            this.cbIade.Location = new System.Drawing.Point(465, 213);
            this.cbIade.Margin = new System.Windows.Forms.Padding(4);
            this.cbIade.Name = "cbIade";
            this.cbIade.Size = new System.Drawing.Size(91, 24);
            this.cbIade.TabIndex = 8;
            // 
            // txtİadeAdet
            // 
            this.txtİadeAdet.Location = new System.Drawing.Point(465, 245);
            this.txtİadeAdet.Margin = new System.Windows.Forms.Padding(4);
            this.txtİadeAdet.Name = "txtİadeAdet";
            this.txtİadeAdet.Size = new System.Drawing.Size(91, 22);
            this.txtİadeAdet.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtİadeAdet, "Boş Bırakmayınız !");
            this.txtİadeAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtİadeAdet_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(332, 249);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "İADE ADEDİ :";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(169, 283);
            this.txtAdet.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.ReadOnly = true;
            this.txtAdet.Size = new System.Drawing.Size(91, 22);
            this.txtAdet.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(36, 286);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "ADET :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtSatısID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 68);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 111);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 458);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(884, 111);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 458);
            this.panel4.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvSatisDetaylar);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.txtUrunAd);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtUrunId);
            this.panel5.Controls.Add(this.txtAdet);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.txtİadeAdet);
            this.panel5.Controls.Add(this.cbIade);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(240, 111);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(644, 458);
            this.panel5.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::PL.Properties.Resources.icons8_minus_321;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(465, 286);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "            İPTAL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 50;
            this.toolTip1.AutoPopDelay = 1000;
            this.toolTip1.InitialDelay = 50;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 10;
            // 
            // frmUrunIade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 569);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUrunIade";
            this.Text = "frmUrunIade";
            this.Load += new System.EventHandler(this.frmUrunIade_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatisDetaylar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSatisDetaylar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSatısID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUrunId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbIade;
        private System.Windows.Forms.TextBox txtİadeAdet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}