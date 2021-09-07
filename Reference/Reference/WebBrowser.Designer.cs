
namespace Reference
{
    partial class WebBrowser
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(336, 275);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(25, 427);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(25, 233);
            // 
            // eventText
            // 
            this.eventText.Location = new System.Drawing.Point(26, 274);
            this.eventText.Text = "this.webBrowser1.ScriptErrorsSuppressed = true; //JavaScript ErrorMEssageのダイアログを出" +
    "さない処理です\r\n            this.webBrowser1.Navigate(\"https://www.youtube.com/channel/" +
    "UCXvs_p2ZD28_Pa67cyN4FzQ/featured\");";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(18, 212);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(18, 90);
            // 
            // label8
            // 
            this.label8.Size = new System.Drawing.Size(66, 14);
            this.label8.Text = "Ryota_Tsuji";
            // 
            // label10
            // 
            this.label10.Size = new System.Drawing.Size(65, 14);
            this.label10.Text = "2021/09/06";
            // 
            // label14
            // 
            this.label14.Size = new System.Drawing.Size(300, 33);
            this.label14.Text = "ユーザーがフォーム内で Web ページをナビゲートできるようにします。";
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.Text = "WebBrowser";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(129, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 65);
            this.button1.TabIndex = 74;
            this.button1.Text = "映画を見てみる";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ShowBrowser);
            // 
            // WebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(401, 461);
            this.Controls.Add(this.button1);
            this.Name = "WebBrowser";
            this.Text = "コモンコントロール/WebBrowser";
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
            this.Controls.SetChildIndex(this.button1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
    }
}
