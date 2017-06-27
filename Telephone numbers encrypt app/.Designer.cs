namespace Telephone_numbers_encrypt_app
{
    partial class mainwindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainwindow));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label = new System.Windows.Forms.Label();
            this.ToolStripMenuItem2_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1,
            this.ToolStripMenuItem2});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(337, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1_1,
            this.ToolStripMenuItem1_2});
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(62, 24);
            this.ToolStripMenuItem1.Text = "ファイル";
            // 
            // ToolStripMenuItem1_1
            // 
            this.ToolStripMenuItem1_1.Name = "ToolStripMenuItem1_1";
            this.ToolStripMenuItem1_1.Size = new System.Drawing.Size(144, 26);
            this.ToolStripMenuItem1_1.Text = "新規作成";
            this.ToolStripMenuItem1_1.Click += new System.EventHandler(this.ToolStripMenuItem1_1_Click);
            // 
            // ToolStripMenuItem1_2
            // 
            this.ToolStripMenuItem1_2.Name = "ToolStripMenuItem1_2";
            this.ToolStripMenuItem1_2.Size = new System.Drawing.Size(144, 26);
            this.ToolStripMenuItem1_2.Text = "編集";
            this.ToolStripMenuItem1_2.Click += new System.EventHandler(this.ToolStripMenuItem1_2_Click);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem2_1});
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(54, 24);
            this.ToolStripMenuItem2.Text = "ツール";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 37);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(305, 45);
            this.label.TabIndex = 1;
            this.label.Text = "このアプリは電話帳を暗号化し管理するアプリです。\r\n勿論、復号化もできます。\r\nこれを使えばセキュリティーが向上します！";
            // 
            // ToolStripMenuItem2_1
            // 
            this.ToolStripMenuItem2_1.Name = "ToolStripMenuItem2_1";
            this.ToolStripMenuItem2_1.Size = new System.Drawing.Size(181, 26);
            this.ToolStripMenuItem2_1.Text = "検索";
            this.ToolStripMenuItem2_1.Click += new System.EventHandler(this.ToolStripMenuItem2_1_Click);
            // 
            // mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 103);
            this.Controls.Add(this.label);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "mainwindow";
            this.Text = "MainWindow";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1_1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1_2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem2_1;
    }
}

