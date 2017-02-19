namespace SM
{
    partial class barcodeReadWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(barcodeReadWindow));
            this._tb_barcode = new System.Windows.Forms.TextBox();
            this._bttn_ok = new System.Windows.Forms.Button();
            this._bttn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _tb_barcode
            // 
            this._tb_barcode.Location = new System.Drawing.Point(58, 47);
            this._tb_barcode.Name = "_tb_barcode";
            this._tb_barcode.Size = new System.Drawing.Size(264, 20);
            this._tb_barcode.TabIndex = 0;
            this._tb_barcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._bttn_ok_KeyPress);
            // 
            // _bttn_ok
            // 
            this._bttn_ok.Location = new System.Drawing.Point(58, 92);
            this._bttn_ok.Name = "_bttn_ok";
            this._bttn_ok.Size = new System.Drawing.Size(110, 47);
            this._bttn_ok.TabIndex = 1;
            this._bttn_ok.Text = "Devam";
            this._bttn_ok.UseVisualStyleBackColor = true;
            this._bttn_ok.Click += new System.EventHandler(this._bttn_ok_Click);
            this._bttn_ok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._bttn_ok_KeyPress);
            // 
            // _bttn_exit
            // 
            this._bttn_exit.Location = new System.Drawing.Point(212, 92);
            this._bttn_exit.Name = "_bttn_exit";
            this._bttn_exit.Size = new System.Drawing.Size(110, 47);
            this._bttn_exit.TabIndex = 2;
            this._bttn_exit.Text = "Çıkış";
            this._bttn_exit.UseVisualStyleBackColor = true;
            this._bttn_exit.Click += new System.EventHandler(this._bttn_exit_Click);
            // 
            // barcodeReadWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 161);
            this.Controls.Add(this._bttn_exit);
            this.Controls.Add(this._bttn_ok);
            this.Controls.Add(this._tb_barcode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "barcodeReadWindow";
            this.Text = "Barkod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _tb_barcode;
        private System.Windows.Forms.Button _bttn_ok;
        private System.Windows.Forms.Button _bttn_exit;
    }
}