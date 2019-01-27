namespace PL
{
    partial class pnlGorevKarti
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
            this.components = new System.ComponentModel.Container();
            this.pnlheader = new System.Windows.Forms.Panel();
            this.lblGorevAdi = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pnlGorevDetay = new System.Windows.Forms.Panel();
            this.pnlMembers = new System.Windows.Forms.Panel();
            this.lblYuzde = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlheader.SuspendLayout();
            this.pnlMembers.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlheader
            // 
            this.pnlheader.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlheader.Controls.Add(this.lblGorevAdi);
            this.pnlheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlheader.Location = new System.Drawing.Point(0, 0);
            this.pnlheader.Name = "pnlheader";
            this.pnlheader.Size = new System.Drawing.Size(304, 29);
            this.pnlheader.TabIndex = 3;
            this.pnlheader.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlheader_MouseClick);
            // 
            // lblGorevAdi
            // 
            this.lblGorevAdi.AutoSize = true;
            this.lblGorevAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGorevAdi.ForeColor = System.Drawing.Color.White;
            this.lblGorevAdi.Location = new System.Drawing.Point(3, 6);
            this.lblGorevAdi.Name = "lblGorevAdi";
            this.lblGorevAdi.Size = new System.Drawing.Size(79, 20);
            this.lblGorevAdi.TabIndex = 0;
            this.lblGorevAdi.Text = "Görev Adı";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(124, 35);
            this.progressBar1.TabIndex = 1;
            // 
            // pnlGorevDetay
            // 
            this.pnlGorevDetay.BackColor = System.Drawing.Color.White;
            this.pnlGorevDetay.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGorevDetay.Location = new System.Drawing.Point(0, 29);
            this.pnlGorevDetay.MaximumSize = new System.Drawing.Size(304, 99);
            this.pnlGorevDetay.MinimumSize = new System.Drawing.Size(304, 10);
            this.pnlGorevDetay.Name = "pnlGorevDetay";
            this.pnlGorevDetay.Size = new System.Drawing.Size(304, 99);
            this.pnlGorevDetay.TabIndex = 4;
            // 
            // pnlMembers
            // 
            this.pnlMembers.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlMembers.Controls.Add(this.lblYuzde);
            this.pnlMembers.Controls.Add(this.progressBar1);
            this.pnlMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMembers.Location = new System.Drawing.Point(0, 128);
            this.pnlMembers.MaximumSize = new System.Drawing.Size(304, 35);
            this.pnlMembers.Name = "pnlMembers";
            this.pnlMembers.Size = new System.Drawing.Size(304, 35);
            this.pnlMembers.TabIndex = 5;
            // 
            // lblYuzde
            // 
            this.lblYuzde.AutoSize = true;
            this.lblYuzde.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblYuzde.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYuzde.ForeColor = System.Drawing.Color.DimGray;
            this.lblYuzde.Location = new System.Drawing.Point(124, 0);
            this.lblYuzde.Name = "lblYuzde";
            this.lblYuzde.Size = new System.Drawing.Size(69, 25);
            this.lblYuzde.TabIndex = 3;
            this.lblYuzde.Text = "%XXX";
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlGorevKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMembers);
            this.Controls.Add(this.pnlGorevDetay);
            this.Controls.Add(this.pnlheader);
            this.MaximumSize = new System.Drawing.Size(304, 160);
            this.MinimumSize = new System.Drawing.Size(304, 27);
            this.Name = "pnlGorevKarti";
            this.Size = new System.Drawing.Size(304, 160);
            this.pnlheader.ResumeLayout(false);
            this.pnlheader.PerformLayout();
            this.pnlMembers.ResumeLayout(false);
            this.pnlMembers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlheader;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lblGorevAdi;
        public System.Windows.Forms.Panel pnlGorevDetay;
        public System.Windows.Forms.Panel pnlMembers;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Label lblYuzde;
    }
}
