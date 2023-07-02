
namespace StokTakipSistemi
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.KullaniciTextBox = new System.Windows.Forms.TextBox();
            this.SifreTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.GirisButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.KayıtEKleButton = new System.Windows.Forms.Button();
            this.SifreUnuttumButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.MevkiTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "STOK TAKİP SİSTEMİNE HOŞGELDİNİZ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(164, 231);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;

            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(164, 320);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // KullaniciTextBox
            // 
            this.KullaniciTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.KullaniciTextBox.Location = new System.Drawing.Point(9, 27);
            this.KullaniciTextBox.Multiline = true;
            this.KullaniciTextBox.Name = "KullaniciTextBox";
            this.KullaniciTextBox.Size = new System.Drawing.Size(251, 34);
            this.KullaniciTextBox.TabIndex = 0;
            // 
            // SifreTextBox
            // 
            this.SifreTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.SifreTextBox.Location = new System.Drawing.Point(11, 31);
            this.SifreTextBox.Multiline = true;
            this.SifreTextBox.Name = "SifreTextBox";
            this.SifreTextBox.PasswordChar = '*';
            this.SifreTextBox.Size = new System.Drawing.Size(251, 34);
            this.SifreTextBox.TabIndex = 5;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(553, 134);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(215, 217);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // GirisButton
            // 
            this.GirisButton.Image = ((System.Drawing.Image)(resources.GetObject("GirisButton.Image")));
            this.GirisButton.Location = new System.Drawing.Point(18, 24);
            this.GirisButton.Name = "GirisButton";
            this.GirisButton.Size = new System.Drawing.Size(96, 77);
            this.GirisButton.TabIndex = 7;
            this.GirisButton.UseVisualStyleBackColor = true;
            this.GirisButton.Click += new System.EventHandler(this.GirisButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.KullaniciTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(230, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 83);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Adı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SifreTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(232, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 83);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şifre";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GirisButton);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(370, 433);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(131, 109);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Giriş";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.KayıtEKleButton);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(194, 433);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(146, 109);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kayıt Ekle";
            // 
            // KayıtEKleButton
            // 
            this.KayıtEKleButton.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayıtEKleButton.Image = ((System.Drawing.Image)(resources.GetObject("KayıtEKleButton.Image")));
            this.KayıtEKleButton.Location = new System.Drawing.Point(27, 24);
            this.KayıtEKleButton.Name = "KayıtEKleButton";
            this.KayıtEKleButton.Size = new System.Drawing.Size(92, 79);
            this.KayıtEKleButton.TabIndex = 12;
            this.KayıtEKleButton.UseVisualStyleBackColor = true;
            this.KayıtEKleButton.Click += new System.EventHandler(this.KayıtEKleButton_Click);
            // 
            // SifreUnuttumButton
            // 
            this.SifreUnuttumButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SifreUnuttumButton.Location = new System.Drawing.Point(370, 381);
            this.SifreUnuttumButton.Name = "SifreUnuttumButton";
            this.SifreUnuttumButton.Size = new System.Drawing.Size(136, 22);
            this.SifreUnuttumButton.TabIndex = 16;
            this.SifreUnuttumButton.Text = "Şifremi unuttum";
            this.SifreUnuttumButton.UseVisualStyleBackColor = false;
            this.SifreUnuttumButton.Click += new System.EventHandler(this.SifreUnuttumButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.MevkiTextBox);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(230, 124);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(278, 83);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mevki";
            // 
            // MevkiTextBox
            // 
            this.MevkiTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.MevkiTextBox.Location = new System.Drawing.Point(9, 27);
            this.MevkiTextBox.Multiline = true;
            this.MevkiTextBox.Name = "MevkiTextBox";
            this.MevkiTextBox.Size = new System.Drawing.Size(251, 34);
            this.MevkiTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(905, 585);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.SifreUnuttumButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox KullaniciTextBox;
        private System.Windows.Forms.TextBox SifreTextBox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button GirisButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button KayıtEKleButton;
        private System.Windows.Forms.Button SifreUnuttumButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox MevkiTextBox;
    }
}

