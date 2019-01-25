namespace Crmdenemeee
{
    partial class UserControl3
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.circularPictureBox2 = new Crmdenemeee.CircularPictureBox();
            this.circularPictureBox1 = new Crmdenemeee.CircularPictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pnlheader = new System.Windows.Forms.Panel();
            this.lblGorevAdi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.pnlheader.SuspendLayout();
            this.SuspendLayout();
            // 
            // circularPictureBox2
            // 
            this.circularPictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.circularPictureBox2.Image = global::Crmdenemeee.Properties.Resources.profileicon;
            this.circularPictureBox2.Location = new System.Drawing.Point(130, 31);
            this.circularPictureBox2.Name = "circularPictureBox2";
            this.circularPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.circularPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.circularPictureBox2.TabIndex = 1;
            this.circularPictureBox2.TabStop = false;
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.circularPictureBox1.Image = global::Crmdenemeee.Properties.Resources.profileicon;
            this.circularPictureBox1.Location = new System.Drawing.Point(165, 31);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.circularPictureBox1.TabIndex = 0;
            this.circularPictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 67);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // pnlheader
            // 
            this.pnlheader.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlheader.Controls.Add(this.lblGorevAdi);
            this.pnlheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlheader.Location = new System.Drawing.Point(0, 0);
            this.pnlheader.Name = "pnlheader";
            this.pnlheader.Size = new System.Drawing.Size(200, 25);
            this.pnlheader.TabIndex = 3;
            // 
            // lblGorevAdi
            // 
            this.lblGorevAdi.AutoSize = true;
            this.lblGorevAdi.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblGorevAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGorevAdi.ForeColor = System.Drawing.Color.White;
            this.lblGorevAdi.Location = new System.Drawing.Point(0, 0);
            this.lblGorevAdi.Name = "lblGorevAdi";
            this.lblGorevAdi.Size = new System.Drawing.Size(71, 17);
            this.lblGorevAdi.TabIndex = 0;
            this.lblGorevAdi.Text = "Görev Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlheader);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.circularPictureBox2);
            this.Controls.Add(this.circularPictureBox1);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(200, 90);
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.pnlheader.ResumeLayout(false);
            this.pnlheader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularPictureBox circularPictureBox1;
        private CircularPictureBox circularPictureBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel pnlheader;
        private System.Windows.Forms.Label lblGorevAdi;
        private System.Windows.Forms.Label label1;
    }
}
