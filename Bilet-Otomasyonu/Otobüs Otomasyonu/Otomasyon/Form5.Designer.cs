namespace Otomasyon
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbBiletRezervasyon = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.tbKoltukNo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbSeferNo = new System.Windows.Forms.TextBox();
            this.tbSeferUcreti = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbSeferAdi = new System.Windows.Forms.TextBox();
            this.tbPeronNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbSeferTarihi = new System.Windows.Forms.TextBox();
            this.tbOtobusAdi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSeferSaati = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Müşteri = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMusteriTelNo = new System.Windows.Forms.TextBox();
            this.rbKadın = new System.Windows.Forms.RadioButton();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.tbMusteriNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMusteriSoyadi = new System.Windows.Forms.TextBox();
            this.tbMusteriAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvSeferler2 = new System.Windows.Forms.DataGridView();
            this.btRezervasyonYap = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbBiletRezervasyon.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeferler2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Otomasyon.Properties.Resources.bilet_icon;
            this.pictureBox1.Location = new System.Drawing.Point(20, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(278, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bilet Rezervasyon";
            // 
            // gbBiletRezervasyon
            // 
            this.gbBiletRezervasyon.BackColor = System.Drawing.Color.Transparent;
            this.gbBiletRezervasyon.Controls.Add(this.panel3);
            this.gbBiletRezervasyon.Controls.Add(this.panel2);
            this.gbBiletRezervasyon.Controls.Add(this.panel1);
            this.gbBiletRezervasyon.Controls.Add(this.btRezervasyonYap);
            this.gbBiletRezervasyon.Controls.Add(this.label15);
            this.gbBiletRezervasyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbBiletRezervasyon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbBiletRezervasyon.Location = new System.Drawing.Point(20, 73);
            this.gbBiletRezervasyon.Margin = new System.Windows.Forms.Padding(2);
            this.gbBiletRezervasyon.Name = "gbBiletRezervasyon";
            this.gbBiletRezervasyon.Padding = new System.Windows.Forms.Padding(2);
            this.gbBiletRezervasyon.Size = new System.Drawing.Size(810, 616);
            this.gbBiletRezervasyon.TabIndex = 4;
            this.gbBiletRezervasyon.TabStop = false;
            this.gbBiletRezervasyon.Text = "Bilet Rezervasyon";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.tbKoltukNo);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.tbSeferNo);
            this.panel3.Controls.Add(this.tbSeferUcreti);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.tbSeferAdi);
            this.panel3.Controls.Add(this.tbPeronNo);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.tbSeferTarihi);
            this.panel3.Controls.Add(this.tbOtobusAdi);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.tbSeferSaati);
            this.panel3.Location = new System.Drawing.Point(419, 306);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(359, 234);
            this.panel3.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(10, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 18);
            this.label17.TabIndex = 4;
            this.label17.Text = "Sefer";
            // 
            // tbKoltukNo
            // 
            this.tbKoltukNo.FormattingEnabled = true;
            this.tbKoltukNo.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.tbKoltukNo.Location = new System.Drawing.Point(191, 195);
            this.tbKoltukNo.Name = "tbKoltukNo";
            this.tbKoltukNo.Size = new System.Drawing.Size(112, 25);
            this.tbKoltukNo.TabIndex = 3;
            this.tbKoltukNo.SelectedIndexChanged += new System.EventHandler(this.tbKoltukNo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(95, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sefer No :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(95, 170);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Sefer Ücreti :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(95, 195);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 17);
            this.label16.TabIndex = 2;
            this.label16.Text = "Koltuk No :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(95, 145);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Peron No :";
            // 
            // tbSeferNo
            // 
            this.tbSeferNo.Location = new System.Drawing.Point(191, 16);
            this.tbSeferNo.Margin = new System.Windows.Forms.Padding(2);
            this.tbSeferNo.Name = "tbSeferNo";
            this.tbSeferNo.ReadOnly = true;
            this.tbSeferNo.Size = new System.Drawing.Size(112, 23);
            this.tbSeferNo.TabIndex = 1;
            // 
            // tbSeferUcreti
            // 
            this.tbSeferUcreti.Location = new System.Drawing.Point(191, 167);
            this.tbSeferUcreti.Margin = new System.Windows.Forms.Padding(2);
            this.tbSeferUcreti.Name = "tbSeferUcreti";
            this.tbSeferUcreti.ReadOnly = true;
            this.tbSeferUcreti.Size = new System.Drawing.Size(112, 23);
            this.tbSeferUcreti.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(95, 119);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Otobüs Adı :";
            // 
            // tbSeferAdi
            // 
            this.tbSeferAdi.Location = new System.Drawing.Point(191, 41);
            this.tbSeferAdi.Margin = new System.Windows.Forms.Padding(2);
            this.tbSeferAdi.Name = "tbSeferAdi";
            this.tbSeferAdi.ReadOnly = true;
            this.tbSeferAdi.Size = new System.Drawing.Size(112, 23);
            this.tbSeferAdi.TabIndex = 1;
            // 
            // tbPeronNo
            // 
            this.tbPeronNo.Location = new System.Drawing.Point(191, 142);
            this.tbPeronNo.Margin = new System.Windows.Forms.Padding(2);
            this.tbPeronNo.Name = "tbPeronNo";
            this.tbPeronNo.ReadOnly = true;
            this.tbPeronNo.Size = new System.Drawing.Size(112, 23);
            this.tbPeronNo.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(95, 94);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Sefer Saati :";
            // 
            // tbSeferTarihi
            // 
            this.tbSeferTarihi.Location = new System.Drawing.Point(191, 67);
            this.tbSeferTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.tbSeferTarihi.Name = "tbSeferTarihi";
            this.tbSeferTarihi.ReadOnly = true;
            this.tbSeferTarihi.Size = new System.Drawing.Size(112, 23);
            this.tbSeferTarihi.TabIndex = 1;
            // 
            // tbOtobusAdi
            // 
            this.tbOtobusAdi.Location = new System.Drawing.Point(191, 117);
            this.tbOtobusAdi.Margin = new System.Windows.Forms.Padding(2);
            this.tbOtobusAdi.Name = "tbOtobusAdi";
            this.tbOtobusAdi.ReadOnly = true;
            this.tbOtobusAdi.Size = new System.Drawing.Size(112, 23);
            this.tbOtobusAdi.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(95, 69);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Sefer Tarihi :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(95, 44);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sefer Adı :";
            // 
            // tbSeferSaati
            // 
            this.tbSeferSaati.Location = new System.Drawing.Point(191, 92);
            this.tbSeferSaati.Margin = new System.Windows.Forms.Padding(2);
            this.tbSeferSaati.Name = "tbSeferSaati";
            this.tbSeferSaati.ReadOnly = true;
            this.tbSeferSaati.Size = new System.Drawing.Size(112, 23);
            this.tbSeferSaati.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.Müşteri);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbMusteriTelNo);
            this.panel2.Controls.Add(this.rbKadın);
            this.panel2.Controls.Add(this.rbErkek);
            this.panel2.Controls.Add(this.tbMusteriNo);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbMusteriSoyadi);
            this.panel2.Controls.Add(this.tbMusteriAdi);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(36, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 233);
            this.panel2.TabIndex = 11;
            // 
            // Müşteri
            // 
            this.Müşteri.AutoSize = true;
            this.Müşteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Müşteri.ForeColor = System.Drawing.Color.Black;
            this.Müşteri.Location = new System.Drawing.Point(9, 6);
            this.Müşteri.Name = "Müşteri";
            this.Müşteri.Size = new System.Drawing.Size(64, 18);
            this.Müşteri.TabIndex = 7;
            this.Müşteri.Text = "Müşteri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(69, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "No :";
            // 
            // tbMusteriTelNo
            // 
            this.tbMusteriTelNo.Location = new System.Drawing.Point(164, 184);
            this.tbMusteriTelNo.Margin = new System.Windows.Forms.Padding(2);
            this.tbMusteriTelNo.MaxLength = 10;
            this.tbMusteriTelNo.Name = "tbMusteriTelNo";
            this.tbMusteriTelNo.Size = new System.Drawing.Size(112, 23);
            this.tbMusteriTelNo.TabIndex = 5;
            // 
            // rbKadın
            // 
            this.rbKadın.AccessibleDescription = "";
            this.rbKadın.AutoSize = true;
            this.rbKadın.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKadın.Location = new System.Drawing.Point(222, 150);
            this.rbKadın.Margin = new System.Windows.Forms.Padding(2);
            this.rbKadın.Name = "rbKadın";
            this.rbKadın.Size = new System.Drawing.Size(60, 21);
            this.rbKadın.TabIndex = 4;
            this.rbKadın.TabStop = true;
            this.rbKadın.Text = "Kadın";
            this.rbKadın.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            this.rbErkek.AccessibleDescription = "";
            this.rbErkek.AutoSize = true;
            this.rbErkek.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbErkek.Location = new System.Drawing.Point(164, 150);
            this.rbErkek.Margin = new System.Windows.Forms.Padding(2);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(59, 21);
            this.rbErkek.TabIndex = 3;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // tbMusteriNo
            // 
            this.tbMusteriNo.Location = new System.Drawing.Point(164, 44);
            this.tbMusteriNo.Margin = new System.Windows.Forms.Padding(2);
            this.tbMusteriNo.Name = "tbMusteriNo";
            this.tbMusteriNo.ReadOnly = true;
            this.tbMusteriNo.Size = new System.Drawing.Size(112, 23);
            this.tbMusteriNo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(69, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cinsiyeti :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(69, 186);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Telefon No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(69, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyadı :";
            // 
            // tbMusteriSoyadi
            // 
            this.tbMusteriSoyadi.Location = new System.Drawing.Point(164, 114);
            this.tbMusteriSoyadi.Margin = new System.Windows.Forms.Padding(2);
            this.tbMusteriSoyadi.Name = "tbMusteriSoyadi";
            this.tbMusteriSoyadi.Size = new System.Drawing.Size(112, 23);
            this.tbMusteriSoyadi.TabIndex = 2;
            // 
            // tbMusteriAdi
            // 
            this.tbMusteriAdi.Location = new System.Drawing.Point(164, 79);
            this.tbMusteriAdi.Margin = new System.Windows.Forms.Padding(2);
            this.tbMusteriAdi.Name = "tbMusteriAdi";
            this.tbMusteriAdi.Size = new System.Drawing.Size(112, 23);
            this.tbMusteriAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(69, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adı :";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dgvSeferler2);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(22, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 226);
            this.panel1.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(11, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "* Sefer seçimini buradan yapınız.";
            // 
            // dgvSeferler2
            // 
            this.dgvSeferler2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeferler2.Location = new System.Drawing.Point(14, 49);
            this.dgvSeferler2.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSeferler2.Name = "dgvSeferler2";
            this.dgvSeferler2.RowTemplate.Height = 24;
            this.dgvSeferler2.Size = new System.Drawing.Size(735, 158);
            this.dgvSeferler2.TabIndex = 2;
            this.dgvSeferler2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSeferler2_RowHeaderMouseClick);
            // 
            // btRezervasyonYap
            // 
            this.btRezervasyonYap.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btRezervasyonYap.ForeColor = System.Drawing.Color.Black;
            this.btRezervasyonYap.Location = new System.Drawing.Point(345, 570);
            this.btRezervasyonYap.Margin = new System.Windows.Forms.Padding(2);
            this.btRezervasyonYap.Name = "btRezervasyonYap";
            this.btRezervasyonYap.Size = new System.Drawing.Size(126, 32);
            this.btRezervasyonYap.TabIndex = 6;
            this.btRezervasyonYap.Text = "Rezervasyon Yap";
            this.btRezervasyonYap.UseVisualStyleBackColor = true;
            this.btRezervasyonYap.Click += new System.EventHandler(this.btRezervasyonYap_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(284, 543);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(263, 17);
            this.label15.TabIndex = 9;
            this.label15.Text = "* Müşteri ve sefer bilgilerini kontrol ediniz.";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 719);
            this.Controls.Add(this.gbBiletRezervasyon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form5";
            this.Text = "Bilet Satış";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbBiletRezervasyon.ResumeLayout(false);
            this.gbBiletRezervasyon.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeferler2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbBiletRezervasyon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMusteriTelNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMusteriNo;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.TextBox tbMusteriAdi;
        private System.Windows.Forms.TextBox tbMusteriSoyadi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbKadın;
        private System.Windows.Forms.TextBox tbSeferUcreti;
        private System.Windows.Forms.TextBox tbPeronNo;
        private System.Windows.Forms.TextBox tbOtobusAdi;
        private System.Windows.Forms.TextBox tbSeferSaati;
        private System.Windows.Forms.TextBox tbSeferTarihi;
        private System.Windows.Forms.TextBox tbSeferAdi;
        private System.Windows.Forms.TextBox tbSeferNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btRezervasyonYap;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox tbKoltukNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvSeferler2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Müşteri;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}