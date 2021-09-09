
namespace Tsuji_CSharp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.selectIdBox = new System.Windows.Forms.ComboBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.ageText = new System.Windows.Forms.TextBox();
            this.adressText = new System.Windows.Forms.TextBox();
            this.telText = new System.Windows.Forms.TextBox();
            this.mailText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "顧客情報";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "顧客ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "名前";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "住所";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "年齢";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 12);
            this.label6.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(230, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "電話番号";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(230, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "メールアドレス";
            // 
            // selectIdBox
            // 
            this.selectIdBox.FormattingEnabled = true;
            this.selectIdBox.Location = new System.Drawing.Point(183, 19);
            this.selectIdBox.Name = "selectIdBox";
            this.selectIdBox.Size = new System.Drawing.Size(121, 20);
            this.selectIdBox.TabIndex = 8;
            this.selectIdBox.SelectedIndexChanged += new System.EventHandler(this.ViewUserInfo);
            // 
            // nameText
            // 
            this.nameText.Enabled = false;
            this.nameText.Location = new System.Drawing.Point(67, 77);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(100, 19);
            this.nameText.TabIndex = 9;
            // 
            // ageText
            // 
            this.ageText.Enabled = false;
            this.ageText.Location = new System.Drawing.Point(67, 126);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(100, 19);
            this.ageText.TabIndex = 10;
            // 
            // adressText
            // 
            this.adressText.Enabled = false;
            this.adressText.Location = new System.Drawing.Point(67, 175);
            this.adressText.Name = "adressText";
            this.adressText.Size = new System.Drawing.Size(100, 19);
            this.adressText.TabIndex = 11;
            // 
            // telText
            // 
            this.telText.Enabled = false;
            this.telText.Location = new System.Drawing.Point(308, 77);
            this.telText.Name = "telText";
            this.telText.Size = new System.Drawing.Size(100, 19);
            this.telText.TabIndex = 12;
            // 
            // mailText
            // 
            this.mailText.Enabled = false;
            this.mailText.Location = new System.Drawing.Point(308, 126);
            this.mailText.Name = "mailText";
            this.mailText.Size = new System.Drawing.Size(100, 19);
            this.mailText.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 240);
            this.Controls.Add(this.mailText);
            this.Controls.Add(this.telText);
            this.Controls.Add(this.adressText);
            this.Controls.Add(this.ageText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.selectIdBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox selectIdBox;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.TextBox adressText;
        private System.Windows.Forms.TextBox telText;
        private System.Windows.Forms.TextBox mailText;
    }
}

