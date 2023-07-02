
namespace StokTakipSistemi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alisFiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisFiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokAdediDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokTakipSistemiDataSet = new StokTakipSistemi.StokTakipSistemiDataSet();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stokBilgiTableAdapter = new StokTakipSistemi.StokTakipSistemiDataSetTableAdapters.StokBilgiTableAdapter();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AdminAraTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AdminCikisButton = new System.Windows.Forms.Button();
            this.AdminYolTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipSistemiDataSet)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.urunKoduDataGridViewTextBoxColumn,
            this.urunAdiDataGridViewTextBoxColumn,
            this.aracDataGridViewTextBoxColumn,
            this.alisFiyatiDataGridViewTextBoxColumn,
            this.satisFiyatiDataGridViewTextBoxColumn,
            this.stokAdediDataGridViewTextBoxColumn,
            this.stokTarihiDataGridViewTextBoxColumn,
            this.resimDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.stokBilgiBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(-1, 314);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(1325, 504);
            this.dataGridView3.TabIndex = 34;
            this.dataGridView3.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellDoubleClick);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunKoduDataGridViewTextBoxColumn
            // 
            this.urunKoduDataGridViewTextBoxColumn.DataPropertyName = "UrunKodu";
            this.urunKoduDataGridViewTextBoxColumn.HeaderText = "UrunKodu";
            this.urunKoduDataGridViewTextBoxColumn.Name = "urunKoduDataGridViewTextBoxColumn";
            // 
            // urunAdiDataGridViewTextBoxColumn
            // 
            this.urunAdiDataGridViewTextBoxColumn.DataPropertyName = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.HeaderText = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.Name = "urunAdiDataGridViewTextBoxColumn";
            // 
            // aracDataGridViewTextBoxColumn
            // 
            this.aracDataGridViewTextBoxColumn.DataPropertyName = "Arac";
            this.aracDataGridViewTextBoxColumn.HeaderText = "Arac";
            this.aracDataGridViewTextBoxColumn.Name = "aracDataGridViewTextBoxColumn";
            // 
            // alisFiyatiDataGridViewTextBoxColumn
            // 
            this.alisFiyatiDataGridViewTextBoxColumn.DataPropertyName = "AlisFiyati";
            this.alisFiyatiDataGridViewTextBoxColumn.HeaderText = "AlisFiyati";
            this.alisFiyatiDataGridViewTextBoxColumn.Name = "alisFiyatiDataGridViewTextBoxColumn";
            // 
            // satisFiyatiDataGridViewTextBoxColumn
            // 
            this.satisFiyatiDataGridViewTextBoxColumn.DataPropertyName = "SatisFiyati";
            this.satisFiyatiDataGridViewTextBoxColumn.HeaderText = "SatisFiyati";
            this.satisFiyatiDataGridViewTextBoxColumn.Name = "satisFiyatiDataGridViewTextBoxColumn";
            // 
            // stokAdediDataGridViewTextBoxColumn
            // 
            this.stokAdediDataGridViewTextBoxColumn.DataPropertyName = "StokAdedi";
            this.stokAdediDataGridViewTextBoxColumn.HeaderText = "StokAdedi";
            this.stokAdediDataGridViewTextBoxColumn.Name = "stokAdediDataGridViewTextBoxColumn";
            // 
            // stokTarihiDataGridViewTextBoxColumn
            // 
            this.stokTarihiDataGridViewTextBoxColumn.DataPropertyName = "StokTarihi";
            this.stokTarihiDataGridViewTextBoxColumn.HeaderText = "StokTarihi";
            this.stokTarihiDataGridViewTextBoxColumn.Name = "stokTarihiDataGridViewTextBoxColumn";
            // 
            // resimDataGridViewTextBoxColumn
            // 
            this.resimDataGridViewTextBoxColumn.DataPropertyName = "Resim";
            this.resimDataGridViewTextBoxColumn.HeaderText = "Resim";
            this.resimDataGridViewTextBoxColumn.Name = "resimDataGridViewTextBoxColumn";
            // 
            // stokBilgiBindingSource
            // 
            this.stokBilgiBindingSource.DataMember = "StokBilgi";
            this.stokBilgiBindingSource.DataSource = this.stokTakipSistemiDataSet;
            // 
            // stokTakipSistemiDataSet
            // 
            this.stokTakipSistemiDataSet.DataSetName = "StokTakipSistemiDataSet";
            this.stokTakipSistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(568, 44);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(271, 221);
            this.groupBox6.TabIndex = 35;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Resim";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(31, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // stokBilgiTableAdapter
            // 
            this.stokBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.pictureBox2);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(93, 93);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(76, 70);
            this.groupBox7.TabIndex = 37;
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
            // AdminAraTextBox
            // 
            this.AdminAraTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AdminAraTextBox.Location = new System.Drawing.Point(175, 119);
            this.AdminAraTextBox.Multiline = true;
            this.AdminAraTextBox.Name = "AdminAraTextBox";
            this.AdminAraTextBox.Size = new System.Drawing.Size(303, 32);
            this.AdminAraTextBox.TabIndex = 36;
            this.AdminAraTextBox.TextChanged += new System.EventHandler(this.AdminAraTextBox_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AdminCikisButton);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(902, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(149, 105);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Çıkış";
            // 
            // AdminCikisButton
            // 
            this.AdminCikisButton.Image = ((System.Drawing.Image)(resources.GetObject("AdminCikisButton.Image")));
            this.AdminCikisButton.Location = new System.Drawing.Point(19, 17);
            this.AdminCikisButton.Name = "AdminCikisButton";
            this.AdminCikisButton.Size = new System.Drawing.Size(116, 80);
            this.AdminCikisButton.TabIndex = 18;
            this.AdminCikisButton.UseVisualStyleBackColor = true;
            this.AdminCikisButton.Click += new System.EventHandler(this.AdminCikisButton_Click);
            // 
            // AdminYolTextBox
            // 
            this.AdminYolTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AdminYolTextBox.Location = new System.Drawing.Point(849, 80);
            this.AdminYolTextBox.Multiline = true;
            this.AdminYolTextBox.Name = "AdminYolTextBox";
            this.AdminYolTextBox.Size = new System.Drawing.Size(202, 34);
            this.AdminYolTextBox.TabIndex = 39;
            this.AdminYolTextBox.TextChanged += new System.EventHandler(this.AdminYolTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(845, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 33);
            this.label1.TabIndex = 40;
            this.label1.Text = "Resim Yolu";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1323, 816);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminYolTextBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.AdminAraTextBox);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.dataGridView3);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipSistemiDataSet)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private StokTakipSistemiDataSet stokTakipSistemiDataSet;
        private System.Windows.Forms.BindingSource stokBilgiBindingSource;
        private StokTakipSistemiDataSetTableAdapters.StokBilgiTableAdapter stokBilgiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alisFiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisFiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokAdediDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resimDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox AdminAraTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button AdminCikisButton;
        private System.Windows.Forms.TextBox AdminYolTextBox;
        private System.Windows.Forms.Label label1;
    }
}