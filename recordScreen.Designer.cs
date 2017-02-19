namespace SM
{
    partial class recordScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(recordScreen));
            this._tb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._tb_cost = new System.Windows.Forms.TextBox();
            this._bttn_record = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this._tb_barcode = new System.Windows.Forms.TextBox();
            this._tb_type = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _tb_name
            // 
            this._tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this._tb_name.Location = new System.Drawing.Point(79, 10);
            this._tb_name.Name = "_tb_name";
            this._tb_name.Size = new System.Drawing.Size(302, 20);
            this._tb_name.TabIndex = 0;
            this._tb_name.TextChanged += new System.EventHandler(this._tb_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ürün Ücreti";
            // 
            // _tb_cost
            // 
            this._tb_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this._tb_cost.Location = new System.Drawing.Point(79, 62);
            this._tb_cost.Name = "_tb_cost";
            this._tb_cost.Size = new System.Drawing.Size(302, 20);
            this._tb_cost.TabIndex = 5;
            this._tb_cost.TextChanged += new System.EventHandler(this._tb_name_TextChanged);
            // 
            // _bttn_record
            // 
            this._bttn_record.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this._bttn_record.Location = new System.Drawing.Point(268, 119);
            this._bttn_record.Name = "_bttn_record";
            this._bttn_record.Size = new System.Drawing.Size(116, 38);
            this._bttn_record.TabIndex = 6;
            this._bttn_record.Text = "Onay";
            this._bttn_record.UseVisualStyleBackColor = true;
            this._bttn_record.Click += new System.EventHandler(this._bttn_record_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(145, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Barkod";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Barkod No";
            // 
            // _tb_barcode
            // 
            this._tb_barcode.Enabled = false;
            this._tb_barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this._tb_barcode.Location = new System.Drawing.Point(79, 88);
            this._tb_barcode.Name = "_tb_barcode";
            this._tb_barcode.Size = new System.Drawing.Size(302, 20);
            this._tb_barcode.TabIndex = 8;
            this._tb_barcode.TextChanged += new System.EventHandler(this._tb_name_TextChanged);
            // 
            // _tb_type
            // 
            this._tb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._tb_type.FormattingEnabled = true;
            this._tb_type.Items.AddRange(new object[] {
            "Adet",
            "Birim"});
            this._tb_type.Location = new System.Drawing.Point(79, 35);
            this._tb_type.Name = "_tb_type";
            this._tb_type.Size = new System.Drawing.Size(302, 21);
            this._tb_type.TabIndex = 10;
            // 
            // recordScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 166);
            this.Controls.Add(this._tb_type);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._tb_barcode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._bttn_record);
            this.Controls.Add(this._tb_cost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._tb_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "recordScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _tb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _tb_cost;
        private System.Windows.Forms.Button _bttn_record;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _tb_barcode;
        private System.Windows.Forms.ComboBox _tb_type;
    }
}