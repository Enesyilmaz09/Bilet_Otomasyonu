namespace Otomasyon
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvbilet = new System.Windows.Forms.DataGridView();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.tbkoltuk = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbsefer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbtel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbcinsiyet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbsoyadi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbmusterino = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbilet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Satılan Biletler";
            // 
            // dgvbilet
            // 
            this.dgvbilet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbilet.Location = new System.Drawing.Point(6, 8);
            this.dgvbilet.Name = "dgvbilet";
            this.dgvbilet.Size = new System.Drawing.Size(726, 150);
            this.dgvbilet.TabIndex = 1;
            this.dgvbilet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbilet_CellContentClick);
            this.dgvbilet.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvbilet_RowHeaderMouseClick);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(635, 136);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 16;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(534, 136);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(435, 136);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // tbkoltuk
            // 
            this.tbkoltuk.Location = new System.Drawing.Point(509, 100);
            this.tbkoltuk.Name = "tbkoltuk";
            this.tbkoltuk.Size = new System.Drawing.Size(100, 20);
            this.tbkoltuk.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(432, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Koltuk No : ";
            // 
            // tbsefer
            // 
            this.tbsefer.Location = new System.Drawing.Point(509, 63);
            this.tbsefer.Name = "tbsefer";
            this.tbsefer.Size = new System.Drawing.Size(100, 20);
            this.tbsefer.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(449, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Sefer : ";
            // 
            // tbtel
            // 
            this.tbtel.Location = new System.Drawing.Point(509, 23);
            this.tbtel.Name = "tbtel";
            this.tbtel.Size = new System.Drawing.Size(100, 20);
            this.tbtel.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(446, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Telefon : ";
            // 
            // tbcinsiyet
            // 
            this.tbcinsiyet.Location = new System.Drawing.Point(115, 136);
            this.tbcinsiyet.Name = "tbcinsiyet";
            this.tbcinsiyet.Size = new System.Drawing.Size(100, 20);
            this.tbcinsiyet.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(49, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cinsiyet : ";
            // 
            // tbsoyadi
            // 
            this.tbsoyadi.Location = new System.Drawing.Point(115, 95);
            this.tbsoyadi.Name = "tbsoyadi";
            this.tbsoyadi.Size = new System.Drawing.Size(100, 20);
            this.tbsoyadi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Müşteri Soyadı : ";
            // 
            // tbadi
            // 
            this.tbadi.Location = new System.Drawing.Point(115, 57);
            this.tbadi.Name = "tbadi";
            this.tbadi.Size = new System.Drawing.Size(100, 20);
            this.tbadi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Müşteri Adı : ";
            // 
            // tbmusterino
            // 
            this.tbmusterino.Location = new System.Drawing.Point(115, 17);
            this.tbmusterino.Name = "tbmusterino";
            this.tbmusterino.Size = new System.Drawing.Size(100, 20);
            this.tbmusterino.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Müşteri No : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.dgvbilet);
            this.panel1.Location = new System.Drawing.Point(36, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 165);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.tbmusterino);
            this.panel2.Controls.Add(this.btnTemizle);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbcinsiyet);
            this.panel2.Controls.Add(this.btnSil);
            this.panel2.Controls.Add(this.tbsoyadi);
            this.panel2.Controls.Add(this.btnGuncelle);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbkoltuk);
            this.panel2.Controls.Add(this.tbtel);
            this.panel2.Controls.Add(this.tbadi);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbsefer);
            this.panel2.Location = new System.Drawing.Point(36, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 175);
            this.panel2.TabIndex = 17;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Satılan Biletler";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbilet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvbilet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbsoyadi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbmusterino;
        private System.Windows.Forms.TextBox tbkoltuk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbsefer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbtel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbcinsiyet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}