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
            this.BtnSorgula = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.panelStok = new System.Windows.Forms.Panel();
            this.paneldgvStok = new System.Windows.Forms.Panel();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAD = new System.Windows.Forms.Label();
            this.lblBeden = new System.Windows.Forms.Label();
            this.lblRenk = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAdet = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEklenenStok = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSonStok = new System.Windows.Forms.TextBox();
            this.btnStokEkle = new System.Windows.Forms.Button();
            this.panelHeader1.SuspendLayout();
            this.panelHeader2.SuspendLayout();
            this.panelStok.SuspendLayout();
            this.paneldgvStok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader1
            // 
            this.panelHeader1.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader1.Controls.Add(this.label13);
            this.panelHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader1.Location = new System.Drawing.Point(0, 0);
            this.panelHeader1.Margin = new System.Windows.Forms.Padding(4);
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
            this.panelHeader2.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader2.Name = "panelHeader2";
            this.panelHeader2.Size = new System.Drawing.Size(1405, 98);
            this.panelHeader2.TabIndex = 9;
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
            this.BtnSorgula.Click += new System.EventHandler(this.BtnSorgula_Click);
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
            this.txtUrunId.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunId.Multiline = true;
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.Size = new System.Drawing.Size(153, 43);
            this.txtUrunId.TabIndex = 60;
            // 
            // panelStok
            // 
            this.panelStok.Controls.Add(this.panel1);
            this.panelStok.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStok.Location = new System.Drawing.Point(0, 148);
            this.panelStok.Margin = new System.Windows.Forms.Padding(4);
            this.panelStok.Name = "panelStok";
            this.panelStok.Size = new System.Drawing.Size(703, 464);
            this.panelStok.TabIndex = 10;
            // 
            // paneldgvStok
            // 
            this.paneldgvStok.Controls.Add(this.dgvUrunler);
            this.paneldgvStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldgvStok.Location = new System.Drawing.Point(703, 148);
            this.paneldgvStok.Margin = new System.Windows.Forms.Padding(4);
            this.paneldgvStok.Name = "paneldgvStok";
            this.paneldgvStok.Size = new System.Drawing.Size(702, 464);
            this.paneldgvStok.TabIndex = 11;
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUrunler.Location = new System.Drawing.Point(0, 0);
            this.dgvUrunler.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUrunler.MultiSelect = false;
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.ReadOnly = true;
            this.dgvUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrunler.Size = new System.Drawing.Size(702, 464);
            this.dgvUrunler.TabIndex = 0;
            this.dgvUrunler.DoubleClick += new System.EventHandler(this.dgvUrunler_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtEklenenStok);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtSonStok);
            this.panel1.Controls.Add(this.btnStokEkle);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.lblAD);
            this.panel1.Controls.Add(this.lblBeden);
            this.panel1.Controls.Add(this.lblRenk);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblAdet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 464);
            this.panel1.TabIndex = 62;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.SteelBlue;
            this.lblID.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(67, 98);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(91, 24);
            this.lblID.TabIndex = 62;
            this.lblID.Text = "Ürün ID";
            // 
            // lblAD
            // 
            this.lblAD.AutoSize = true;
            this.lblAD.BackColor = System.Drawing.Color.SteelBlue;
            this.lblAD.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAD.ForeColor = System.Drawing.Color.White;
            this.lblAD.Location = new System.Drawing.Point(179, 122);
            this.lblAD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAD.Name = "lblAD";
            this.lblAD.Size = new System.Drawing.Size(99, 24);
            this.lblAD.TabIndex = 61;
            this.lblAD.Text = "Ürün Adı";
            // 
            // lblBeden
            // 
            this.lblBeden.AutoSize = true;
            this.lblBeden.BackColor = System.Drawing.Color.SteelBlue;
            this.lblBeden.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBeden.ForeColor = System.Drawing.Color.White;
            this.lblBeden.Location = new System.Drawing.Point(299, 146);
            this.lblBeden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBeden.Name = "lblBeden";
            this.lblBeden.Size = new System.Drawing.Size(74, 24);
            this.lblBeden.TabIndex = 60;
            this.lblBeden.Text = "Beden";
            // 
            // lblRenk
            // 
            this.lblRenk.AutoSize = true;
            this.lblRenk.BackColor = System.Drawing.Color.SteelBlue;
            this.lblRenk.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRenk.ForeColor = System.Drawing.Color.White;
            this.lblRenk.Location = new System.Drawing.Point(394, 170);
            this.lblRenk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(62, 24);
            this.lblRenk.TabIndex = 59;
            this.lblRenk.Text = "Renk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(477, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 58;
            this.label5.Text = "Adet:";
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.BackColor = System.Drawing.Color.SteelBlue;
            this.lblAdet.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdet.ForeColor = System.Drawing.Color.White;
            this.lblAdet.Location = new System.Drawing.Point(549, 194);
            this.lblAdet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(64, 24);
            this.lblAdet.TabIndex = 57;
            this.lblAdet.Text = "Adet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(74, 298);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 23);
            this.label7.TabIndex = 64;
            this.label7.Text = "Eklenen Stok :";
            // 
            // txtEklenenStok
            // 
            this.txtEklenenStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEklenenStok.Location = new System.Drawing.Point(287, 293);
            this.txtEklenenStok.Margin = new System.Windows.Forms.Padding(4);
            this.txtEklenenStok.Multiline = true;
            this.txtEklenenStok.Name = "txtEklenenStok";
            this.txtEklenenStok.Size = new System.Drawing.Size(195, 41);
            this.txtEklenenStok.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(74, 373);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 23);
            this.label8.TabIndex = 63;
            this.label8.Text = "Son Stok Durumu :";
            // 
            // txtSonStok
            // 
            this.txtSonStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSonStok.Location = new System.Drawing.Point(287, 363);
            this.txtSonStok.Margin = new System.Windows.Forms.Padding(4);
            this.txtSonStok.Multiline = true;
            this.txtSonStok.Name = "txtSonStok";
            this.txtSonStok.ReadOnly = true;
            this.txtSonStok.Size = new System.Drawing.Size(195, 41);
            this.txtSonStok.TabIndex = 65;
            // 
            // btnStokEkle
            // 
            this.btnStokEkle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStokEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokEkle.ForeColor = System.Drawing.Color.White;
            this.btnStokEkle.Image = global::PL.Properties.Resources.plus_5_32;
            this.btnStokEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStokEkle.Location = new System.Drawing.Point(516, 320);
            this.btnStokEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnStokEkle.Name = "btnStokEkle";
            this.btnStokEkle.Size = new System.Drawing.Size(111, 46);
            this.btnStokEkle.TabIndex = 67;
            this.btnStokEkle.Text = "       Ekle";
            this.btnStokEkle.UseVisualStyleBackColor = false;
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUrunStokİslemleri";
            this.Text = "frmUrunStokİslemleri";
            this.Load += new System.EventHandler(this.frmUrunStokİslemleri_Load);
            this.panelHeader1.ResumeLayout(false);
            this.panelHeader1.PerformLayout();
            this.panelHeader2.ResumeLayout(false);
            this.panelHeader2.PerformLayout();
            this.panelStok.ResumeLayout(false);
            this.paneldgvStok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panelHeader2;
        private System.Windows.Forms.Panel panelStok;
        private System.Windows.Forms.Panel paneldgvStok;
        private System.Windows.Forms.TextBox txtUrunId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.Button BtnSorgula;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAD;
        private System.Windows.Forms.Label lblBeden;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEklenenStok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSonStok;
        private System.Windows.Forms.Button btnStokEkle;
    }
}