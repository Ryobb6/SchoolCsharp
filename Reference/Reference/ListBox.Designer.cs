
namespace Reference
{
    partial class ListBox
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListBox));
            this.siteListBox = new System.Windows.Forms.ListBox();
            this.siteBox = new System.Windows.Forms.TextBox();
            this.siteName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.toolTipForSiteBox = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(336, 409);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(25, 866);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(25, 367);
            this.label6.Text = "private void EvantName(object sender, EventArgs e)\r\n        {\r\n";
            // 
            // eventText
            // 
            this.eventText.Location = new System.Drawing.Point(26, 408);
            this.eventText.Size = new System.Drawing.Size(330, 456);
            this.eventText.Text = resources.GetString("eventText.Text");
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(18, 346);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(18, 100);
            // 
            // label8
            // 
            this.label8.Size = new System.Drawing.Size(66, 14);
            this.label8.Text = "Ryota_Tsuji";
            // 
            // label14
            // 
            this.label14.Size = new System.Drawing.Size(300, 44);
            this.label14.Text = "テキストとグラフィカルな項目 (アイコン) の一覧を表示します。";
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.Text = "ListBox";
            // 
            // siteListBox
            // 
            this.siteListBox.FormattingEnabled = true;
            this.siteListBox.ItemHeight = 12;
            this.siteListBox.Items.AddRange(new object[] {
            "Microsoft 公式Refeerence",
            "未確認飛行 C",
            ".NET Column"});
            this.siteListBox.Location = new System.Drawing.Point(63, 154);
            this.siteListBox.Name = "siteListBox";
            this.siteListBox.Size = new System.Drawing.Size(246, 88);
            this.siteListBox.TabIndex = 74;
            // 
            // siteBox
            // 
            this.siteBox.Location = new System.Drawing.Point(63, 282);
            this.siteBox.Name = "siteBox";
            this.siteBox.Size = new System.Drawing.Size(246, 19);
            this.siteBox.TabIndex = 75;
            this.toolTipForSiteBox.SetToolTip(this.siteBox, "サイトの名前を入力してください");
            this.siteBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.siteBox_KeyPress);
            // 
            // siteName
            // 
            this.siteName.AutoSize = true;
            this.siteName.Location = new System.Drawing.Point(51, 133);
            this.siteName.Name = "siteName";
            this.siteName.Size = new System.Drawing.Size(104, 12);
            this.siteName.TabIndex = 76;
            this.siteName.Text = "よく見る参考サイト名";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 265);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(198, 12);
            this.label12.TabIndex = 77;
            this.label12.Text = "サイト名を追加する(Enterでも追加可能)";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(146, 311);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 78;
            this.addButton.Text = "追加";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.siteName);
            this.Controls.Add(this.siteBox);
            this.Controls.Add(this.siteListBox);
            this.Name = "ListBox";
            this.Text = "コモンコントロール/ListBox";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.eventText, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.copyButton, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.siteListBox, 0);
            this.Controls.SetChildIndex(this.siteBox, 0);
            this.Controls.SetChildIndex(this.siteName, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.addButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox siteListBox;
        private System.Windows.Forms.TextBox siteBox;
        private System.Windows.Forms.Label siteName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ToolTip toolTipForSiteBox;
    }
}
