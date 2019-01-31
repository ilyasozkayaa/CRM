namespace PL.Personel
{
    partial class Personeller
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
            this.PnlPersonelArama = new System.Windows.Forms.Panel();
            this.BtnÇıkışVerme = new System.Windows.Forms.Button();
            this.BtnYeniPersonel = new System.Windows.Forms.Button();
            this.BtnListele = new System.Windows.Forms.Button();
            this.BtnSorgula = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyadı = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdı = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DgvPersoneller = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.PnlPersonelArama.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersoneller)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1067, 53);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(674, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "                                                         PERSONELLER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlPersonelArama
            // 
            this.PnlPersonelArama.Controls.Add(this.BtnÇıkışVerme);
            this.PnlPersonelArama.Controls.Add(this.BtnYeniPersonel);
            this.PnlPersonelArama.Controls.Add(this.BtnListele);
            this.PnlPersonelArama.Controls.Add(this.BtnSorgula);
            this.PnlPersonelArama.Controls.Add(this.label4);
            this.PnlPersonelArama.Controls.Add(this.txtSoyadı);
            this.PnlPersonelArama.Controls.Add(this.label3);
            this.PnlPersonelArama.Controls.Add(this.label2);
            this.PnlPersonelArama.Controls.Add(this.txtAdı);
            this.PnlPersonelArama.Controls.Add(this.txtID);
            this.PnlPersonelArama.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlPersonelArama.Location = new System.Drawing.Point(0, 53);
            this.PnlPersonelArama.Margin = new System.Windows.Forms.Padding(4);
            this.PnlPersonelArama.Name = "PnlPersonelArama";
            this.PnlPersonelArama.Size = new System.Drawing.Size(283, 501);
            this.PnlPersonelArama.TabIndex = 1;
            // 
            // BtnÇıkışVerme
            // 
            this.BtnÇıkışVerme.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnÇıkışVerme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnÇıkışVerme.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnÇıkışVerme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnÇıkışVerme.Image = global::PL.Properties.Resources.remove_user_32;
            this.BtnÇıkışVerme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnÇıkışVerme.Location = new System.Drawing.Point(19, 314);
            this.BtnÇıkışVerme.Margin = new System.Windows.Forms.Padding(4);
            this.BtnÇıkışVerme.Name = "BtnÇıkışVerme";
            this.BtnÇıkışVerme.Size = new System.Drawing.Size(179, 47);
            this.BtnÇıkışVerme.TabIndex = 12;
            this.BtnÇıkışVerme.Text = "      Çıkış Verme";
            this.BtnÇıkışVerme.UseVisualStyleBackColor = false;
            this.BtnÇıkışVerme.Click += new System.EventHandler(this.BtnÇıkışVerme_Click);
            // 
            // BtnYeniPersonel
            // 
            this.BtnYeniPersonel.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnYeniPersonel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnYeniPersonel.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYeniPersonel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnYeniPersonel.Image = global::PL.Properties.Resources.add_user_2_32;
            this.BtnYeniPersonel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnYeniPersonel.Location = new System.Drawing.Point(16, 380);
            this.BtnYeniPersonel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnYeniPersonel.Name = "BtnYeniPersonel";
            this.BtnYeniPersonel.Size = new System.Drawing.Size(185, 47);
            this.BtnYeniPersonel.TabIndex = 11;
            this.BtnYeniPersonel.Text = "      Yeni Personel";
            this.BtnYeniPersonel.UseVisualStyleBackColor = false;
            this.BtnYeniPersonel.Click += new System.EventHandler(this.BtnYeniPersonel_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnListele.FlatAppearance.BorderSize = 0;
            this.BtnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListele.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnListele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnListele.Image = global::PL.Properties.Resources.activity_feed_32;
            this.BtnListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListele.Location = new System.Drawing.Point(19, 190);
            this.BtnListele.Margin = new System.Windows.Forms.Padding(4);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(179, 43);
            this.BtnListele.TabIndex = 10;
            this.BtnListele.Text = "           Tümünü Listele";
            this.BtnListele.UseVisualStyleBackColor = false;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
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
            this.BtnSorgula.Location = new System.Drawing.Point(22, 252);
            this.BtnSorgula.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSorgula.Name = "BtnSorgula";
            this.BtnSorgula.Size = new System.Drawing.Size(179, 43);
            this.BtnSorgula.TabIndex = 9;
            this.BtnSorgula.Text = "Sorgula";
            this.BtnSorgula.UseVisualStyleBackColor = false;
            this.BtnSorgula.Click += new System.EventHandler(this.BtnSorgula_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Soyad :";
            // 
            // txtSoyadı
            // 
            this.txtSoyadı.Location = new System.Drawing.Point(123, 130);
            this.txtSoyadı.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyadı.Name = "txtSoyadı";
            this.txtSoyadı.Size = new System.Drawing.Size(132, 22);
            this.txtSoyadı.TabIndex = 4;
            this.txtSoyadı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyadı_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(16, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel ID :";
            // 
            // txtAdı
            // 
            this.txtAdı.Location = new System.Drawing.Point(123, 85);
            this.txtAdı.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdı.Name = "txtAdı";
            this.txtAdı.Size = new System.Drawing.Size(132, 22);
            this.txtAdı.TabIndex = 1;
            this.txtAdı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdı_KeyPress);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(123, 42);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(132, 22);
            this.txtID.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DgvPersoneller);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(283, 53);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 501);
            this.panel3.TabIndex = 2;
            // 
            // DgvPersoneller
            // 
            this.DgvPersoneller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPersoneller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvPersoneller.Location = new System.Drawing.Point(0, 0);
            this.DgvPersoneller.MultiSelect = false;
            this.DgvPersoneller.Name = "DgvPersoneller";
            this.DgvPersoneller.ReadOnly = true;
            this.DgvPersoneller.RowTemplate.Height = 24;
            this.DgvPersoneller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPersoneller.Size = new System.Drawing.Size(784, 501);
            this.DgvPersoneller.TabIndex = 0;
            this.DgvPersoneller.DoubleClick += new System.EventHandler(this.DgvPersoneller_DoubleClick);
            // 
            // Personeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PnlPersonelArama);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Personeller";
            this.Text = "PersonelEkleCikar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PnlPersonelArama.ResumeLayout(false);
            this.PnlPersonelArama.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersoneller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlPersonelArama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoyadı;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdı;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Button BtnSorgula;
        private System.Windows.Forms.Button BtnÇıkışVerme;
        private System.Windows.Forms.Button BtnYeniPersonel;
        private System.Windows.Forms.DataGridView DgvPersoneller;
    }
}