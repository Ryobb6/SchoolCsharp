
namespace Reference
{
    partial class MonthCalendar
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(336, 403);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(25, 556);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(25, 362);
            // 
            // eventText
            // 
            this.eventText.Location = new System.Drawing.Point(26, 403);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(18, 341);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(18, 100);
            // 
            // label10
            // 
            this.label10.Size = new System.Drawing.Size(65, 14);
            this.label10.Text = "2021/09/06";
            // 
            // label14
            // 
            this.label14.Size = new System.Drawing.Size(300, 53);
            this.label14.Text = "ユーザーが日付の範囲を選択できるようにするための、グラフィカルなカレンダーを表示します。";
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.Text = "MonthCalendar";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(97, 127);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 74;
            // 
            // MonthCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(401, 461);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "MonthCalendar";
            this.Text = "コモンコントロール/MonthCalendar";
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
            this.Controls.SetChildIndex(this.monthCalendar1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}
