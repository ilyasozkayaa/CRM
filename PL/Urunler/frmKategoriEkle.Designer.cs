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
            this.panelHeader1.Name = "panelHeader1";
            this.panelHeader1.Size = new System.Drawing.Size(1054, 41);
            this.panelHeader1.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Left;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(231, 31);
            this.label13.TabIndex = 0;
            this.label13.Text = "KATEGORİ EKLE";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(106, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Kategori Adı";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(106, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Açıklama";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtKategoriAd
            // 
            this.txtKategoriAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKategoriAd.Location = new System.Drawing.Point(209, 51);
            this.txtKategoriAd.Name = "txtKategoriAd";
            this.txtKategoriAd.Size = new System.Drawing.Size(226, 26);
            this.txtKategoriAd.TabIndex = 31;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(209, 86);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(226, 115);
            this.txtAciklama.TabIndex = 31;
            // 
            // btnKatagoriEkle
            // 
            this.btnKatagoriEkle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnKatagoriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKatagoriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKatagoriEkle.ForeColor = System.Drawing.Color.White;
            this.btnKatagoriEkle.Location = new System.Drawing.Point(162, 232);
            this.btnKatagoriEkle.Name = "btnKatagoriEkle";
            this.btnKatagoriEkle.Size = new System.Drawing.Size(100, 50);
            this.btnKatagoriEkle.TabIndex = 32;
            this.btnKatagoriEkle.Text = "EKLE";
            this.btnKatagoriEkle.UseVisualStyleBackColor = false;
            // 
            // btnKategoriSil
            // 
            this.btnKategoriSil.BackColor = System.Drawing.Color.SteelBlue;
            this.btnKategoriSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriSil.ForeColor = System.Drawing.Color.White;
            this.btnKategoriSil.Location = new System.Drawing.Point(385, 232);
            this.btnKategoriSil.Name = "btnKategoriSil";
            this.btnKategoriSil.Size = new System.Drawing.Size(100, 50);
            this.btnKategoriSil.TabIndex = 33;
            this.btnKategoriSil.Text = "SİL";
            this.btnKategoriSil.UseVisualStyleBackColor = false;
            // 
            // btnKategoriGuncelle
            // 
            this.btnKategoriGuncelle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnKategoriGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnKategoriGuncelle.Location = new System.Drawing.Point(275, 232);
            this.btnKategoriGuncelle.Name = "btnKategoriGuncelle";
            this.btnKategoriGuncelle.Size = new System.Drawing.Size(100, 50);
            this.btnKategoriGuncelle.TabIndex = 34;
            this.btnKategoriGuncelle.Text = "GÜNCELLE";
            this.btnKategoriGuncelle.UseVisualStyleBackColor = false;
            // 
            // panelHeader2
            // 
            this.panelHeader2.BackColor = System.Drawing.Color.White;
            this.panelHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader2.Location = new System.Drawing.Point(0, 41);
            this.panelHeader2.Name = "panelHeader2";
            this.panelHeader2.Size = new System.Drawing.Size(1054, 80);
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
            this.panelKategoriEkle.Location = new System.Drawing.Point(0, 121);
            this.panelKategoriEkle.Name = "panelKategoriEkle";
            this.panelKategoriEkle.Size = new System.Drawing.Size(527, 376);
            this.panelKategoriEkle.TabIndex = 37;
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.Controls.Add(this.dgKatagoriListe);
            this.panelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGridView.Location = new System.Drawing.Point(527, 121);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(527, 376);
            this.panelDataGridView.TabIndex = 38;
            // 
            // dgKatagoriListe
            // 
            this.dgKatagoriListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKatagoriListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgKatagoriListe.Location = new System.Drawing.Point(0, 0);
            this.dgKatagoriListe.Name = "dgKatagoriListe";
            this.dgKatagoriListe.Size = new System.Drawing.Size(527, 376);
            this.dgKatagoriListe.TabIndex = 0;
            // 
            // frmKategoriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 497);
            this.Controls.Add(this.panelDataGridView);
            this.Controls.Add(this.panelKategoriEkle);
            this.Controls.Add(this.panelHeader2);
            this.Controls.Add(this.panelHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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