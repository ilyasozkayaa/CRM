namespace PL.Kampanyalar
{
    partial class frmKampanyalar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtimebitis = new System.Windows.Forms.DateTimePicker();
            this.dtimebaslangıc = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPromosyonOranı = new System.Windows.Forms.TextBox();
            this.btnPromosyonEkle = new System.Windows.Forms.Button();
            this.btnPromosyonSil = new System.Windows.Forms.Button();
            this.btnPromosyonGuncelle = new System.Windows.Forms.Button();
            this.txtPromosyonAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvpromosyonlar = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpromosyonlar)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Promosyon Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Promosyon Oranı :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 100);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(450, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 34);
            this.label3.TabIndex = 1;
            this.label3.Text = "KAMPANYALAR";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtimebitis);
            this.panel2.Controls.Add(this.dtimebaslangıc);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtPromosyonOranı);
            this.panel2.Controls.Add(this.btnPromosyonEkle);
            this.panel2.Controls.Add(this.btnPromosyonSil);
            this.panel2.Controls.Add(this.btnPromosyonGuncelle);
            this.panel2.Controls.Add(this.txtPromosyonAdi);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 407);
            this.panel2.TabIndex = 3;
            // 
            // dtimebitis
            // 
            this.dtimebitis.Location = new System.Drawing.Point(174, 157);
            this.dtimebitis.Name = "dtimebitis";
            this.dtimebitis.Size = new System.Drawing.Size(203, 22);
            this.dtimebitis.TabIndex = 86;
            this.toolTip1.SetToolTip(this.dtimebitis, "Seçim Yapınız  !");
            // 
            // dtimebaslangıc
            // 
            this.dtimebaslangıc.Location = new System.Drawing.Point(174, 110);
            this.dtimebaslangıc.Name = "dtimebaslangıc";
            this.dtimebaslangıc.Size = new System.Drawing.Size(203, 22);
            this.dtimebaslangıc.TabIndex = 86;
            this.toolTip1.SetToolTip(this.dtimebaslangıc, "Seçim Yapınız  !");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::PL.Properties.Resources.icons8_christmas_gift_filled_323;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(115, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 61);
            this.button1.TabIndex = 85;
            this.button1.Text = "           Promosyon Bilgi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPromosyonOranı
            // 
            this.txtPromosyonOranı.Location = new System.Drawing.Point(174, 55);
            this.txtPromosyonOranı.Name = "txtPromosyonOranı";
            this.txtPromosyonOranı.Size = new System.Drawing.Size(203, 22);
            this.txtPromosyonOranı.TabIndex = 84;
            this.toolTip1.SetToolTip(this.txtPromosyonOranı, "Boş Bırakmayınız !");
            // 
            // btnPromosyonEkle
            // 
            this.btnPromosyonEkle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPromosyonEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromosyonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPromosyonEkle.ForeColor = System.Drawing.Color.White;
            this.btnPromosyonEkle.Image = global::PL.Properties.Resources.plus_5_321;
            this.btnPromosyonEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPromosyonEkle.Location = new System.Drawing.Point(17, 222);
            this.btnPromosyonEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnPromosyonEkle.Name = "btnPromosyonEkle";
            this.btnPromosyonEkle.Size = new System.Drawing.Size(170, 49);
            this.btnPromosyonEkle.TabIndex = 81;
            this.btnPromosyonEkle.Text = "   EKLE";
            this.btnPromosyonEkle.UseVisualStyleBackColor = false;
            this.btnPromosyonEkle.Click += new System.EventHandler(this.btnPromosyonEkle_Click);
            // 
            // btnPromosyonSil
            // 
            this.btnPromosyonSil.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPromosyonSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromosyonSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPromosyonSil.ForeColor = System.Drawing.Color.White;
            this.btnPromosyonSil.Image = global::PL.Properties.Resources.delete_32;
            this.btnPromosyonSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPromosyonSil.Location = new System.Drawing.Point(207, 222);
            this.btnPromosyonSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnPromosyonSil.Name = "btnPromosyonSil";
            this.btnPromosyonSil.Size = new System.Drawing.Size(170, 49);
            this.btnPromosyonSil.TabIndex = 80;
            this.btnPromosyonSil.Text = "   SİL";
            this.btnPromosyonSil.UseVisualStyleBackColor = false;
            this.btnPromosyonSil.Click += new System.EventHandler(this.btnPromosyonSil_Click);
            // 
            // btnPromosyonGuncelle
            // 
            this.btnPromosyonGuncelle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPromosyonGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromosyonGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPromosyonGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnPromosyonGuncelle.Image = global::PL.Properties.Resources.available_updates_32;
            this.btnPromosyonGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPromosyonGuncelle.Location = new System.Drawing.Point(115, 279);
            this.btnPromosyonGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnPromosyonGuncelle.Name = "btnPromosyonGuncelle";
            this.btnPromosyonGuncelle.Size = new System.Drawing.Size(175, 49);
            this.btnPromosyonGuncelle.TabIndex = 79;
            this.btnPromosyonGuncelle.Text = "        GÜNCELLE";
            this.btnPromosyonGuncelle.UseVisualStyleBackColor = false;
            this.btnPromosyonGuncelle.Click += new System.EventHandler(this.btnPromosyonGuncelle_Click);
            // 
            // txtPromosyonAdi
            // 
            this.txtPromosyonAdi.Location = new System.Drawing.Point(174, 6);
            this.txtPromosyonAdi.Name = "txtPromosyonAdi";
            this.txtPromosyonAdi.Size = new System.Drawing.Size(203, 22);
            this.txtPromosyonAdi.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtPromosyonAdi, "Boş Bırakmayınız !");
            this.txtPromosyonAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPromosyonAdi_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(27, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Bitiş Tarihi : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(14, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Başlangıç Tarihi :";
            // 
            // dgvpromosyonlar
            // 
            this.dgvpromosyonlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpromosyonlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvpromosyonlar.Location = new System.Drawing.Point(0, 0);
            this.dgvpromosyonlar.Name = "dgvpromosyonlar";
            this.dgvpromosyonlar.ReadOnly = true;
            this.dgvpromosyonlar.RowTemplate.Height = 24;
            this.dgvpromosyonlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpromosyonlar.Size = new System.Drawing.Size(645, 407);
            this.dgvpromosyonlar.TabIndex = 82;
            this.dgvpromosyonlar.DoubleClick += new System.EventHandler(this.dgvpromosyonlar_DoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvpromosyonlar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(404, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(645, 407);
            this.panel3.TabIndex = 4;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 50;
            this.toolTip1.AutoPopDelay = 1000;
            this.toolTip1.InitialDelay = 50;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 10;
            // 
            // frmKampanyalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 507);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKampanyalar";
            this.Text = "Kampanyalar";
            this.Load += new System.EventHandler(this.frmKampanyalar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpromosyonlar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPromosyonAdi;
        private System.Windows.Forms.Button btnPromosyonEkle;
        private System.Windows.Forms.Button btnPromosyonSil;
        private System.Windows.Forms.Button btnPromosyonGuncelle;
        private System.Windows.Forms.DataGridView dgvpromosyonlar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPromosyonOranı;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtimebitis;
        private System.Windows.Forms.DateTimePicker dtimebaslangıc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}