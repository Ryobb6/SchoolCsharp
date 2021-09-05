
namespace Reference
{
    partial class TreeView
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(336, 345);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(25, 497);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(25, 303);
            // 
            // eventText
            // 
            this.eventText.Location = new System.Drawing.Point(26, 344);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(18, 282);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(18, 110);
            // 
            // label14
            // 
            this.label14.Size = new System.Drawing.Size(300, 54);
            this.label14.Text = "テキストとオプションのチェック ボックスまたはアイコンで構成できる、ノード オブジェクトの階層コレクションを表示します。";
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.Text = "TreeView";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(121, 147);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 74;
            // 
            // TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.treeView1);
            this.Name = "TreeView";
            this.Text = "コモンコントロール/TreeView";
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
            this.Controls.SetChildIndex(this.treeView1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}
