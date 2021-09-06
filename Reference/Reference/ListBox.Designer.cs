
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
            this.SuspendLayout();
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
            // ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Name = "ListBox";
            this.Text = "コモンコントロール/ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
