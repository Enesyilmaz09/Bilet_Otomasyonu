namespace Otomasyon
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKAdi = new System.Windows.Forms.TextBox();
            this.tbParola = new System.Windows.Forms.TextBox();
            this.btGiris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(154, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(154, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Parola :";
            // 
            // tbKAdi
            // 
            this.tbKAdi.Location = new System.Drawing.Point(264, 78);
            this.tbKAdi.Margin = new System.Windows.Forms.Padding(2);
            this.tbKAdi.Name = "tbKAdi";
            this.tbKAdi.Size = new System.Drawing.Size(110, 20);
            this.tbKAdi.TabIndex = 1;
            // 
            // tbParola
            // 
            this.tbParola.Location = new System.Drawing.Point(264, 115);
            this.tbParola.Margin = new System.Windows.Forms.Padding(2);
            this.tbParola.Name = "tbParola";
            this.tbParola.PasswordChar = '•';
            this.tbParola.Size = new System.Drawing.Size(110, 20);
            this.tbParola.TabIndex = 2;
            this.tbParola.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbParola_KeyUp);
            // 
            // btGiris
            // 
            this.btGiris.Font = new System.Drawing.Font("Candara", 9.5F);
            this.btGiris.Location = new System.Drawing.Point(264, 149);
            this.btGiris.Margin = new System.Windows.Forms.Padding(2);
            this.btGiris.Name = "btGiris";
            this.btGiris.Size = new System.Drawing.Size(109, 22);
            this.btGiris.TabIndex = 3;
            this.btGiris.Text = "Giriş";
            this.btGiris.UseVisualStyleBackColor = true;
            this.btGiris.Click += new System.EventHandler(this.btGiris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Otomasyon.Properties.Resources.login_icon;
            this.pictureBox1.Location = new System.Drawing.Point(28, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(399, 246);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btGiris);
            this.Controls.Add(this.tbParola);
            this.Controls.Add(this.tbKAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKAdi;
        private System.Windows.Forms.TextBox tbParola;
        private System.Windows.Forms.Button btGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

