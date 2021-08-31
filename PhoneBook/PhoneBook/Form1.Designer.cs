
namespace PhoneBook
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
            this.nameList = new System.Windows.Forms.ListBox();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameList
            // 
            this.nameList.FormattingEnabled = true;
            this.nameList.ItemHeight = 15;
            this.nameList.Location = new System.Drawing.Point(41, 117);
            this.nameList.Name = "nameList";
            this.nameList.Size = new System.Drawing.Size(325, 274);
            this.nameList.TabIndex = 0;
            this.nameList.SelectedIndexChanged += new System.EventHandler(this.NameSelected);
            // 
            // phoneNumber
            // 
            this.phoneNumber.Enabled = false;
            this.phoneNumber.Location = new System.Drawing.Point(422, 117);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(343, 22);
            this.phoneNumber.TabIndex = 1;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(38, 87);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(37, 15);
            this.name.TabIndex = 2;
            this.name.Text = "名前";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Location = new System.Drawing.Point(419, 87);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(67, 15);
            this.number.TabIndex = 3;
            this.number.Text = "電話番号";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 458);
            this.Controls.Add(this.number);
            this.Controls.Add(this.name);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.nameList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox nameList;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label number;
    }
}

