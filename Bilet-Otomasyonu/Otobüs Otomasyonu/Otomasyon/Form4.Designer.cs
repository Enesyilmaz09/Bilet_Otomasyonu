namespace Otomasyon
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvSeferler = new System.Windows.Forms.DataGridView();
            this.tbSeferNo = new System.Windows.Forms.TextBox();
            this.tbSeferAdi = new System.Windows.Forms.TextBox();
            this.dtpSeferTarihi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSeferSaati = new System.Windows.Forms.TextBox();
            this.tbPeronNo = new System.Windows.Forms.TextBox();
            this.cbOtobusAdi = new System.Windows.Forms.ComboBox();
            this.tbSeferUcreti = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btOtobusTemizle = new System.Windows.Forms.Button();
            this.btOtobusGuncelle = new System.Windows.Forms.Button();
            this.btOtobusSil = new System.Windows.Forms.Button();
            this.btOtobusEkle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeferler)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(294, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sefer İşlemleri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Otomasyon.Properties.Resources.islem_icon;
            this.pictureBox1.Location = new System.Drawing.Point(20, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dgvSeferler
            // 
            this.dgvSeferler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeferler.Location = new System.Drawing.Point(10, 10);
            this.dgvSeferler.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSeferler.Name = "dgvSeferler";
            this.dgvSeferler.RowTemplate.Height = 24;
            this.dgvSeferler.Size = new System.Drawing.Size(733, 143);
            this.dgvSeferler.TabIndex = 2;
            this.dgvSeferler.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSeferler_RowHeaderMouseClick);
            // 
            // tbSeferNo
            // 
            this.tbSeferNo.Location = new System.Drawing.Point(119, 43);
            this.tbSeferNo.Margin = new System.Windows.Forms.Padding(2);
            this.tbSeferNo.Multiline = true;
            this.tbSeferNo.Name = "tbSeferNo";
            this.tbSeferNo.Size = new System.Drawing.Size(150, 23);
            this.tbSeferNo.TabIndex = 1;
            // 
            // tbSeferAdi
            // 
            this.tbSeferAdi.Location = new System.Drawing.Point(119, 72);
            this.tbSeferAdi.Margin = new System.Windows.Forms.Padding(2);
            this.tbSeferAdi.Multiline = true;
            this.tbSeferAdi.Name = "tbSeferAdi";
            this.tbSeferAdi.Size = new System.Drawing.Size(150, 23);
            this.tbSeferAdi.TabIndex = 2;
            // 
            // dtpSeferTarihi
            // 
            this.dtpSeferTarihi.CalendarFont = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpSeferTarihi.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpSeferTarihi.Location = new System.Drawing.Point(119, 99);
            this.dtpSeferTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dtpSeferTarihi.Name = "dtpSeferTarihi";
            this.dtpSeferTarihi.Size = new System.Drawing.Size(150, 22);
            this.dtpSeferTarihi.TabIndex = 3;
            this.dtpSeferTarihi.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sefer Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sefer No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sefer Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(28, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sefer Saati :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(470, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Otobüs Adı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(471, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Peron No :";
            // 
            // tbSeferSaati
            // 
            this.tbSeferSaati.Location = new System.Drawing.Point(119, 128);
            this.tbSeferSaati.Margin = new System.Windows.Forms.Padding(2);
            this.tbSeferSaati.Multiline = true;
            this.tbSeferSaati.Name = "tbSeferSaati";
            this.tbSeferSaati.Size = new System.Drawing.Size(150, 23);
            this.tbSeferSaati.TabIndex = 4;
            // 
            // tbPeronNo
            // 
            this.tbPeronNo.Location = new System.Drawing.Point(558, 72);
            this.tbPeronNo.Margin = new System.Windows.Forms.Padding(2);
            this.tbPeronNo.Multiline = true;
            this.tbPeronNo.Name = "tbPeronNo";
            this.tbPeronNo.Size = new System.Drawing.Size(150, 23);
            this.tbPeronNo.TabIndex = 6;
            // 
            // cbOtobusAdi
            // 
            this.cbOtobusAdi.FormattingEnabled = true;
            this.cbOtobusAdi.Location = new System.Drawing.Point(558, 46);
            this.cbOtobusAdi.Margin = new System.Windows.Forms.Padding(2);
            this.cbOtobusAdi.Name = "cbOtobusAdi";
            this.cbOtobusAdi.Size = new System.Drawing.Size(150, 21);
            this.cbOtobusAdi.TabIndex = 5;
            // 
            // tbSeferUcreti
            // 
            this.tbSeferUcreti.Location = new System.Drawing.Point(558, 99);
            this.tbSeferUcreti.Margin = new System.Windows.Forms.Padding(2);
            this.tbSeferUcreti.Name = "tbSeferUcreti";
            this.tbSeferUcreti.Size = new System.Drawing.Size(150, 20);
            this.tbSeferUcreti.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(471, 102);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Sefer Ücreti :";
            // 
            // btOtobusTemizle
            // 
            this.btOtobusTemizle.Font = new System.Drawing.Font("Candara", 9.5F);
            this.btOtobusTemizle.Location = new System.Drawing.Point(662, 134);
            this.btOtobusTemizle.Margin = new System.Windows.Forms.Padding(2);
            this.btOtobusTemizle.Name = "btOtobusTemizle";
            this.btOtobusTemizle.Size = new System.Drawing.Size(67, 23);
            this.btOtobusTemizle.TabIndex = 11;
            this.btOtobusTemizle.Text = "Temizle";
            this.btOtobusTemizle.UseVisualStyleBackColor = true;
            this.btOtobusTemizle.Click += new System.EventHandler(this.btOtobusTemizle_Click);
            // 
            // btOtobusGuncelle
            // 
            this.btOtobusGuncelle.Font = new System.Drawing.Font("Candara", 9.5F);
            this.btOtobusGuncelle.Location = new System.Drawing.Point(590, 134);
            this.btOtobusGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btOtobusGuncelle.Name = "btOtobusGuncelle";
            this.btOtobusGuncelle.Size = new System.Drawing.Size(67, 23);
            this.btOtobusGuncelle.TabIndex = 10;
            this.btOtobusGuncelle.Text = "Güncelle";
            this.btOtobusGuncelle.UseVisualStyleBackColor = true;
            this.btOtobusGuncelle.Click += new System.EventHandler(this.btOtobusGuncelle_Click);
            // 
            // btOtobusSil
            // 
            this.btOtobusSil.Font = new System.Drawing.Font("Candara", 9.5F);
            this.btOtobusSil.Location = new System.Drawing.Point(519, 134);
            this.btOtobusSil.Margin = new System.Windows.Forms.Padding(2);
            this.btOtobusSil.Name = "btOtobusSil";
            this.btOtobusSil.Size = new System.Drawing.Size(67, 23);
            this.btOtobusSil.TabIndex = 9;
            this.btOtobusSil.Text = "Sil";
            this.btOtobusSil.UseVisualStyleBackColor = true;
            this.btOtobusSil.Click += new System.EventHandler(this.btOtobusSil_Click);
            // 
            // btOtobusEkle
            // 
            this.btOtobusEkle.Font = new System.Drawing.Font("Candara", 9.5F);
            this.btOtobusEkle.Location = new System.Drawing.Point(448, 134);
            this.btOtobusEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btOtobusEkle.Name = "btOtobusEkle";
            this.btOtobusEkle.Size = new System.Drawing.Size(67, 23);
            this.btOtobusEkle.TabIndex = 8;
            this.btOtobusEkle.Text = "Ekle";
            this.btOtobusEkle.UseVisualStyleBackColor = true;
            this.btOtobusEkle.Click += new System.EventHandler(this.btOtobusEkle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.dgvSeferler);
            this.panel1.Location = new System.Drawing.Point(32, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 163);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cbOtobusAdi);
            this.panel2.Controls.Add(this.tbSeferUcreti);
            this.panel2.Controls.Add(this.tbSeferNo);
            this.panel2.Controls.Add(this.dtpSeferTarihi);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tbSeferAdi);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbSeferSaati);
            this.panel2.Controls.Add(this.btOtobusTemizle);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbPeronNo);
            this.panel2.Controls.Add(this.btOtobusGuncelle);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btOtobusEkle);
            this.panel2.Controls.Add(this.btOtobusSil);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(32, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 185);
            this.panel2.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(16, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Sefer Bilgileri";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(811, 486);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form4";
            this.Text = "Sefer İşlemleri";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeferler)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvSeferler;
        private System.Windows.Forms.TextBox tbSeferNo;
        private System.Windows.Forms.TextBox tbSeferAdi;
        private System.Windows.Forms.DateTimePicker dtpSeferTarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSeferSaati;
        private System.Windows.Forms.TextBox tbPeronNo;
        private System.Windows.Forms.Button btOtobusTemizle;
        private System.Windows.Forms.Button btOtobusGuncelle;
        private System.Windows.Forms.Button btOtobusSil;
        private System.Windows.Forms.Button btOtobusEkle;
        private System.Windows.Forms.TextBox tbSeferUcreti;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbOtobusAdi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
    }
}