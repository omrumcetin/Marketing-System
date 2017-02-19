namespace SM
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hareketlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._menuStrip_record = new System.Windows.Forms.ToolStripMenuItem();
            this._menuStrip_sorgu = new System.Windows.Forms.ToolStripMenuItem();
            this._bttn_newTrade = new System.Windows.Forms.Button();
            this._lw_trade = new System.Windows.Forms.ListView();
            this._lw_productName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lw_prodNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lw_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this._tb_barcode = new System.Windows.Forms.TextBox();
            this._bttn_endTrade = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this._tb_tradeResult = new System.Windows.Forms.TextBox();
            this._bttn_erase = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this._tb_additionalCost = new System.Windows.Forms.TextBox();
            this._bttn_additionalCost = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hareketlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(713, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hareketlerToolStripMenuItem
            // 
            this.hareketlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuStrip_record,
            this._menuStrip_sorgu});
            this.hareketlerToolStripMenuItem.Name = "hareketlerToolStripMenuItem";
            this.hareketlerToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.hareketlerToolStripMenuItem.Text = "Hareketler";
            // 
            // _menuStrip_record
            // 
            this._menuStrip_record.Name = "_menuStrip_record";
            this._menuStrip_record.Size = new System.Drawing.Size(105, 22);
            this._menuStrip_record.Text = "Kayıt";
            this._menuStrip_record.Click += new System.EventHandler(this.kayıtToolStripMenuItem_Click);
            // 
            // _menuStrip_sorgu
            // 
            this._menuStrip_sorgu.Name = "_menuStrip_sorgu";
            this._menuStrip_sorgu.Size = new System.Drawing.Size(105, 22);
            this._menuStrip_sorgu.Text = "Sorgu";
            this._menuStrip_sorgu.Click += new System.EventHandler(this._menuStrip_sorgu_Click);
            // 
            // _bttn_newTrade
            // 
            this._bttn_newTrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._bttn_newTrade.Location = new System.Drawing.Point(479, 27);
            this._bttn_newTrade.Name = "_bttn_newTrade";
            this._bttn_newTrade.Size = new System.Drawing.Size(225, 28);
            this._bttn_newTrade.TabIndex = 2;
            this._bttn_newTrade.Text = "Yeni Alışveriş";
            this._bttn_newTrade.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this._bttn_newTrade.UseVisualStyleBackColor = true;
            this._bttn_newTrade.Click += new System.EventHandler(this._bttn_newTrade_Click);
            // 
            // _lw_trade
            // 
            this._lw_trade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lw_trade.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._lw_productName,
            this._lw_prodNum,
            this._lw_price});
            this._lw_trade.FullRowSelect = true;
            this._lw_trade.Location = new System.Drawing.Point(12, 27);
            this._lw_trade.Name = "_lw_trade";
            this._lw_trade.Size = new System.Drawing.Size(461, 525);
            this._lw_trade.TabIndex = 3;
            this._lw_trade.UseCompatibleStateImageBehavior = false;
            this._lw_trade.View = System.Windows.Forms.View.Details;
            this._lw_trade.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this._lw_trade_ColumnWidthChanging);
            // 
            // _lw_productName
            // 
            this._lw_productName.Text = "Ürün Adı";
            this._lw_productName.Width = 331;
            // 
            // _lw_prodNum
            // 
            this._lw_prodNum.Text = "Adet/KG";
            this._lw_prodNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _lw_price
            // 
            this._lw_price.Text = "Fiyat";
            this._lw_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._lw_price.Width = 58;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Barkod";
            // 
            // _tb_barcode
            // 
            this._tb_barcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._tb_barcode.Location = new System.Drawing.Point(479, 91);
            this._tb_barcode.Name = "_tb_barcode";
            this._tb_barcode.Size = new System.Drawing.Size(225, 20);
            this._tb_barcode.TabIndex = 5;
            this._tb_barcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._tb_barcode_KeyPress);
            // 
            // _bttn_endTrade
            // 
            this._bttn_endTrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._bttn_endTrade.Location = new System.Drawing.Point(479, 151);
            this._bttn_endTrade.Name = "_bttn_endTrade";
            this._bttn_endTrade.Size = new System.Drawing.Size(225, 28);
            this._bttn_endTrade.TabIndex = 6;
            this._bttn_endTrade.Text = "Alışverişi Sonlandır";
            this._bttn_endTrade.UseVisualStyleBackColor = true;
            this._bttn_endTrade.Click += new System.EventHandler(this._bttn_endTrade_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(473, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "TOPLAM";
            // 
            // _tb_tradeResult
            // 
            this._tb_tradeResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._tb_tradeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this._tb_tradeResult.Location = new System.Drawing.Point(479, 514);
            this._tb_tradeResult.Name = "_tb_tradeResult";
            this._tb_tradeResult.Size = new System.Drawing.Size(225, 38);
            this._tb_tradeResult.TabIndex = 8;
            this._tb_tradeResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _bttn_erase
            // 
            this._bttn_erase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._bttn_erase.Location = new System.Drawing.Point(479, 117);
            this._bttn_erase.Name = "_bttn_erase";
            this._bttn_erase.Size = new System.Drawing.Size(225, 28);
            this._bttn_erase.TabIndex = 11;
            this._bttn_erase.Text = "Kaydı Sil";
            this._bttn_erase.UseVisualStyleBackColor = true;
            this._bttn_erase.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ek Ücret";
            // 
            // _tb_additionalCost
            // 
            this._tb_additionalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._tb_additionalCost.Location = new System.Drawing.Point(479, 423);
            this._tb_additionalCost.Name = "_tb_additionalCost";
            this._tb_additionalCost.Size = new System.Drawing.Size(225, 20);
            this._tb_additionalCost.TabIndex = 13;
            this._tb_additionalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _bttn_additionalCost
            // 
            this._bttn_additionalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._bttn_additionalCost.Location = new System.Drawing.Point(479, 449);
            this._bttn_additionalCost.Name = "_bttn_additionalCost";
            this._bttn_additionalCost.Size = new System.Drawing.Size(225, 28);
            this._bttn_additionalCost.TabIndex = 14;
            this._bttn_additionalCost.Text = "Ek Ücret Ekle";
            this._bttn_additionalCost.UseVisualStyleBackColor = true;
            this._bttn_additionalCost.Click += new System.EventHandler(this._bttn_additionalCost_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 573);
            this.Controls.Add(this._bttn_additionalCost);
            this.Controls.Add(this._tb_additionalCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._bttn_erase);
            this.Controls.Add(this._tb_tradeResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._bttn_endTrade);
            this.Controls.Add(this._tb_barcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._lw_trade);
            this.Controls.Add(this._bttn_newTrade);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Marjisoft Marketing";
            this.ResizeEnd += new System.EventHandler(this.MainWindow_ResizeEnd);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hareketlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _menuStrip_record;
        private System.Windows.Forms.ToolStripMenuItem _menuStrip_sorgu;
        private System.Windows.Forms.Button _bttn_newTrade;
        private System.Windows.Forms.ListView _lw_trade;
        private System.Windows.Forms.ColumnHeader _lw_productName;
        private System.Windows.Forms.ColumnHeader _lw_prodNum;
        private System.Windows.Forms.ColumnHeader _lw_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _tb_barcode;
        private System.Windows.Forms.Button _bttn_endTrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _tb_tradeResult;
        private System.Windows.Forms.Button _bttn_erase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _tb_additionalCost;
        private System.Windows.Forms.Button _bttn_additionalCost;
    }
}

