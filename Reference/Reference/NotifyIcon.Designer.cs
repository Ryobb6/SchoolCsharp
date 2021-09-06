
namespace Reference
{
    partial class NotifyIcon
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(336, 538);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(25, 589);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(25, 496);
            // 
            // eventText
            // 
            this.eventText.Location = new System.Drawing.Point(26, 537);
            this.eventText.Size = new System.Drawing.Size(330, 46);
            this.eventText.Text = "　　　　// イベントを作成していません";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(18, 475);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(18, 120);
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
            this.label14.Text = "タスクバーの状態通知領域に、バックグラウンドで実行されているアプリケーションを表すアイコンを表示します。";
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.Text = "NotifyIcon";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Reference.Properties.Resources.NotifyIconRefImg;
            this.pictureBox1.Location = new System.Drawing.Point(43, 327);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 427);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(253, 24);
            this.label11.TabIndex = 75;
            this.label11.Text = "3.　表示されたnotifyIconをクリックし、Iconプロパティを\r\n設定すると、タスクバーに.iconファイルが表示されます";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Reference.Properties.Resources.NotifyIconExpImg;
            this.pictureBox2.Location = new System.Drawing.Point(43, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(282, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 76;
            this.pictureBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(70, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(226, 12);
            this.label12.TabIndex = 77;
            this.label12.Text = "1. ツールボックスからFormにnotifyIconをドロップ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(70, 288);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(210, 12);
            this.label13.TabIndex = 78;
            this.label13.Text = "2. notifyIconが共有スペースに表示されます";
            // 
            // NotifyIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Name = "NotifyIcon";
            this.Text = "コモンコントロール/NotifyIcon";
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
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}
