namespace PL.Urunler
{
    partial class frmKategoriEkle
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKategoriAd = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnKatagoriEkle = new System.Windows.Forms.Button();
            this.btnKategoriSil = new System.Windows.Forms.Button();
            this.btnKategoriGuncelle = new System.Windows.Forms.Button();
            this.panelHeader2 = new System.Windows.Forms.Panel();
            this.panelKategoriEkle = new System.Windows.Forms.Panel();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.dgKatagoriListe = new System.Windows.Forms.DataGridView();
            this.panelHeader1.SuspendLayout();
            this.panelKategoriEkle.SuspendLayout();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKatagoriListe)).BeginInit();
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
            this.panelHeader1.TabIndex = 7;
            this.panelHeader1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader1_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Left;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(291, 39);
            this.label13.TabIndex = 0;
            this.label13.Text = "KATEGORİ EKLE";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(141, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Kategori Adı";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(141, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Açıklama";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtKategoriAd
            // 
            this.txtKategoriAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKategoriAd.Location = new System.Drawing.Point(279, 63);
            this.txtKategoriAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKategoriAd.Name = "txtKategoriAd";
            this.txtKategoriAd.Size = new System.Drawing.Size(300, 30);
            this.txtKategoriAd.TabIndex = 31;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(279, 106);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(300, 141);
            this.txtAciklama.TabIndex = 31;
            // 
            // btnKatagoriEkle
            // 
            this.btnKatagoriEkle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnKatagoriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKatagoriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKatagoriEkle.ForeColor = System.Drawing.Color.White;
            this.btnKatagoriEkle.Location = new System.Drawing.Point(216, 286);
            this.btnKatagoriEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKatagoriEkle.Name = "btnKatagoriEkle";
            this.btnKatagoriEkle.Size = new System.Drawing.Size(133, 62);
            this.btnKatagoriEkle.TabIndex = 32;
            this.btnKatagoriEkle.Text = "EKLE";
            this.btnKatagoriEkle.UseVisualStyleBackColor = false;
            this.btnKatagoriEkle.Click += new System.EventHandler(this.btnKatagoriEkle_Click);
            // 
            // btnKategoriSil
            // 
            this.btnKategoriSil.BackColor = System.Drawing.Color.SteelBlue;
            this.btnKategoriSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriSil.ForeColor = System.Drawing.Color.White;
            this.btnKategoriSil.Location = new System.Drawing.Point(513, 286);
            this.btnKategoriSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKategoriSil.Name = "btnKategoriSil";
            this.btnKategoriSil.Size = new System.Drawing.Size(133, 62);
            this.btnKategoriSil.TabIndex = 33;
            this.btnKategoriSil.Text = "SİL";
            this.btnKategoriSil.UseVisualStyleBackColor = false;
            this.btnKategoriSil.Click += new System.EventHandler(this.btnKategoriSil_Click);
            // 
            // btnKategoriGuncelle
            // 
            this.btnKategoriGuncelle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnKategoriGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnKategoriGuncelle.Location = new System.Drawing.Point(367, 286);
            this.btnKategoriGuncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKategoriGuncelle.Name = "btnKategoriGuncelle";
            this.btnKategoriGuncelle.Size = new System.Drawing.Size(133, 62);
            this.btnKategoriGuncelle.TabIndex = 34;
            this.btnKategoriGuncelle.Text = "GÜNCELLE";
            this.btnKategoriGuncelle.UseVisualStyleBackColor = false;
            this.btnKategoriGuncelle.Click += new System.EventHandler(this.btnKategoriGuncelle_Click);
            // 
            // panelHeader2
            // 
            this.panelHeader2.BackColor = System.Drawing.Color.White;
            this.panelHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader2.Location = new System.Drawing.Point(0, 50);
            this.panelHeader2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelHeader2.Name = "panelHeader2";
            this.panelHeader2.Size = new System.Drawing.Size(1405, 98);
            this.panelHeader2.TabIndex = 36;
            // 
            // panelKategoriEkle
            // 
            this.panelKategoriEkle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelKategoriEkle.Controls.Add(this.txtAciklama);
            this.panelKategoriEkle.Controls.Add(this.label6);
            this.panelKategoriEkle.Controls.Add(this.btnKatagoriEkle);
            this.panelKategoriEkle.Controls.Add(this.label7);
            this.panelKategoriEkle.Controls.Add(this.btnKategoriSil);
            this.panelKategoriEkle.Controls.Add(this.txtKategoriAd);
            this.panelKategoriEkle.Controls.Add(this.btnKategoriGuncelle);
            this.panelKategoriEkle.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelKategoriEkle.Location = new System.Drawing.Point(0, 148);
            this.panelKategoriEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelKategoriEkle.Name = "panelKategoriEkle";
            this.panelKategoriEkle.Size = new System.Drawing.Size(703, 464);
            this.panelKategoriEkle.TabIndex = 37;
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.Controls.Add(this.dgKatagoriListe);
            this.panelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGridView.Location = new System.Drawing.Point(703, 148);
            this.panelDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(702, 464);
            this.panelDataGridView.TabIndex = 38;
            // 
            // dgKatagoriListe
            // 
            this.dgKatagoriListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKatagoriListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgKatagoriListe.Location = new System.Drawing.Point(0, 0);
            this.dgKatagoriListe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgKatagoriListe.MultiSelect = false;
            this.dgKatagoriListe.Name = "dgKatagoriListe";
            this.dgKatagoriListe.ReadOnly = true;
            this.dgKatagoriListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKatagoriListe.Size = new System.Drawing.Size(702, 464);
            this.dgKatagoriListe.TabIndex = 0;
            this.dgKatagoriListe.DoubleClick += new System.EventHandler(this.dgKatagoriListe_DoubleClick);
            // 
            // frmKategoriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 612);
            this.Controls.Add(this.panelDataGridView);
            this.Controls.Add(this.panelKategoriEkle);
            this.Controls.Add(this.panelHeader2);
            this.Controls.Add(this.panelHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmKategoriEkle";
            this.Text = "frmKategoriEkle";
            this.panelHeader1.ResumeLayout(false);
            this.panelHeader1.PerformLayout();
            this.panelKategoriEkle.ResumeLayout(false);
            this.panelKategoriEkle.PerformLayout();
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgKatagoriListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKategoriAd;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnKatagoriEkle;
        private System.Windows.Forms.Button btnKategoriSil;
        private System.Windows.Forms.Button btnKategoriGuncelle;
        private System.Windows.Forms.Panel panelHeader2;
        private System.Windows.Forms.Panel panelKategoriEkle;
        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.DataGridView dgKatagoriListe;
    }
}