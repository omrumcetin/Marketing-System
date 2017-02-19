namespace SM
{
    partial class kiloScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kiloScreen));
            this.label1 = new System.Windows.Forms.Label();
            this._tb_kilo = new System.Windows.Forms.TextBox();
            this._bttn_okClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kilogram Cinsinden Giriniz";
            // 
            // _tb_kilo
            // 
            this._tb_kilo.Location = new System.Drawing.Point(91, 32);
            this._tb_kilo.Name = "_tb_kilo";
            this._tb_kilo.Size = new System.Drawing.Size(100, 20);
            this._tb_kilo.TabIndex = 1;
            this._tb_kilo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // _bttn_okClick
            // 
            this._bttn_okClick.Location = new System.Drawing.Point(104, 58);
            this._bttn_okClick.Name = "_bttn_okClick";
            this._bttn_okClick.Size = new System.Drawing.Size(75, 23);
            this._bttn_okClick.TabIndex = 2;
            this._bttn_okClick.Text = "OK";
            this._bttn_okClick.UseVisualStyleBackColor = true;
            this._bttn_okClick.Click += new System.EventHandler(this._bttn_okClick_Click);
            // 
            // kiloScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 93);
            this.Controls.Add(this._bttn_okClick);
            this.Controls.Add(this._tb_kilo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kiloScreen";
            this.Text = "Kilo Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _tb_kilo;
        private System.Windows.Forms.Button _bttn_okClick;
    }
}