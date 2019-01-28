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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbIadeSebepleri = new System.Windows.Forms.ComboBox();
            this.txtIadeAdedi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 43);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÜRÜN İADE İŞLEMLERİ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(644, 185);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "SATIŞ ID :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(465, 286);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "İPTAL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "ÜRÜN ADI :";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(169, 214);
            this.txtUrunAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.ReadOnly = true;
            this.txtUrunAdi.Size = new System.Drawing.Size(91, 22);
            this.txtUrunAdi.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "ÜRÜN ID :";
            // 
            // txtUrunId
            // 
            this.txtUrunId.Location = new System.Drawing.Point(169, 249);
            this.txtUrunId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.ReadOnly = true;
            this.txtUrunId.Size = new System.Drawing.Size(91, 22);
            this.txtUrunId.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "İADE SEBEBİ :";
            // 
            // cbIadeSebepleri
            // 
            this.cbIadeSebepleri.FormattingEnabled = true;
            this.cbIadeSebepleri.Items.AddRange(new object[] {
            "BEDEN",
            "DEFO",
            "KALİTE",
            "RENK",
            "İŞLEVSELLİK",
            "DİĞER"});
            this.cbIadeSebepleri.Location = new System.Drawing.Point(465, 213);
            this.cbIadeSebepleri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbIadeSebepleri.Name = "cbIadeSebepleri";
            this.cbIadeSebepleri.Size = new System.Drawing.Size(91, 24);
            this.cbIadeSebepleri.TabIndex = 8;
            this.cbIadeSebepleri.Text = "SEÇİNİZ...";
            // 
            // txtIadeAdedi
            // 
            this.txtIadeAdedi.Location = new System.Drawing.Point(465, 245);
            this.txtIadeAdedi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIadeAdedi.Name = "txtIadeAdedi";
            this.txtIadeAdedi.Size = new System.Drawing.Size(91, 22);
            this.txtIadeAdedi.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 249);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "İADE ADEDİ :";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(169, 283);
            this.txtAdet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.ReadOnly = true;
            this.txtAdet.Size = new System.Drawing.Size(91, 22);
            this.txtAdet.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 286);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "ADET :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 68);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 111);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 458);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(884, 111);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 458);
            this.panel4.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.txtUrunAdi);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtUrunId);
            this.panel5.Controls.Add(this.txtAdet);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.txtIadeAdedi);
            this.panel5.Controls.Add(this.cbIadeSebepleri);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(240, 111);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(644, 458);
            this.panel5.TabIndex = 14;
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUrunIade";
            this.Text = "frmUrunIade";
            this.Load += new System.EventHandler(this.frmUrunIade_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUrunId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbIadeSebepleri;
        private System.Windows.Forms.TextBox txtIadeAdedi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}