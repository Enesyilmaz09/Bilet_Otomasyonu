namespace Otomasyon
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOtobusler = new System.Windows.Forms.DataGridView();
            this.tbOtobusID = new System.Windows.Forms.TextBox();
            this.tbOtobusAdi = new System.Windows.Forms.TextBox();
            this.tbKoltukAdedi = new System.Windows.Forms.TextBox();
            this.tbKoltukDuzeni = new System.Windows.Forms.TextBox();
            this.tbBagajHacmi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btOtobusTemizle = new System.Windows.Forms.Button();
            this.btOtobusGuncelle = new System.Windows.Forms.Button();
            this.btOtobusSil = new System.Windows.Forms.Button();
            this.btOtobusEkle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtobusler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(172, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Otobüs İşlemleri";
            // 
            // dgvOtobusler
            // 
            this.dgvOtobusler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOtobusler.Location = new System.Drawing.Point(10, 8);
            this.dgvOtobusler.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOtobusler.Name = "dgvOtobusler";
            this.dgvOtobusler.RowTemplate.Height = 24;
            this.dgvOtobusler.Size = new System.Drawing.Size(533, 162);
            this.dgvOtobusler.TabIndex = 2;
            this.dgvOtobusler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOtobusler_CellContentClick);
            this.dgvOtobusler.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOtobusler_RowHeaderMouseClick);
            // 
            // tbOtobusID
            // 
            this.tbOtobusID.Location = new System.Drawing.Point(119, 41);
            this.tbOtobusID.Margin = new System.Windows.Forms.Padding(2);
            this.tbOtobusID.Name = "tbOtobusID";
            this.tbOtobusID.ReadOnly = true;
            this.tbOtobusID.Size = new System.Drawing.Size(117, 20);
            this.tbOtobusID.TabIndex = 1;
            // 
            // tbOtobusAdi
            // 
            this.tbOtobusAdi.Location = new System.Drawing.Point(119, 73);
            this.tbOtobusAdi.Margin = new System.Windows.Forms.Padding(2);
            this.tbOtobusAdi.Name = "tbOtobusAdi";
            this.tbOtobusAdi.Size = new System.Drawing.Size(117, 20);
            this.tbOtobusAdi.TabIndex = 2;
            // 
            // tbKoltukAdedi
            // 
            this.tbKoltukAdedi.Location = new System.Drawing.Point(119, 107);
            this.tbKoltukAdedi.Margin = new System.Windows.Forms.Padding(2);
            this.tbKoltukAdedi.Name = "tbKoltukAdedi";
            this.tbKoltukAdedi.Size = new System.Drawing.Size(117, 20);
            this.tbKoltukAdedi.TabIndex = 3;
            this.tbKoltukAdedi.TextChanged += new System.EventHandler(this.tbKoltukAdedi_TextChanged);
            // 
            // tbKoltukDuzeni
            // 
            this.tbKoltukDuzeni.Location = new System.Drawing.Point(397, 41);
            this.tbKoltukDuzeni.Margin = new System.Windows.Forms.Padding(2);
            this.tbKoltukDuzeni.Name = "tbKoltukDuzeni";
            this.tbKoltukDuzeni.Size = new System.Drawing.Size(117, 20);
            this.tbKoltukDuzeni.TabIndex = 4;
            // 
            // tbBagajHacmi
            // 
            this.tbBagajHacmi.Location = new System.Drawing.Point(397, 73);
            this.tbBagajHacmi.Margin = new System.Windows.Forms.Padding(2);
            this.tbBagajHacmi.Name = "tbBagajHacmi";
            this.tbBagajHacmi.Size = new System.Drawing.Size(117, 20);
            this.tbBagajHacmi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Otobüs ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Otobüs Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Koltuk Adedi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(278, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Koltuk Düzeni :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(278, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Bagaj Hacmi (m³) :";
            // 
            // btOtobusTemizle
            // 
            this.btOtobusTemizle.Font = new System.Drawing.Font("Candara", 9.5F);
            this.btOtobusTemizle.Location = new System.Drawing.Point(469, 107);
            this.btOtobusTemizle.Margin = new System.Windows.Forms.Padding(2);
            this.btOtobusTemizle.Name = "btOtobusTemizle";
            this.btOtobusTemizle.Size = new System.Drawing.Size(67, 23);
            this.btOtobusTemizle.TabIndex = 9;
            this.btOtobusTemizle.Text = "Temizle";
            this.btOtobusTemizle.UseVisualStyleBackColor = true;
            this.btOtobusTemizle.Click += new System.EventHandler(this.btOtobusTemizle_Click);
            // 
            // btOtobusGuncelle
            // 
            this.btOtobusGuncelle.Font = new System.Drawing.Font("Candara", 9.5F);
            this.btOtobusGuncelle.Location = new System.Drawing.Point(397, 106);
            this.btOtobusGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btOtobusGuncelle.Name = "btOtobusGuncelle";
            this.btOtobusGuncelle.Size = new System.Drawing.Size(67, 23);
            this.btOtobusGuncelle.TabIndex = 8;
            this.btOtobusGuncelle.Text = "Güncelle";
            this.btOtobusGuncelle.UseVisualStyleBackColor = true;
            this.btOtobusGuncelle.Click += new System.EventHandler(this.btOtobusGuncelle_Click);
            // 
            // btOtobusSil
            // 
            this.btOtobusSil.Font = new System.Drawing.Font("Candara", 9.5F);
            this.btOtobusSil.Location = new System.Drawing.Point(326, 106);
            this.btOtobusSil.Margin = new System.Windows.Forms.Padding(2);
            this.btOtobusSil.Name = "btOtobusSil";
            this.btOtobusSil.Size = new System.Drawing.Size(67, 23);
            this.btOtobusSil.TabIndex = 7;
            this.btOtobusSil.Text = "Sil";
            this.btOtobusSil.UseVisualStyleBackColor = true;
            this.btOtobusSil.Click += new System.EventHandler(this.btOtobusSil_Click);
            // 
            // btOtobusEkle
            // 
            this.btOtobusEkle.Font = new System.Drawing.Font("Candara", 9.5F);
            this.btOtobusEkle.Location = new System.Drawing.Point(255, 106);
            this.btOtobusEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btOtobusEkle.Name = "btOtobusEkle";
            this.btOtobusEkle.Size = new System.Drawing.Size(67, 23);
            this.btOtobusEkle.TabIndex = 6;
            this.btOtobusEkle.Text = "Ekle";
            this.btOtobusEkle.UseVisualStyleBackColor = true;
            this.btOtobusEkle.Click += new System.EventHandler(this.btOtobusEkle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Otomasyon.Properties.Resources.islem_icon;
            this.pictureBox1.Location = new System.Drawing.Point(27, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.dgvOtobusler);
            this.panel1.Location = new System.Drawing.Point(23, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 179);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btOtobusTemizle);
            this.panel2.Controls.Add(this.tbOtobusID);
            this.panel2.Controls.Add(this.btOtobusGuncelle);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbOtobusAdi);
            this.panel2.Controls.Add(this.btOtobusSil);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbBagajHacmi);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btOtobusEkle);
            this.panel2.Controls.Add(this.tbKoltukAdedi);
            this.panel2.Controls.Add(this.tbKoltukDuzeni);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(27, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 157);
            this.panel2.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(11, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Otobüs Bilgileri";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 465);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Otobüs İşlemleri";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtobusler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOtobusler;
        private System.Windows.Forms.TextBox tbOtobusID;
        private System.Windows.Forms.TextBox tbOtobusAdi;
        private System.Windows.Forms.TextBox tbKoltukAdedi;
        private System.Windows.Forms.TextBox tbKoltukDuzeni;
        private System.Windows.Forms.TextBox tbBagajHacmi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btOtobusTemizle;
        private System.Windows.Forms.Button btOtobusGuncelle;
        private System.Windows.Forms.Button btOtobusSil;
        private System.Windows.Forms.Button btOtobusEkle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
    }
}