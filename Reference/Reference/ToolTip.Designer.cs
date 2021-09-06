
namespace Reference
{
    partial class ToolTip
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.ToolTipLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(18, 103);
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
            this.label14.Size = new System.Drawing.Size(300, 54);
            this.label14.Text = "ユーザーがポインターをコントロール上に配置したときに、そのコントロールの目的を簡単な説明で示すポップアップ ウィンドウです。";
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.Text = "ToolTip";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 74;
            this.button1.Text = "???";
            this.toolTip1.SetToolTip(this.button1, "押しちゃダメ");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.QestClicked);
            // 
            // ToolTipLabel
            // 
            this.ToolTipLabel.AutoSize = true;
            this.ToolTipLabel.Location = new System.Drawing.Point(77, 161);
            this.ToolTipLabel.Name = "ToolTipLabel";
            this.ToolTipLabel.Size = new System.Drawing.Size(113, 12);
            this.ToolTipLabel.TabIndex = 75;
            this.ToolTipLabel.Text = "カーソルを当ててみてね";
            // 
            // ToolTip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.ToolTipLabel);
            this.Controls.Add(this.button1);
            this.Name = "ToolTip";
            this.Text = "コモンコントロール/ToolTip";
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
            this.Controls.SetChildIndex(this.ToolTipLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ToolTipLabel;
    }
}
