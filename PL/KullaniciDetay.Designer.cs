namespace PL
{
    partial class KullaniciDetay
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSoyAdi = new System.Windows.Forms.Label();
            this.lblAdi = new System.Windows.Forms.Label();
            this.circularPictureBox1 = new PL.CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSoyAdi
            // 
            this.lblSoyAdi.AutoSize = true;
            this.lblSoyAdi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyAdi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSoyAdi.Location = new System.Drawing.Point(137, 16);
            this.lblSoyAdi.Name = "lblSoyAdi";
            this.lblSoyAdi.Size = new System.Drawing.Size(62, 19);
            this.lblSoyAdi.TabIndex = 11;
            this.lblSoyAdi.Text = "Soyadı";
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdi.Location = new System.Drawing.Point(61, 16);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(34, 19);
            this.lblAdi.TabIndex = 10;
            this.lblAdi.Text = "Adı";
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.Image = global::PL.Properties.Resources.profileicon;
            this.circularPictureBox1.Location = new System.Drawing.Point(3, 9);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(44, 34);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPictureBox1.TabIndex = 9;
            this.circularPictureBox1.TabStop = false;
            // 
            // KullaniciDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.lblSoyAdi);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.circularPictureBox1);
            this.Name = "KullaniciDetay";
            this.Size = new System.Drawing.Size(262, 50);
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblSoyAdi;
        public System.Windows.Forms.Label lblAdi;
        public CircularPictureBox circularPictureBox1;
    }
}
