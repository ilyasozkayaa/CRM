﻿namespace PL
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblGorevAdi = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.pnlGorevDetay = new System.Windows.Forms.Panel();
            this.dgvDetay = new System.Windows.Forms.DataGridView();
            this.clbDetay = new System.Windows.Forms.CheckedListBox();
            this.pnlMembers = new System.Windows.Forms.Panel();
            this.lblBitis = new System.Windows.Forms.Label();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnupdate = new System.Windows.Forms.Button();
            this.pnlheader.SuspendLayout();
            this.pnlGorevDetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetay)).BeginInit();
            this.pnlMembers.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlheader
            // 
            this.pnlheader.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlheader.Controls.Add(this.btnupdate);
            this.pnlheader.Controls.Add(this.btnClose);
            this.pnlheader.Controls.Add(this.lblGorevAdi);
            this.pnlheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlheader.Location = new System.Drawing.Point(0, 0);
            this.pnlheader.Name = "pnlheader";
            this.pnlheader.Size = new System.Drawing.Size(304, 29);
            this.pnlheader.TabIndex = 3;
            this.pnlheader.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlheader_MouseClick);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::PL.Properties.Resources.icons8_multiply_32__2_;
            this.btnClose.Location = new System.Drawing.Point(266, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
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
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(3, 3);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(82, 13);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Başlangıç Tarihi";
            // 
            // pnlGorevDetay
            // 
            this.pnlGorevDetay.BackColor = System.Drawing.Color.White;
            this.pnlGorevDetay.Controls.Add(this.dgvDetay);
            this.pnlGorevDetay.Controls.Add(this.clbDetay);
            this.pnlGorevDetay.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGorevDetay.Location = new System.Drawing.Point(0, 29);
            this.pnlGorevDetay.MaximumSize = new System.Drawing.Size(304, 99);
            this.pnlGorevDetay.MinimumSize = new System.Drawing.Size(304, 10);
            this.pnlGorevDetay.Name = "pnlGorevDetay";
            this.pnlGorevDetay.Size = new System.Drawing.Size(304, 99);
            this.pnlGorevDetay.TabIndex = 4;
            // 
            // dgvDetay
            // 
            this.dgvDetay.AllowUserToAddRows = false;
            this.dgvDetay.AllowUserToDeleteRows = false;
            this.dgvDetay.AllowUserToResizeColumns = false;
            this.dgvDetay.AllowUserToResizeRows = false;
            this.dgvDetay.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDetay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetay.Location = new System.Drawing.Point(0, 0);
            this.dgvDetay.Name = "dgvDetay";
            this.dgvDetay.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetay.RowHeadersVisible = false;
            this.dgvDetay.Size = new System.Drawing.Size(304, 99);
            this.dgvDetay.TabIndex = 1;
            // 
            // clbDetay
            // 
            this.clbDetay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbDetay.FormattingEnabled = true;
            this.clbDetay.Location = new System.Drawing.Point(0, 0);
            this.clbDetay.Name = "clbDetay";
            this.clbDetay.Size = new System.Drawing.Size(304, 99);
            this.clbDetay.TabIndex = 0;
            // 
            // pnlMembers
            // 
            this.pnlMembers.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlMembers.Controls.Add(this.lblBitis);
            this.pnlMembers.Controls.Add(this.lblBaslangic);
            this.pnlMembers.Controls.Add(this.label1);
            this.pnlMembers.Controls.Add(this.lbl);
            this.pnlMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMembers.Location = new System.Drawing.Point(0, 128);
            this.pnlMembers.MaximumSize = new System.Drawing.Size(304, 35);
            this.pnlMembers.Name = "pnlMembers";
            this.pnlMembers.Size = new System.Drawing.Size(304, 35);
            this.pnlMembers.TabIndex = 5;
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Location = new System.Drawing.Point(91, 19);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(55, 13);
            this.lblBitis.TabIndex = 4;
            this.lblBitis.Text = "Bitiş Tarihi";
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Location = new System.Drawing.Point(91, 3);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(82, 13);
            this.lblBaslangic.TabIndex = 3;
            this.lblBaslangic.Text = "Başlangıç Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bitiş Tarihi";
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnupdate
            // 
            this.btnupdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Image = global::PL.Properties.Resources.icons8_available_updates_32;
            this.btnupdate.Location = new System.Drawing.Point(228, 0);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(38, 29);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.UseVisualStyleBackColor = true;
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
            this.pnlGorevDetay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetay)).EndInit();
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
        public System.Windows.Forms.CheckedListBox clbDetay;
        private System.Windows.Forms.Label lbl;
        public System.Windows.Forms.Label lblBitis;
        public System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvDetay;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnupdate;
    }
}
