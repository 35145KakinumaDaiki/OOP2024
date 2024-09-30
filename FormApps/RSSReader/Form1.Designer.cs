namespace RSSReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.btGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.cbFavorite = new System.Windows.Forms.ComboBox();
            this.tbRssname = new System.Windows.Forms.TextBox();
            this.btRegist = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btGet
            // 
            this.btGet.Location = new System.Drawing.Point(494, 10);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(75, 23);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(42, 98);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(1209, 136);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.SelectedIndexChanged += new System.EventHandler(this.lbRssTitle_SelectedIndexChanged);
            // 
            // webView2
            // 
            this.webView2.AllowExternalDrop = true;
            this.webView2.CreationProperties = null;
            this.webView2.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView2.Location = new System.Drawing.Point(42, 252);
            this.webView2.Name = "webView2";
            this.webView2.Size = new System.Drawing.Size(1209, 400);
            this.webView2.TabIndex = 3;
            this.webView2.ZoomFactor = 1D;
            // 
            // cbFavorite
            // 
            this.cbFavorite.FormattingEnabled = true;
            this.cbFavorite.Location = new System.Drawing.Point(84, 10);
            this.cbFavorite.Name = "cbFavorite";
            this.cbFavorite.Size = new System.Drawing.Size(404, 20);
            this.cbFavorite.TabIndex = 5;
            // 
            // tbRssname
            // 
            this.tbRssname.Location = new System.Drawing.Point(84, 62);
            this.tbRssname.Name = "tbRssname";
            this.tbRssname.Size = new System.Drawing.Size(323, 19);
            this.tbRssname.TabIndex = 6;
            // 
            // btRegist
            // 
            this.btRegist.Location = new System.Drawing.Point(413, 58);
            this.btRegist.Name = "btRegist";
            this.btRegist.Size = new System.Drawing.Size(75, 23);
            this.btRegist.TabIndex = 7;
            this.btRegist.Text = "登録";
            this.btRegist.UseVisualStyleBackColor = true;
            this.btRegist.Click += new System.EventHandler(this.btRegist_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Red;
            this.btDelete.Location = new System.Drawing.Point(494, 58);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 8;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1289, 816);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btRegist);
            this.Controls.Add(this.tbRssname);
            this.Controls.Add(this.cbFavorite);
            this.Controls.Add(this.webView2);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
        private System.Windows.Forms.ComboBox cbFavorite;
        private System.Windows.Forms.TextBox tbRssname;
        private System.Windows.Forms.Button btRegist;
        private System.Windows.Forms.Button btDelete;
    }
}

