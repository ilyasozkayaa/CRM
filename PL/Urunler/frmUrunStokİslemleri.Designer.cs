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
            this.label12 = new System.Windows.Forms.Label();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.panelStok = new System.Windows.Forms.Panel();
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
            this.btnStokEkle = new System.Windows.Forms.Button();
            this.BtnSorgula = new System.Windows.Forms.Button();
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
            this.panelHeader1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelHeader1.Name = "panelHeader1";
            this.panelHeader1.Size = new System.Drawing.Size(1405, 50);
            this.panelHeader1.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(284, 39);
            this.label13.TabIndex = 0;
            this.label13.Text = "STOK BİLGİLERİ";
            // 
            // panelHeader2
            // 
            this.panelHeader2.BackColor = System.Drawing.Color.White;
            this.panelHeader2.Controls.Add(this.BtnSorgula);
            this.panelHeader2.Controls.Add(this.label12);
            this.panelHeader2.Controls.Add(this.txtUrunId);
            this.panelHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader2.Location = new System.Drawing.Point(0, 50);
            this.panelHeader2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelHeader2.Name = "panelHeader2";
            this.panelHeader2.Size = new System.Drawing.Size(1405, 98);
            this.panelHeader2.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(38, 35);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 23);
            this.label12.TabIndex = 57;
            this.label12.Text = "Ürün ID :";
            // 
            // txtUrunId
            // 
            this.txtUrunId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunId.Location = new System.Drawing.Point(179, 30);
            this.txtUrunId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUrunId.Multiline = true;
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.Size = new System.Drawing.Size(153, 43);
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
            this.panelStok.Location = new System.Drawing.Point(0, 148);
            this.panelStok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelStok.Name = "panelStok";
            this.panelStok.Size = new System.Drawing.Size(703, 464);
            this.panelStok.TabIndex = 10;
            // 
            // txtSonStok
            // 
            this.txtSonStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSonStok.Location = new System.Drawing.Point(247, 306);
            this.txtSonStok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSonStok.Multiline = true;
            this.txtSonStok.Name = "txtSonStok";
            this.txtSonStok.ReadOnly = true;
            this.txtSonStok.Size = new System.Drawing.Size(195, 41);
            this.txtSonStok.TabIndex = 58;
            // 
            // txtEklenenStok
            // 
            this.txtEklenenStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEklenenStok.Location = new System.Drawing.Point(247, 229);
            this.txtEklenenStok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEklenenStok.Multiline = true;
            this.txtEklenenStok.Name = "txtEklenenStok";
            this.txtEklenenStok.Size = new System.Drawing.Size(195, 41);
            this.txtEklenenStok.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(477, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 49;
            this.label6.Text = "Adet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(415, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 50;
            this.label5.Text = "Adet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(352, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 51;
            this.label4.Text = "Renk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(279, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "Beden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(187, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 53;
            this.label2.Text = "Ürün Adı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(38, 311);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 23);
            this.label8.TabIndex = 54;
            this.label8.Text = "Son Stok Durumu :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(38, 234);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 23);
            this.label7.TabIndex = 55;
            this.label7.Text = "Eklenen Stok :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(84, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 56;
            this.label1.Text = "Ürün ID";
            // 
            // paneldgvStok
            // 
            this.paneldgvStok.Controls.Add(this.dataGridView1);
            this.paneldgvStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldgvStok.Location = new System.Drawing.Point(703, 148);
            this.paneldgvStok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paneldgvStok.Name = "paneldgvStok";
            this.paneldgvStok.Size = new System.Drawing.Size(702, 464);
            this.paneldgvStok.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(702, 464);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnStokEkle
            // 
            this.btnStokEkle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStokEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokEkle.ForeColor = System.Drawing.Color.White;
            this.btnStokEkle.Image = global::PL.Properties.Resources.plus_5_32;
            this.btnStokEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStokEkle.Location = new System.Drawing.Point(497, 229);
            this.btnStokEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnStokEkle.Name = "btnStokEkle";
            this.btnStokEkle.Size = new System.Drawing.Size(111, 41);
            this.btnStokEkle.TabIndex = 61;
            this.btnStokEkle.Text = "       Ekle";
            this.btnStokEkle.UseVisualStyleBackColor = false;
            // 
            // BtnSorgula
            // 
            this.BtnSorgula.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnSorgula.FlatAppearance.BorderSize = 0;
            this.BtnSorgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSorgula.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSorgula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSorgula.Image = global::PL.Properties.Resources.zoom_32;
            this.BtnSorgula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSorgula.Location = new System.Drawing.Point(408, 30);
            this.BtnSorgula.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSorgula.Name = "BtnSorgula";
            this.BtnSorgula.Size = new System.Drawing.Size(153, 43);
            this.BtnSorgula.TabIndex = 61;
            this.BtnSorgula.Text = "      Sorgula";
            this.BtnSorgula.UseVisualStyleBackColor = false;
            // 
            // frmUrunStokİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 612);
            this.Controls.Add(this.paneldgvStok);
            this.Controls.Add(this.panelStok);
            this.Controls.Add(this.panelHeader2);
            this.Controls.Add(this.panelHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button BtnSorgula;
    }
}