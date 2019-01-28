namespace PL.Personeller
{
    partial class frmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonel));
            this.panelHeader1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelHeader2 = new System.Windows.Forms.Panel();
            this.panelPersonelKisisel = new System.Windows.Forms.Panel();
            this.dateİseGiris = new System.Windows.Forms.DateTimePicker();
            this.cbCinsiyet = new System.Windows.Forms.ComboBox();
            this.cbEngel = new System.Windows.Forms.ComboBox();
            this.cbMedenıHal = new System.Windows.Forms.ComboBox();
            this.dateİstenCikis = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cbDogumYeri = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMedeniHal = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtTCKNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbAskerlik = new System.Windows.Forms.ComboBox();
            this.txtEngelAciklama = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.DateTimePicker();
            this.cbEgitim = new System.Windows.Forms.ComboBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.panelPersonelResim = new System.Windows.Forms.Panel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.panelHeader1.SuspendLayout();
            this.panelPersonelKisisel.SuspendLayout();
            this.panelPersonelResim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader1
            // 
            this.panelHeader1.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader1.Controls.Add(this.label2);
            this.panelHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader1.Location = new System.Drawing.Point(0, 0);
            this.panelHeader1.Name = "panelHeader1";
            this.panelHeader1.Size = new System.Drawing.Size(1054, 48);
            this.panelHeader1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(389, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "PERSONEL EKLE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(530, -22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 101;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(257, -18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 93;
            this.label3.Text = "TC No";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panelHeader2
            // 
            this.panelHeader2.BackColor = System.Drawing.Color.White;
            this.panelHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader2.Location = new System.Drawing.Point(0, 48);
            this.panelHeader2.Name = "panelHeader2";
            this.panelHeader2.Size = new System.Drawing.Size(1054, 80);
            this.panelHeader2.TabIndex = 102;
            // 
            // panelPersonelKisisel
            // 
            this.panelPersonelKisisel.Controls.Add(this.dateİseGiris);
            this.panelPersonelKisisel.Controls.Add(this.cbCinsiyet);
            this.panelPersonelKisisel.Controls.Add(this.cbEngel);
            this.panelPersonelKisisel.Controls.Add(this.cbMedenıHal);
            this.panelPersonelKisisel.Controls.Add(this.dateİstenCikis);
            this.panelPersonelKisisel.Controls.Add(this.label8);
            this.panelPersonelKisisel.Controls.Add(this.label7);
            this.panelPersonelKisisel.Controls.Add(this.label9);
            this.panelPersonelKisisel.Controls.Add(this.label22);
            this.panelPersonelKisisel.Controls.Add(this.cbDogumYeri);
            this.panelPersonelKisisel.Controls.Add(this.label6);
            this.panelPersonelKisisel.Controls.Add(this.cbMedeniHal);
            this.panelPersonelKisisel.Controls.Add(this.label23);
            this.panelPersonelKisisel.Controls.Add(this.txtTCKNo);
            this.panelPersonelKisisel.Controls.Add(this.label5);
            this.panelPersonelKisisel.Controls.Add(this.txtTelefon);
            this.panelPersonelKisisel.Controls.Add(this.label1);
            this.panelPersonelKisisel.Controls.Add(this.label14);
            this.panelPersonelKisisel.Controls.Add(this.cbAskerlik);
            this.panelPersonelKisisel.Controls.Add(this.txtEngelAciklama);
            this.panelPersonelKisisel.Controls.Add(this.txt);
            this.panelPersonelKisisel.Controls.Add(this.cbEgitim);
            this.panelPersonelKisisel.Controls.Add(this.txtAdres);
            this.panelPersonelKisisel.Controls.Add(this.txtEmail);
            this.panelPersonelKisisel.Controls.Add(this.label15);
            this.panelPersonelKisisel.Controls.Add(this.label16);
            this.panelPersonelKisisel.Controls.Add(this.label17);
            this.panelPersonelKisisel.Controls.Add(this.label18);
            this.panelPersonelKisisel.Controls.Add(this.label19);
            this.panelPersonelKisisel.Controls.Add(this.label20);
            this.panelPersonelKisisel.Controls.Add(this.label21);
            this.panelPersonelKisisel.Controls.Add(this.txtSoyad);
            this.panelPersonelKisisel.Controls.Add(this.txtAd);
            this.panelPersonelKisisel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPersonelKisisel.Location = new System.Drawing.Point(0, 128);
            this.panelPersonelKisisel.Name = "panelPersonelKisisel";
            this.panelPersonelKisisel.Size = new System.Drawing.Size(663, 401);
            this.panelPersonelKisisel.TabIndex = 103;
            // 
            // dateİseGiris
            // 
            this.dateİseGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateİseGiris.Location = new System.Drawing.Point(466, 323);
            this.dateİseGiris.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dateİseGiris.Name = "dateİseGiris";
            this.dateİseGiris.Size = new System.Drawing.Size(157, 23);
            this.dateİseGiris.TabIndex = 185;
            // 
            // cbCinsiyet
            // 
            this.cbCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbCinsiyet.FormattingEnabled = true;
            this.cbCinsiyet.Items.AddRange(new object[] {
            "E",
            "K"});
            this.cbCinsiyet.Location = new System.Drawing.Point(466, 7);
            this.cbCinsiyet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cbCinsiyet.Name = "cbCinsiyet";
            this.cbCinsiyet.Size = new System.Drawing.Size(157, 28);
            this.cbCinsiyet.TabIndex = 173;
            // 
            // cbEngel
            // 
            this.cbEngel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbEngel.FormattingEnabled = true;
            this.cbEngel.Items.AddRange(new object[] {
            "Yok",
            "Var"});
            this.cbEngel.Location = new System.Drawing.Point(466, 159);
            this.cbEngel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cbEngel.Name = "cbEngel";
            this.cbEngel.Size = new System.Drawing.Size(157, 28);
            this.cbEngel.TabIndex = 179;
            // 
            // cbMedenıHal
            // 
            this.cbMedenıHal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMedenıHal.FormattingEnabled = true;
            this.cbMedenıHal.Items.AddRange(new object[] {
            "Evli",
            "Bekar"});
            this.cbMedenıHal.Location = new System.Drawing.Point(466, 44);
            this.cbMedenıHal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cbMedenıHal.Name = "cbMedenıHal";
            this.cbMedenıHal.Size = new System.Drawing.Size(157, 28);
            this.cbMedenıHal.TabIndex = 174;
            // 
            // dateİstenCikis
            // 
            this.dateİstenCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateİstenCikis.Location = new System.Drawing.Point(466, 352);
            this.dateİstenCikis.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dateİstenCikis.Name = "dateİstenCikis";
            this.dateİstenCikis.Size = new System.Drawing.Size(157, 23);
            this.dateİstenCikis.TabIndex = 186;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(330, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 176;
            this.label8.Text = "Medeni Hali";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(329, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 181;
            this.label7.Text = "Askerlik Durumu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(330, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 175;
            this.label9.Text = "Cinsiyet";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(331, 354);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(124, 20);
            this.label22.TabIndex = 188;
            this.label22.Text = "İşten Çıkış Tarihi";
            // 
            // cbDogumYeri
            // 
            this.cbDogumYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbDogumYeri.FormattingEnabled = true;
            this.cbDogumYeri.Items.AddRange(new object[] {
            "İlkokul",
            "Ortaokul",
            "Lise",
            "Lisans",
            "Yüksek Lisans"});
            this.cbDogumYeri.Location = new System.Drawing.Point(113, 148);
            this.cbDogumYeri.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cbDogumYeri.Name = "cbDogumYeri";
            this.cbDogumYeri.Size = new System.Drawing.Size(134, 28);
            this.cbDogumYeri.TabIndex = 172;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(331, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 182;
            this.label6.Text = "Eğitim ";
            // 
            // cbMedeniHal
            // 
            this.cbMedeniHal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMedeniHal.FormattingEnabled = true;
            this.cbMedeniHal.Items.AddRange(new object[] {
            "Evli",
            "Bekar"});
            this.cbMedeniHal.Location = new System.Drawing.Point(113, 413);
            this.cbMedeniHal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cbMedeniHal.Name = "cbMedeniHal";
            this.cbMedeniHal.Size = new System.Drawing.Size(139, 28);
            this.cbMedeniHal.TabIndex = 171;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(332, 325);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(109, 20);
            this.label23.TabIndex = 187;
            this.label23.Text = "İşe Giriş Tarihi";
            // 
            // txtTCKNo
            // 
            this.txtTCKNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTCKNo.Location = new System.Drawing.Point(113, 10);
            this.txtTCKNo.Name = "txtTCKNo";
            this.txtTCKNo.Size = new System.Drawing.Size(135, 26);
            this.txtTCKNo.TabIndex = 168;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(330, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 183;
            this.label5.Text = "Engel Durumu";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefon.Location = new System.Drawing.Point(113, 185);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(135, 26);
            this.txtTelefon.TabIndex = 158;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(329, 201);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 60);
            this.label1.TabIndex = 184;
            this.label1.Text = "Engel Durumu\r\nVar ise \r\nAçıklama";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(9, 156);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 20);
            this.label14.TabIndex = 169;
            this.label14.Text = "Doğum Yeri";
            // 
            // cbAskerlik
            // 
            this.cbAskerlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbAskerlik.FormattingEnabled = true;
            this.cbAskerlik.Items.AddRange(new object[] {
            "Muaf",
            "Yapıldı",
            "Yapılmadı"});
            this.cbAskerlik.Location = new System.Drawing.Point(466, 79);
            this.cbAskerlik.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cbAskerlik.Name = "cbAskerlik";
            this.cbAskerlik.Size = new System.Drawing.Size(157, 28);
            this.cbAskerlik.TabIndex = 177;
            // 
            // txtEngelAciklama
            // 
            this.txtEngelAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEngelAciklama.Location = new System.Drawing.Point(466, 200);
            this.txtEngelAciklama.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtEngelAciklama.Multiline = true;
            this.txtEngelAciklama.Name = "txtEngelAciklama";
            this.txtEngelAciklama.Size = new System.Drawing.Size(159, 113);
            this.txtEngelAciklama.TabIndex = 180;
            // 
            // txt
            // 
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt.Location = new System.Drawing.Point(113, 115);
            this.txt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(135, 26);
            this.txt.TabIndex = 157;
            // 
            // cbEgitim
            // 
            this.cbEgitim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbEgitim.FormattingEnabled = true;
            this.cbEgitim.Items.AddRange(new object[] {
            "İlkokul",
            "Ortaokul",
            "Lise",
            "Lisans",
            "Yüksek Lisans"});
            this.cbEgitim.Location = new System.Drawing.Point(466, 119);
            this.cbEgitim.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cbEgitim.Name = "cbEgitim";
            this.cbEgitim.Size = new System.Drawing.Size(157, 28);
            this.cbEgitim.TabIndex = 178;
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(113, 259);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(135, 115);
            this.txtAdres.TabIndex = 160;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.Location = new System.Drawing.Point(113, 221);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(133, 26);
            this.txtEmail.TabIndex = 159;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(11, 258);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 20);
            this.label15.TabIndex = 167;
            this.label15.Text = "Adres";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(11, 231);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 20);
            this.label16.TabIndex = 166;
            this.label16.Text = "E-mail";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(12, 192);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 20);
            this.label17.TabIndex = 165;
            this.label17.Text = "Cep Tel";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(10, 120);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(103, 20);
            this.label18.TabIndex = 164;
            this.label18.Text = "Doğum Tarihi";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(11, 19);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 20);
            this.label19.TabIndex = 163;
            this.label19.Text = "TC No";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(14, 82);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 20);
            this.label20.TabIndex = 162;
            this.label20.Text = "Soyad";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(14, 51);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 20);
            this.label21.TabIndex = 161;
            this.label21.Text = "Ad";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(113, 79);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(135, 26);
            this.txtSoyad.TabIndex = 156;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(113, 44);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(135, 26);
            this.txtAd.TabIndex = 155;
            this.txtAd.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // panelPersonelResim
            // 
            this.panelPersonelResim.Controls.Add(this.btnKaydet);
            this.panelPersonelResim.Controls.Add(this.txtKullaniciSifre);
            this.panelPersonelResim.Controls.Add(this.txtKullaniciAd);
            this.panelPersonelResim.Controls.Add(this.label24);
            this.panelPersonelResim.Controls.Add(this.label25);
            this.panelPersonelResim.Controls.Add(this.pbFoto);
            this.panelPersonelResim.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPersonelResim.Location = new System.Drawing.Point(663, 128);
            this.panelPersonelResim.Name = "panelPersonelResim";
            this.panelPersonelResim.Size = new System.Drawing.Size(527, 401);
            this.panelPersonelResim.TabIndex = 104;
            this.panelPersonelResim.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPersonelResim_Paint);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.SteelBlue;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(168, 314);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(148, 31);
            this.btnKaydet.TabIndex = 180;
            this.btnKaydet.Text = " KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.Location = new System.Drawing.Point(168, 271);
            this.txtKullaniciSifre.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtKullaniciSifre.Multiline = true;
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.ReadOnly = true;
            this.txtKullaniciSifre.Size = new System.Drawing.Size(148, 30);
            this.txtKullaniciSifre.TabIndex = 177;
            this.txtKullaniciSifre.Visible = false;
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(168, 231);
            this.txtKullaniciAd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtKullaniciAd.Multiline = true;
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.ReadOnly = true;
            this.txtKullaniciAd.Size = new System.Drawing.Size(148, 28);
            this.txtKullaniciAd.TabIndex = 176;
            this.txtKullaniciAd.Visible = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.Location = new System.Drawing.Point(66, 237);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(84, 17);
            this.label24.TabIndex = 178;
            this.label24.Text = "Kullanıcı Adı";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.Location = new System.Drawing.Point(66, 277);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(93, 17);
            this.label25.TabIndex = 179;
            this.label25.Text = "Kullanıcı Şifre";
            // 
            // pbFoto
            // 
            this.pbFoto.ErrorImage = null;
            this.pbFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbFoto.Image")));
            this.pbFoto.ImageLocation = "";
            this.pbFoto.Location = new System.Drawing.Point(158, 6);
            this.pbFoto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(175, 206);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 175;
            this.pbFoto.TabStop = false;
            // 
            // frmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 529);
            this.Controls.Add(this.panelPersonelResim);
            this.Controls.Add(this.panelPersonelKisisel);
            this.Controls.Add(this.panelHeader2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPersonel";
            this.Text = "frmPersonel";
            this.panelHeader1.ResumeLayout(false);
            this.panelHeader1.PerformLayout();
            this.panelPersonelKisisel.ResumeLayout(false);
            this.panelPersonelKisisel.PerformLayout();
            this.panelPersonelResim.ResumeLayout(false);
            this.panelPersonelResim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panelHeader2;
        private System.Windows.Forms.Panel panelPersonelKisisel;
        private System.Windows.Forms.Panel panelPersonelResim;
        private System.Windows.Forms.ComboBox cbDogumYeri;
        private System.Windows.Forms.ComboBox cbMedeniHal;
        private System.Windows.Forms.TextBox txtTCKNo;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker txt;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.ComboBox cbCinsiyet;
        private System.Windows.Forms.ComboBox cbMedenıHal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateİseGiris;
        private System.Windows.Forms.ComboBox cbEngel;
        private System.Windows.Forms.DateTimePicker dateİstenCikis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAskerlik;
        private System.Windows.Forms.TextBox txtEngelAciklama;
        private System.Windows.Forms.ComboBox cbEgitim;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.TextBox txtKullaniciSifre;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnKaydet;
    }
}