namespace SM
{
    partial class overview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(overview));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._tb_productName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._tb_type = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._tb_barcode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._bttn_erase = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._tb_updateBarcode = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this._tb_updatePrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(554, 531);
            this.dataGridView1.TabIndex = 0;
            // 
            // _tb_productName
            // 
            this._tb_productName.Location = new System.Drawing.Point(9, 32);
            this._tb_productName.Name = "_tb_productName";
            this._tb_productName.Size = new System.Drawing.Size(232, 20);
            this._tb_productName.TabIndex = 1;
            this._tb_productName.TextChanged += new System.EventHandler(this._tb_productName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tür";
            // 
            // _tb_type
            // 
            this._tb_type.Location = new System.Drawing.Point(9, 73);
            this._tb_type.Name = "_tb_type";
            this._tb_type.Size = new System.Drawing.Size(232, 20);
            this._tb_type.TabIndex = 3;
            this._tb_type.TextChanged += new System.EventHandler(this._tb_productName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Barkod";
            // 
            // _tb_barcode
            // 
            this._tb_barcode.Location = new System.Drawing.Point(9, 112);
            this._tb_barcode.Name = "_tb_barcode";
            this._tb_barcode.Size = new System.Drawing.Size(232, 20);
            this._tb_barcode.TabIndex = 5;
            this._tb_barcode.TextChanged += new System.EventHandler(this._tb_productName_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this._bttn_erase);
            this.groupBox1.Controls.Add(this._tb_productName);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this._tb_type);
            this.groupBox1.Controls.Add(this._tb_barcode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(572, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 177);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorgu Ekranı";
            // 
            // _bttn_erase
            // 
            this._bttn_erase.Location = new System.Drawing.Point(166, 148);
            this._bttn_erase.Name = "_bttn_erase";
            this._bttn_erase.Size = new System.Drawing.Size(75, 23);
            this._bttn_erase.TabIndex = 8;
            this._bttn_erase.Text = "Sil";
            this._bttn_erase.UseVisualStyleBackColor = true;
            this._bttn_erase.Click += new System.EventHandler(this._bttn_erase_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this._tb_updateBarcode);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this._tb_updatePrice);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(572, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 144);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Güncelleme Ekranı";
            // 
            // _tb_updateBarcode
            // 
            this._tb_updateBarcode.Location = new System.Drawing.Point(9, 32);
            this._tb_updateBarcode.Name = "_tb_updateBarcode";
            this._tb_updateBarcode.Size = new System.Drawing.Size(232, 20);
            this._tb_updateBarcode.TabIndex = 1;
            this._tb_updateBarcode.TextChanged += new System.EventHandler(this._tb_updateBarcode_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Barkod";
            // 
            // _tb_updatePrice
            // 
            this._tb_updatePrice.Location = new System.Drawing.Point(9, 73);
            this._tb_updatePrice.Name = "_tb_updatePrice";
            this._tb_updatePrice.Size = new System.Drawing.Size(232, 20);
            this._tb_updatePrice.TabIndex = 3;
            this._tb_updatePrice.TextChanged += new System.EventHandler(this._tb_updateBarcode_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ücret";
            // 
            // overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 555);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "overview";
            this.Text = "Dükkan Stok Bilgisi";
            this.Load += new System.EventHandler(this.overview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox _tb_productName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _tb_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _tb_barcode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox _tb_updateBarcode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _tb_updatePrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button _bttn_erase;
    }
}