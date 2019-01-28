namespace PL.Urunler
{
    partial class frmUrunStokİslemleri
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
            this.panelHeader1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panelHeader2 = new System.Windows.Forms.Panel();
            this.btnUrunAra = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.panelStok = new System.Windows.Forms.Panel();
            this.btnStokEkle = new System.Windows.Forms.Button();
            this.txtSonStok = new System.Windows.Forms.TextBox();
            this.txtEklenenStok = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paneldgvStok = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelHeader1.SuspendLayout();
            this.panelHeader2.SuspendLayout();
            this.panelStok.SuspendLayout();
            this.paneldgvStok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader1
            // 
            this.panelHeader1.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader1.Controls.Add(this.label13);
            this.panelHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader1.Location = new System.Drawing.Point(0, 0);
            this.panelHeader1.Name = "panelHeader1";
            this.panelHeader1.Size = new System.Drawing.Size(1054, 41);
            this.panelHeader1.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(226, 31);
            this.label13.TabIndex = 0;
            this.label13.Text = "STOK BİLGİLERİ";
            // 
            // panelHeader2
            // 
            this.panelHeader2.BackColor = System.Drawing.Color.White;
            this.panelHeader2.Controls.Add(this.btnUrunAra);
            this.panelHeader2.Controls.Add(this.label12);
            this.panelHeader2.Controls.Add(this.txtUrunId);
            this.panelHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader2.Location = new System.Drawing.Point(0, 41);
            this.panelHeader2.Name = "panelHeader2";
            this.panelHeader2.Size = new System.Drawing.Size(1054, 80);
            this.panelHeader2.TabIndex = 9;
            // 
            // btnUrunAra
            // 
            this.btnUrunAra.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUrunAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunAra.ForeColor = System.Drawing.Color.White;
            this.btnUrunAra.Location = new System.Drawing.Point(268, 20);
            this.btnUrunAra.Name = "btnUrunAra";
            this.btnUrunAra.Size = new System.Drawing.Size(78, 26);
            this.btnUrunAra.TabIndex = 62;
            this.btnUrunAra.Text = "ARA";
            this.btnUrunAra.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(21, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 20);
            this.label12.TabIndex = 57;
            this.label12.Text = "Ürün ID";
            // 
            // txtUrunId
            // 
            this.txtUrunId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunId.Location = new System.Drawing.Point(106, 20);
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.Size = new System.Drawing.Size(156, 26);
            this.txtUrunId.TabIndex = 60;
            // 
            // panelStok
            // 
            this.panelStok.Controls.Add(this.btnStokEkle);
            this.panelStok.Controls.Add(this.txtSonStok);
            this.panelStok.Controls.Add(this.txtEklenenStok);
            this.panelStok.Controls.Add(this.label6);
            this.panelStok.Controls.Add(this.label5);
            this.panelStok.Controls.Add(this.label4);
            this.panelStok.Controls.Add(this.label3);
            this.panelStok.Controls.Add(this.label2);
            this.panelStok.Controls.Add(this.label8);
            this.panelStok.Controls.Add(this.label7);
            this.panelStok.Controls.Add(this.label1);
            this.panelStok.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStok.Location = new System.Drawing.Point(0, 121);
            this.panelStok.Name = "panelStok";
            this.panelStok.Size = new System.Drawing.Size(527, 376);
            this.panelStok.TabIndex = 10;
            // 
            // btnStokEkle
            // 
            this.btnStokEkle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStokEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokEkle.ForeColor = System.Drawing.Color.White;
            this.btnStokEkle.Location = new System.Drawing.Point(362, 191);
            this.btnStokEkle.Name = "btnStokEkle";
            this.btnStokEkle.Size = new System.Drawing.Size(80, 26);
            this.btnStokEkle.TabIndex = 61;
            this.btnStokEkle.Text = "EKLE";
            this.btnStokEkle.UseVisualStyleBackColor = false;
            // 
            // txtSonStok
            // 
            this.txtSonStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSonStok.Location = new System.Drawing.Point(213, 229);
            this.txtSonStok.Name = "txtSonStok";
            this.txtSonStok.ReadOnly = true;
            this.txtSonStok.Size = new System.Drawing.Size(145, 26);
            this.txtSonStok.TabIndex = 58;
            // 
            // txtEklenenStok
            // 
            this.txtEklenenStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEklenenStok.Location = new System.Drawing.Point(213, 191);
            this.txtEklenenStok.Name = "txtEklenenStok";
            this.txtEklenenStok.Size = new System.Drawing.Size(145, 26);
            this.txtEklenenStok.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(358, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Adet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(311, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Adet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(264, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Renk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(209, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Beden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(140, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Ürün Adı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(63, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 54;
            this.label8.Text = "Son Stok Durumu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(63, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 55;
            this.label7.Text = "Eklenen Stok";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(63, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "Ürün ID";
            // 
            // paneldgvStok
            // 
            this.paneldgvStok.Controls.Add(this.dataGridView1);
            this.paneldgvStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldgvStok.Location = new System.Drawing.Point(527, 121);
            this.paneldgvStok.Name = "paneldgvStok";
            this.paneldgvStok.Size = new System.Drawing.Size(527, 376);
            this.paneldgvStok.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(527, 376);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmUrunStokİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 497);
            this.Controls.Add(this.paneldgvStok);
            this.Controls.Add(this.panelStok);
            this.Controls.Add(this.panelHeader2);
            this.Controls.Add(this.panelHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUrunStokİslemleri";
            this.Text = "frmUrunStokİslemleri";
            this.panelHeader1.ResumeLayout(false);
            this.panelHeader1.PerformLayout();
            this.panelHeader2.ResumeLayout(false);
            this.panelHeader2.PerformLayout();
            this.panelStok.ResumeLayout(false);
            this.panelStok.PerformLayout();
            this.paneldgvStok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panelHeader2;
        private System.Windows.Forms.Panel panelStok;
        private System.Windows.Forms.Panel paneldgvStok;
        private System.Windows.Forms.Button btnStokEkle;
        private System.Windows.Forms.Button btnUrunAra;
        private System.Windows.Forms.TextBox txtSonStok;
        private System.Windows.Forms.TextBox txtEklenenStok;
        private System.Windows.Forms.TextBox txtUrunId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}