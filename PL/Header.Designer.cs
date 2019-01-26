namespace PL
{
    partial class Header
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
            this.logo1 = new PL.LOGO();
            this.SuspendLayout();
            // 
            // logo1
            // 
            this.logo1.BackColor = System.Drawing.Color.Transparent;
            this.logo1.Dock = System.Windows.Forms.DockStyle.Right;
            this.logo1.Location = new System.Drawing.Point(453, 0);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(75, 73);
            this.logo1.TabIndex = 1;
            // 
            // Header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.logo1);
            this.Name = "Header";
            this.Size = new System.Drawing.Size(528, 73);
            this.ResumeLayout(false);

        }

        #endregion
        private LOGO logo1;
    }
}
