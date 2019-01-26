namespace PL
{
    partial class frmGiris
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
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkSifre = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblPersonelid = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.pnlDegis = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.txtp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtp2 = new System.Windows.Forms.TextBox();
            this.lblYenile = new System.Windows.Forms.Label();
            this.circularPictureBox1 = new PL.CircularPictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlDegis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblYenile);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 84);
            this.panel1.TabIndex = 1;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(108, 229);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '•';
            this.txtParola.Size = new System.Drawing.Size(116, 20);
            this.txtParola.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(108, 187);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(116, 20);
            this.txtId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(48, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parola";
            // 
            // lnkSifre
            // 
            this.lnkSifre.AutoSize = true;
            this.lnkSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkSifre.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lnkSifre.Location = new System.Drawing.Point(105, 256);
            this.lnkSifre.Name = "lnkSifre";
            this.lnkSifre.Size = new System.Drawing.Size(121, 13);
            this.lnkSifre.TabIndex = 6;
            this.lnkSifre.TabStop = true;
            this.lnkSifre.Text = "Parolanızı mı unuttunuz?";
            this.lnkSifre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lnkSifre_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 358);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 39);
            this.panel2.TabIndex = 7;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGiris.FlatAppearance.BorderSize = 0;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Location = new System.Drawing.Point(108, 298);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(118, 36);
            this.btnGiris.TabIndex = 8;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblPersonelid
            // 
            this.lblPersonelid.AutoSize = true;
            this.lblPersonelid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelid.Location = new System.Drawing.Point(19, 187);
            this.lblPersonelid.Name = "lblPersonelid";
            this.lblPersonelid.Size = new System.Drawing.Size(73, 16);
            this.lblPersonelid.TabIndex = 9;
            this.lblPersonelid.Text = "Personel ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::PL.Properties.Resources.help;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 37);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Image = global::PL.Properties.Resources.deleteWhite;
            this.btnCikis.Location = new System.Drawing.Point(266, 0);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(58, 31);
            this.btnCikis.TabIndex = 9;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // pnlDegis
            // 
            this.pnlDegis.Controls.Add(this.label4);
            this.pnlDegis.Controls.Add(this.txtp2);
            this.pnlDegis.Controls.Add(this.label3);
            this.pnlDegis.Controls.Add(this.txtp);
            this.pnlDegis.Controls.Add(this.button2);
            this.pnlDegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlDegis.Location = new System.Drawing.Point(0, 86);
            this.pnlDegis.Name = "pnlDegis";
            this.pnlDegis.Size = new System.Drawing.Size(321, 279);
            this.pnlDegis.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(118, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 38);
            this.button2.TabIndex = 0;
            this.button2.Text = "Yenile";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtp
            // 
            this.txtp.Location = new System.Drawing.Point(118, 63);
            this.txtp.Name = "txtp";
            this.txtp.Size = new System.Drawing.Size(121, 26);
            this.txtp.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parola";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Parola Yenile";
            // 
            // txtp2
            // 
            this.txtp2.Location = new System.Drawing.Point(118, 115);
            this.txtp2.Name = "txtp2";
            this.txtp2.Size = new System.Drawing.Size(121, 26);
            this.txtp2.TabIndex = 5;
            // 
            // lblYenile
            // 
            this.lblYenile.AutoSize = true;
            this.lblYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYenile.ForeColor = System.Drawing.Color.White;
            this.lblYenile.Location = new System.Drawing.Point(37, 41);
            this.lblYenile.Name = "lblYenile";
            this.lblYenile.Size = new System.Drawing.Size(230, 29);
            this.lblYenile.TabIndex = 7;
            this.lblYenile.Text = "Parolanızı Yenileyin.";
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.Image = global::PL.Properties.Resources.images;
            this.circularPictureBox1.Location = new System.Drawing.Point(108, 41);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(116, 107);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPictureBox1.TabIndex = 0;
            this.circularPictureBox1.TabStop = false;
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 397);
            this.Controls.Add(this.pnlDegis);
            this.Controls.Add(this.lblPersonelid);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lnkSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.circularPictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGiris";
            this.Text = "frmGiris";
            this.Load += new System.EventHandler(this.frmGiris_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlDegis.ResumeLayout(false);
            this.pnlDegis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularPictureBox circularPictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkSifre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblPersonelid;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Panel pnlDegis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtp2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblYenile;
    }
}