
namespace DrawApp
{
    partial class Form1
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
            this.palletButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // palletButton
            // 
            this.palletButton.Location = new System.Drawing.Point(339, 442);
            this.palletButton.Name = "palletButton";
            this.palletButton.Size = new System.Drawing.Size(75, 23);
            this.palletButton.TabIndex = 0;
            this.palletButton.Text = "Pallet";
            this.palletButton.UseVisualStyleBackColor = true;
            this.palletButton.Click += new System.EventHandler(this.plltButtonClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 493);
            this.Controls.Add(this.palletButton);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawFigures);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MousePressed);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseDragged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button palletButton;
    }
}

