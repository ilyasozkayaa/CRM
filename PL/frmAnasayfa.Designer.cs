namespace PL
{
    partial class frmAnasayfa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnPersonicon = new System.Windows.Forms.Button();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGörevlerim = new System.Windows.Forms.Button();
            this.btnBilgiler = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.pnlPersoneSekme = new System.Windows.Forms.Panel();
            this.btnGorevAta = new System.Windows.Forms.Button();
            this.btnPersoneller = new System.Windows.Forms.Button();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.pnlUrun = new System.Windows.Forms.Panel();
            this.btnStok = new System.Windows.Forms.Button();
            this.btnUrunEk = new System.Windows.Forms.Button();
            this.btnKategoriekle = new System.Windows.Forms.Button();
            this.btnUrun = new System.Windows.Forms.Button();
            this.btnKasa = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnKampanya = new System.Windows.Forms.Button();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.kullaniciDetay1 = new PL.KullaniciDetay();
            this.pnlSaat = new System.Windows.Forms.Panel();
            this.lbltoday = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pnlContent = new System.Windows.Forms.Panel();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.flpMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlPersoneSekme.SuspendLayout();
            this.pnlUrun.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlSaat.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1387, 62);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinimize.Location = new System.Drawing.Point(1246, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(47, 62);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Text = "—";
            this.btnMinimize.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::PL.Properties.Resources.icons8_bow_tie_32;
            this.pictureBox1.Location = new System.Drawing.Point(67, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::PL.Properties.Resources.icons8_virtual_machine_32__2_;
            this.btnMaximize.Location = new System.Drawing.Point(1293, 0);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(47, 62);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(1340, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 62);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.AutoSize = true;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Image = global::PL.Properties.Resources.icons8_menu_32;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(67, 62);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.btnHelp);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.btnPersonicon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(67, 676);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Image = global::PL.Properties.Resources.help;
            this.btnHelp.Location = new System.Drawing.Point(0, 621);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(67, 55);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.SteelBlue;
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = global::PL.Properties.Resources.launchpad;
            this.button8.Location = new System.Drawing.Point(0, 291);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(67, 55);
            this.button8.TabIndex = 5;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.SteelBlue;
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = global::PL.Properties.Resources.chart;
            this.button7.Location = new System.Drawing.Point(0, 232);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(67, 59);
            this.button7.TabIndex = 4;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SteelBlue;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::PL.Properties.Resources.money;
            this.button6.Location = new System.Drawing.Point(0, 173);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 59);
            this.button6.TabIndex = 3;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SteelBlue;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::PL.Properties.Resources.hanger;
            this.button5.Location = new System.Drawing.Point(0, 114);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 59);
            this.button5.TabIndex = 2;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SteelBlue;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::PL.Properties.Resources.people;
            this.button4.Location = new System.Drawing.Point(0, 55);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 59);
            this.button4.TabIndex = 1;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnPersonicon
            // 
            this.btnPersonicon.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPersonicon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonicon.FlatAppearance.BorderSize = 0;
            this.btnPersonicon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonicon.Image = global::PL.Properties.Resources.profileicon;
            this.btnPersonicon.Location = new System.Drawing.Point(0, 0);
            this.btnPersonicon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPersonicon.Name = "btnPersonicon";
            this.btnPersonicon.Size = new System.Drawing.Size(67, 55);
            this.btnPersonicon.TabIndex = 0;
            this.btnPersonicon.UseVisualStyleBackColor = false;
            this.btnPersonicon.Click += new System.EventHandler(this.btnPersonicon_Click);
            // 
            // flpMenu
            // 
            this.flpMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.flpMenu.Controls.Add(this.panel3);
            this.flpMenu.Controls.Add(this.pnlPersoneSekme);
            this.flpMenu.Controls.Add(this.pnlUrun);
            this.flpMenu.Controls.Add(this.btnKasa);
            this.flpMenu.Controls.Add(this.btnRapor);
            this.flpMenu.Controls.Add(this.btnKampanya);
            this.flpMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpMenu.Location = new System.Drawing.Point(67, 62);
            this.flpMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Size = new System.Drawing.Size(208, 676);
            this.flpMenu.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGörevlerim);
            this.panel3.Controls.Add(this.btnBilgiler);
            this.panel3.Controls.Add(this.btnProfile);
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.MaximumSize = new System.Drawing.Size(200, 151);
            this.panel3.MinimumSize = new System.Drawing.Size(200, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 50);
            this.panel3.TabIndex = 10;
            // 
            // btnGörevlerim
            // 
            this.btnGörevlerim.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGörevlerim.FlatAppearance.BorderSize = 0;
            this.btnGörevlerim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGörevlerim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGörevlerim.ForeColor = System.Drawing.Color.White;
            this.btnGörevlerim.Location = new System.Drawing.Point(0, 100);
            this.btnGörevlerim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGörevlerim.Name = "btnGörevlerim";
            this.btnGörevlerim.Size = new System.Drawing.Size(200, 50);
            this.btnGörevlerim.TabIndex = 2;
            this.btnGörevlerim.Text = "Görevlerim";
            this.btnGörevlerim.UseVisualStyleBackColor = true;
            this.btnGörevlerim.Click += new System.EventHandler(this.btnGörevlerim_Click);
            // 
            // btnBilgiler
            // 
            this.btnBilgiler.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBilgiler.FlatAppearance.BorderSize = 0;
            this.btnBilgiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBilgiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBilgiler.ForeColor = System.Drawing.Color.White;
            this.btnBilgiler.Location = new System.Drawing.Point(0, 50);
            this.btnBilgiler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBilgiler.Name = "btnBilgiler";
            this.btnBilgiler.Size = new System.Drawing.Size(200, 50);
            this.btnBilgiler.TabIndex = 1;
            this.btnBilgiler.Text = "Bilgilerim";
            this.btnBilgiler.UseVisualStyleBackColor = true;
            this.btnBilgiler.Click += new System.EventHandler(this.btnBilgiler_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.SteelBlue;
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProfile.Image = global::PL.Properties.Resources.downbutton;
            this.btnProfile.Location = new System.Drawing.Point(0, 0);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(200, 50);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "Profilim";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // pnlPersoneSekme
            // 
            this.pnlPersoneSekme.Controls.Add(this.btnGorevAta);
            this.pnlPersoneSekme.Controls.Add(this.btnPersoneller);
            this.pnlPersoneSekme.Controls.Add(this.btnPersonel);
            this.pnlPersoneSekme.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPersoneSekme.Location = new System.Drawing.Point(4, 62);
            this.pnlPersoneSekme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPersoneSekme.MaximumSize = new System.Drawing.Size(200, 158);
            this.pnlPersoneSekme.MinimumSize = new System.Drawing.Size(200, 59);
            this.pnlPersoneSekme.Name = "pnlPersoneSekme";
            this.pnlPersoneSekme.Size = new System.Drawing.Size(200, 59);
            this.pnlPersoneSekme.TabIndex = 0;
            // 
            // btnGorevAta
            // 
            this.btnGorevAta.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGorevAta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGorevAta.FlatAppearance.BorderSize = 0;
            this.btnGorevAta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGorevAta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGorevAta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGorevAta.Location = new System.Drawing.Point(0, 106);
            this.btnGorevAta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGorevAta.Name = "btnGorevAta";
            this.btnGorevAta.Size = new System.Drawing.Size(200, 52);
            this.btnGorevAta.TabIndex = 12;
            this.btnGorevAta.Text = "Görev Atama";
            this.btnGorevAta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGorevAta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGorevAta.UseVisualStyleBackColor = false;
            this.btnGorevAta.Click += new System.EventHandler(this.btnGorevAta_Click);
            // 
            // btnPersoneller
            // 
            this.btnPersoneller.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPersoneller.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersoneller.FlatAppearance.BorderSize = 0;
            this.btnPersoneller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersoneller.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersoneller.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPersoneller.Location = new System.Drawing.Point(0, 53);
            this.btnPersoneller.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPersoneller.Name = "btnPersoneller";
            this.btnPersoneller.Size = new System.Drawing.Size(200, 53);
            this.btnPersoneller.TabIndex = 11;
            this.btnPersoneller.Text = "Personeller";
            this.btnPersoneller.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersoneller.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPersoneller.UseVisualStyleBackColor = false;
            this.btnPersoneller.Click += new System.EventHandler(this.btnPersoneller_Click);
            // 
            // btnPersonel
            // 
            this.btnPersonel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPersonel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonel.FlatAppearance.BorderSize = 0;
            this.btnPersonel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPersonel.Image = global::PL.Properties.Resources.downbutton;
            this.btnPersonel.Location = new System.Drawing.Point(0, 0);
            this.btnPersonel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(200, 53);
            this.btnPersonel.TabIndex = 10;
            this.btnPersonel.Text = "Personel";
            this.btnPersonel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPersonel.UseVisualStyleBackColor = false;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // pnlUrun
            // 
            this.pnlUrun.Controls.Add(this.btnStok);
            this.pnlUrun.Controls.Add(this.btnUrunEk);
            this.pnlUrun.Controls.Add(this.btnKategoriekle);
            this.pnlUrun.Controls.Add(this.btnUrun);
            this.pnlUrun.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUrun.Location = new System.Drawing.Point(4, 129);
            this.pnlUrun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlUrun.MaximumSize = new System.Drawing.Size(200, 203);
            this.pnlUrun.MinimumSize = new System.Drawing.Size(200, 50);
            this.pnlUrun.Name = "pnlUrun";
            this.pnlUrun.Size = new System.Drawing.Size(200, 50);
            this.pnlUrun.TabIndex = 0;
            // 
            // btnStok
            // 
            this.btnStok.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStok.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStok.FlatAppearance.BorderSize = 0;
            this.btnStok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStok.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStok.Location = new System.Drawing.Point(0, 150);
            this.btnStok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStok.MaximumSize = new System.Drawing.Size(267, 50);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(200, 50);
            this.btnStok.TabIndex = 17;
            this.btnStok.Text = "Stok İşlemleri";
            this.btnStok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStok.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStok.UseVisualStyleBackColor = false;
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // btnUrunEk
            // 
            this.btnUrunEk.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUrunEk.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUrunEk.FlatAppearance.BorderSize = 0;
            this.btnUrunEk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunEk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUrunEk.Location = new System.Drawing.Point(0, 100);
            this.btnUrunEk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUrunEk.Name = "btnUrunEk";
            this.btnUrunEk.Size = new System.Drawing.Size(200, 50);
            this.btnUrunEk.TabIndex = 16;
            this.btnUrunEk.Text = "Ürün Ekle";
            this.btnUrunEk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunEk.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUrunEk.UseVisualStyleBackColor = false;
            this.btnUrunEk.Click += new System.EventHandler(this.btnUrunEk_Click);
            // 
            // btnKategoriekle
            // 
            this.btnKategoriekle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnKategoriekle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKategoriekle.FlatAppearance.BorderSize = 0;
            this.btnKategoriekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriekle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKategoriekle.Location = new System.Drawing.Point(0, 50);
            this.btnKategoriekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKategoriekle.Name = "btnKategoriekle";
            this.btnKategoriekle.Size = new System.Drawing.Size(200, 50);
            this.btnKategoriekle.TabIndex = 15;
            this.btnKategoriekle.Text = "Kategori Ekle";
            this.btnKategoriekle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKategoriekle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnKategoriekle.UseVisualStyleBackColor = false;
            this.btnKategoriekle.Click += new System.EventHandler(this.btnKategoriekle_Click);
            // 
            // btnUrun
            // 
            this.btnUrun.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUrun.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUrun.FlatAppearance.BorderSize = 0;
            this.btnUrun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrun.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUrun.Image = global::PL.Properties.Resources.downbutton;
            this.btnUrun.Location = new System.Drawing.Point(0, 0);
            this.btnUrun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUrun.Name = "btnUrun";
            this.btnUrun.Size = new System.Drawing.Size(200, 50);
            this.btnUrun.TabIndex = 14;
            this.btnUrun.Text = "Ürün";
            this.btnUrun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrun.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUrun.UseVisualStyleBackColor = false;
            this.btnUrun.Click += new System.EventHandler(this.btnUrun_Click);
            // 
            // btnKasa
            // 
            this.btnKasa.BackColor = System.Drawing.Color.SteelBlue;
            this.btnKasa.FlatAppearance.BorderSize = 0;
            this.btnKasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKasa.ForeColor = System.Drawing.Color.White;
            this.btnKasa.Location = new System.Drawing.Point(4, 187);
            this.btnKasa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.Size = new System.Drawing.Size(200, 50);
            this.btnKasa.TabIndex = 0;
            this.btnKasa.Text = "Kasa";
            this.btnKasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKasa.UseVisualStyleBackColor = false;
            this.btnKasa.Click += new System.EventHandler(this.btnUrun1_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRapor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRapor.FlatAppearance.BorderSize = 0;
            this.btnRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRapor.ForeColor = System.Drawing.Color.White;
            this.btnRapor.Location = new System.Drawing.Point(4, 245);
            this.btnRapor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(200, 50);
            this.btnRapor.TabIndex = 11;
            this.btnRapor.Text = "Rapor";
            this.btnRapor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRapor.UseVisualStyleBackColor = false;
            // 
            // btnKampanya
            // 
            this.btnKampanya.BackColor = System.Drawing.Color.SteelBlue;
            this.btnKampanya.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKampanya.FlatAppearance.BorderSize = 0;
            this.btnKampanya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKampanya.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKampanya.ForeColor = System.Drawing.Color.White;
            this.btnKampanya.Location = new System.Drawing.Point(4, 303);
            this.btnKampanya.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKampanya.Name = "btnKampanya";
            this.btnKampanya.Size = new System.Drawing.Size(200, 50);
            this.btnKampanya.TabIndex = 12;
            this.btnKampanya.Text = "Kampanya";
            this.btnKampanya.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKampanya.UseVisualStyleBackColor = false;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlFooter.Controls.Add(this.kullaniciDetay1);
            this.pnlFooter.Controls.Add(this.pnlSaat);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(275, 676);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1112, 62);
            this.pnlFooter.TabIndex = 10;
            // 
            // kullaniciDetay1
            // 
            this.kullaniciDetay1.BackColor = System.Drawing.Color.SteelBlue;
            this.kullaniciDetay1.Dock = System.Windows.Forms.DockStyle.Right;
            this.kullaniciDetay1.Location = new System.Drawing.Point(867, 0);
            this.kullaniciDetay1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.kullaniciDetay1.Name = "kullaniciDetay1";
            this.kullaniciDetay1.Size = new System.Drawing.Size(245, 62);
            this.kullaniciDetay1.TabIndex = 5;
            // 
            // pnlSaat
            // 
            this.pnlSaat.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlSaat.Controls.Add(this.lbltoday);
            this.pnlSaat.Controls.Add(this.lblTarih);
            this.pnlSaat.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSaat.Location = new System.Drawing.Point(0, 0);
            this.pnlSaat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSaat.Name = "pnlSaat";
            this.pnlSaat.Size = new System.Drawing.Size(225, 62);
            this.pnlSaat.TabIndex = 11;
            // 
            // lbltoday
            // 
            this.lbltoday.AutoSize = true;
            this.lbltoday.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbltoday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltoday.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltoday.Location = new System.Drawing.Point(0, 31);
            this.lbltoday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltoday.Name = "lbltoday";
            this.lbltoday.Size = new System.Drawing.Size(76, 31);
            this.lbltoday.TabIndex = 2;
            this.lbltoday.Text = "Tarih";
            this.lbltoday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTarih.Location = new System.Drawing.Point(0, 0);
            this.lblTarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(70, 31);
            this.lblTarih.TabIndex = 0;
            this.lblTarih.Text = "Saat";
            this.lblTarih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(275, 62);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1112, 614);
            this.pnlContent.TabIndex = 11;
            // 
            // timer4
            // 
            this.timer4.Interval = 15;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 15;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 738);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.flpMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAnasayfa";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.flpMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlPersoneSekme.ResumeLayout(false);
            this.pnlUrun.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlSaat.ResumeLayout(false);
            this.pnlSaat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnPersonicon;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBilgiler;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnGörevlerim;
        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private KullaniciDetay kullaniciDetay1;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Panel pnlSaat;
        private System.Windows.Forms.Label lbltoday;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlPersoneSekme;
        private System.Windows.Forms.Button btnGorevAta;
        private System.Windows.Forms.Button btnPersoneller;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Panel pnlUrun;
        private System.Windows.Forms.Button btnStok;
        private System.Windows.Forms.Button btnUrun;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Button btnUrunEk;
        private System.Windows.Forms.Button btnKategoriekle;
        private System.Windows.Forms.Button btnKasa;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnKampanya;
    }
}

