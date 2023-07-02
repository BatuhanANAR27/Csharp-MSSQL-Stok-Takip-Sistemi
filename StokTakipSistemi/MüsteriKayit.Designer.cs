namespace StokTakipSistemi
{
    partial class MüsteriKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MüsteriKayit));
            this.MüsteridataGridView = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arabaMarkasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alinanÜcretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.müsteriKayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_a4ee64_stoktakipsistemiDataSet = new StokTakipSistemi.db_a4ee64_stoktakipsistemiDataSet();
            this.müsteriKayitTableAdapter = new StokTakipSistemi.db_a4ee64_stoktakipsistemiDataSetTableAdapters.MüsteriKayitTableAdapter();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MüsteriAraTextBox = new System.Windows.Forms.TextBox();
            this.KodLabel = new System.Windows.Forms.Label();
            this.MüsteriAdiTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MüsteriSoyadTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MüsteriNumaraTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MüsteriMarkaTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MüsteriÜcretTextBox = new System.Windows.Forms.TextBox();
            this.Kaydet = new System.Windows.Forms.GroupBox();
            this.MüsteriKaydetButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MüsteriGuncelleButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MüsteriSilButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.MüsteriGeriButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MüsteriCikisButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MüsteriIdTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MüsteriTarihTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MüsteridataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.müsteriKayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_a4ee64_stoktakipsistemiDataSet)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Kaydet.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MüsteridataGridView
            // 
            this.MüsteridataGridView.AutoGenerateColumns = false;
            this.MüsteridataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MüsteridataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.MüsteridataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MüsteridataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.numaraDataGridViewTextBoxColumn,
            this.arabaMarkasiDataGridViewTextBoxColumn,
            this.alinanÜcretDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.MüsteridataGridView.DataSource = this.müsteriKayitBindingSource;
            this.MüsteridataGridView.Location = new System.Drawing.Point(-4, 383);
            this.MüsteridataGridView.Name = "MüsteridataGridView";
            this.MüsteridataGridView.Size = new System.Drawing.Size(1249, 369);
            this.MüsteridataGridView.TabIndex = 0;
            this.MüsteridataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MüsteridataGridView_CellDoubleClick);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // numaraDataGridViewTextBoxColumn
            // 
            this.numaraDataGridViewTextBoxColumn.DataPropertyName = "Numara";
            this.numaraDataGridViewTextBoxColumn.HeaderText = "Numara";
            this.numaraDataGridViewTextBoxColumn.Name = "numaraDataGridViewTextBoxColumn";
            // 
            // arabaMarkasiDataGridViewTextBoxColumn
            // 
            this.arabaMarkasiDataGridViewTextBoxColumn.DataPropertyName = "ArabaMarkasi";
            this.arabaMarkasiDataGridViewTextBoxColumn.HeaderText = "ArabaMarkasi";
            this.arabaMarkasiDataGridViewTextBoxColumn.Name = "arabaMarkasiDataGridViewTextBoxColumn";
            // 
            // alinanÜcretDataGridViewTextBoxColumn
            // 
            this.alinanÜcretDataGridViewTextBoxColumn.DataPropertyName = "AlinanÜcret";
            this.alinanÜcretDataGridViewTextBoxColumn.HeaderText = "AlinanÜcret";
            this.alinanÜcretDataGridViewTextBoxColumn.Name = "alinanÜcretDataGridViewTextBoxColumn";
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            // 
            // müsteriKayitBindingSource
            // 
            this.müsteriKayitBindingSource.DataMember = "MüsteriKayit";
            this.müsteriKayitBindingSource.DataSource = this.db_a4ee64_stoktakipsistemiDataSet;
            // 
            // db_a4ee64_stoktakipsistemiDataSet
            // 
            this.db_a4ee64_stoktakipsistemiDataSet.DataSetName = "db_a4ee64_stoktakipsistemiDataSet";
            this.db_a4ee64_stoktakipsistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // müsteriKayitTableAdapter
            // 
            this.müsteriKayitTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.pictureBox2);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(448, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(76, 70);
            this.groupBox7.TabIndex = 32;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Ara";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(19, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // MüsteriAraTextBox
            // 
            this.MüsteriAraTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MüsteriAraTextBox.Location = new System.Drawing.Point(530, 39);
            this.MüsteriAraTextBox.Multiline = true;
            this.MüsteriAraTextBox.Name = "MüsteriAraTextBox";
            this.MüsteriAraTextBox.Size = new System.Drawing.Size(303, 32);
            this.MüsteriAraTextBox.TabIndex = 33;
            this.MüsteriAraTextBox.TextChanged += new System.EventHandler(this.MüsteriAraTextBox_TextChanged);
            // 
            // KodLabel
            // 
            this.KodLabel.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KodLabel.Location = new System.Drawing.Point(376, 113);
            this.KodLabel.Name = "KodLabel";
            this.KodLabel.Size = new System.Drawing.Size(114, 33);
            this.KodLabel.TabIndex = 34;
            this.KodLabel.Text = "Müşteri Adı";
            // 
            // MüsteriAdiTextbox
            // 
            this.MüsteriAdiTextbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MüsteriAdiTextbox.Location = new System.Drawing.Point(483, 113);
            this.MüsteriAdiTextbox.Multiline = true;
            this.MüsteriAdiTextbox.Name = "MüsteriAdiTextbox";
            this.MüsteriAdiTextbox.Size = new System.Drawing.Size(233, 32);
            this.MüsteriAdiTextbox.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(733, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 33);
            this.label1.TabIndex = 36;
            this.label1.Text = "Müşteri Soyadı";
            // 
            // MüsteriSoyadTextBox
            // 
            this.MüsteriSoyadTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MüsteriSoyadTextBox.Location = new System.Drawing.Point(862, 113);
            this.MüsteriSoyadTextBox.Multiline = true;
            this.MüsteriSoyadTextBox.Name = "MüsteriSoyadTextBox";
            this.MüsteriSoyadTextBox.Size = new System.Drawing.Size(233, 32);
            this.MüsteriSoyadTextBox.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 33);
            this.label2.TabIndex = 38;
            this.label2.Text = "Müşteri Numarası";
            // 
            // MüsteriNumaraTextBox
            // 
            this.MüsteriNumaraTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MüsteriNumaraTextBox.Location = new System.Drawing.Point(156, 191);
            this.MüsteriNumaraTextBox.Multiline = true;
            this.MüsteriNumaraTextBox.Name = "MüsteriNumaraTextBox";
            this.MüsteriNumaraTextBox.Size = new System.Drawing.Size(233, 32);
            this.MüsteriNumaraTextBox.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(405, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 33);
            this.label3.TabIndex = 40;
            this.label3.Text = "Araba Markası";
            // 
            // MüsteriMarkaTextBox
            // 
            this.MüsteriMarkaTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MüsteriMarkaTextBox.Location = new System.Drawing.Point(526, 191);
            this.MüsteriMarkaTextBox.Multiline = true;
            this.MüsteriMarkaTextBox.Name = "MüsteriMarkaTextBox";
            this.MüsteriMarkaTextBox.Size = new System.Drawing.Size(233, 32);
            this.MüsteriMarkaTextBox.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(774, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 33);
            this.label5.TabIndex = 43;
            this.label5.Text = "Ücret";
            // 
            // MüsteriÜcretTextBox
            // 
            this.MüsteriÜcretTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MüsteriÜcretTextBox.Location = new System.Drawing.Point(827, 191);
            this.MüsteriÜcretTextBox.Multiline = true;
            this.MüsteriÜcretTextBox.Name = "MüsteriÜcretTextBox";
            this.MüsteriÜcretTextBox.Size = new System.Drawing.Size(109, 32);
            this.MüsteriÜcretTextBox.TabIndex = 44;
            // 
            // Kaydet
            // 
            this.Kaydet.Controls.Add(this.MüsteriKaydetButton);
            this.Kaydet.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kaydet.Location = new System.Drawing.Point(129, 253);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(158, 114);
            this.Kaydet.TabIndex = 45;
            this.Kaydet.TabStop = false;
            this.Kaydet.Text = "Kaydet";
            // 
            // MüsteriKaydetButton
            // 
            this.MüsteriKaydetButton.Image = ((System.Drawing.Image)(resources.GetObject("MüsteriKaydetButton.Image")));
            this.MüsteriKaydetButton.Location = new System.Drawing.Point(17, 21);
            this.MüsteriKaydetButton.Name = "MüsteriKaydetButton";
            this.MüsteriKaydetButton.Size = new System.Drawing.Size(116, 80);
            this.MüsteriKaydetButton.TabIndex = 15;
            this.MüsteriKaydetButton.UseVisualStyleBackColor = true;
            this.MüsteriKaydetButton.Click += new System.EventHandler(this.MüsteriKaydetButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MüsteriGuncelleButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(320, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 106);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Güncelle";
            // 
            // MüsteriGuncelleButton
            // 
            this.MüsteriGuncelleButton.Image = ((System.Drawing.Image)(resources.GetObject("MüsteriGuncelleButton.Image")));
            this.MüsteriGuncelleButton.Location = new System.Drawing.Point(17, 18);
            this.MüsteriGuncelleButton.Name = "MüsteriGuncelleButton";
            this.MüsteriGuncelleButton.Size = new System.Drawing.Size(116, 80);
            this.MüsteriGuncelleButton.TabIndex = 16;
            this.MüsteriGuncelleButton.UseVisualStyleBackColor = true;
            this.MüsteriGuncelleButton.Click += new System.EventHandler(this.MüsteriGuncelleButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MüsteriSilButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(506, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 105);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sil";
            // 
            // MüsteriSilButton
            // 
            this.MüsteriSilButton.Image = ((System.Drawing.Image)(resources.GetObject("MüsteriSilButton.Image")));
            this.MüsteriSilButton.Location = new System.Drawing.Point(20, 18);
            this.MüsteriSilButton.Name = "MüsteriSilButton";
            this.MüsteriSilButton.Size = new System.Drawing.Size(116, 80);
            this.MüsteriSilButton.TabIndex = 17;
            this.MüsteriSilButton.UseVisualStyleBackColor = true;
            this.MüsteriSilButton.Click += new System.EventHandler(this.MüsteriSilButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.MüsteriGeriButton);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(694, 252);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(152, 112);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Geri";
            // 
            // MüsteriGeriButton
            // 
            this.MüsteriGeriButton.Image = ((System.Drawing.Image)(resources.GetObject("MüsteriGeriButton.Image")));
            this.MüsteriGeriButton.Location = new System.Drawing.Point(23, 27);
            this.MüsteriGeriButton.Name = "MüsteriGeriButton";
            this.MüsteriGeriButton.Size = new System.Drawing.Size(116, 80);
            this.MüsteriGeriButton.TabIndex = 18;
            this.MüsteriGeriButton.UseVisualStyleBackColor = true;
            this.MüsteriGeriButton.Click += new System.EventHandler(this.MüsteriGeriButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MüsteriCikisButton);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(876, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(152, 105);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Çıkış";
            // 
            // MüsteriCikisButton
            // 
            this.MüsteriCikisButton.Image = ((System.Drawing.Image)(resources.GetObject("MüsteriCikisButton.Image")));
            this.MüsteriCikisButton.Location = new System.Drawing.Point(19, 17);
            this.MüsteriCikisButton.Name = "MüsteriCikisButton";
            this.MüsteriCikisButton.Size = new System.Drawing.Size(116, 80);
            this.MüsteriCikisButton.TabIndex = 18;
            this.MüsteriCikisButton.UseVisualStyleBackColor = true;
            this.MüsteriCikisButton.Click += new System.EventHandler(this.MüsteriCikisButton_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 33);
            this.label4.TabIndex = 50;
            this.label4.Text = "Müşteri Id";
            // 
            // MüsteriIdTextbox
            // 
            this.MüsteriIdTextbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MüsteriIdTextbox.Location = new System.Drawing.Point(117, 113);
            this.MüsteriIdTextbox.Multiline = true;
            this.MüsteriIdTextbox.Name = "MüsteriIdTextbox";
            this.MüsteriIdTextbox.Size = new System.Drawing.Size(233, 32);
            this.MüsteriIdTextbox.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(957, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 33);
            this.label6.TabIndex = 52;
            this.label6.Text = "Tarih";
            // 
            // MüsteriTarihTextBox
            // 
            this.MüsteriTarihTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MüsteriTarihTextBox.Location = new System.Drawing.Point(1008, 191);
            this.MüsteriTarihTextBox.Multiline = true;
            this.MüsteriTarihTextBox.Name = "MüsteriTarihTextBox";
            this.MüsteriTarihTextBox.Size = new System.Drawing.Size(208, 32);
            this.MüsteriTarihTextBox.TabIndex = 53;
            // 
            // MüsteriKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1243, 749);
            this.Controls.Add(this.MüsteriTarihTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MüsteriIdTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Kaydet);
            this.Controls.Add(this.MüsteriÜcretTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MüsteriMarkaTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MüsteriNumaraTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MüsteriSoyadTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MüsteriAdiTextbox);
            this.Controls.Add(this.KodLabel);
            this.Controls.Add(this.MüsteriAraTextBox);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.MüsteridataGridView);
            this.Name = "MüsteriKayit";
            this.Text = "MüsteriKayit";
            this.Load += new System.EventHandler(this.MüsteriKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MüsteridataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.müsteriKayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_a4ee64_stoktakipsistemiDataSet)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Kaydet.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MüsteridataGridView;
        private db_a4ee64_stoktakipsistemiDataSet db_a4ee64_stoktakipsistemiDataSet;
        private System.Windows.Forms.BindingSource müsteriKayitBindingSource;
        private db_a4ee64_stoktakipsistemiDataSetTableAdapters.MüsteriKayitTableAdapter müsteriKayitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arabaMarkasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alinanÜcretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox MüsteriAraTextBox;
        private System.Windows.Forms.Label KodLabel;
        private System.Windows.Forms.TextBox MüsteriAdiTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MüsteriSoyadTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MüsteriNumaraTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MüsteriMarkaTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MüsteriÜcretTextBox;
        private System.Windows.Forms.GroupBox Kaydet;
        private System.Windows.Forms.Button MüsteriKaydetButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button MüsteriGuncelleButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button MüsteriSilButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button MüsteriGeriButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button MüsteriCikisButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MüsteriIdTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MüsteriTarihTextBox;
    }
}