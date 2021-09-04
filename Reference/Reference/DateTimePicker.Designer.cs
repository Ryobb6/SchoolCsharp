
namespace Reference
{
    partial class DateTimePicker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateTimePicker));
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.birthDayPicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ageCalced = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.eventText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.AliceBlue;
            this.label5.Font = new System.Drawing.Font("游明朝", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(18, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 21);
            this.label5.TabIndex = 50;
            this.label5.Text = "イベントハンドラの処理 : ";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Font = new System.Drawing.Font("游明朝", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(18, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 49;
            this.label3.Text = "実行例: ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("游明朝", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(18, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 21);
            this.label2.TabIndex = 48;
            this.label2.Text = "説明 : ";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.AliceBlue;
            this.label14.Font = new System.Drawing.Font("游明朝", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(60, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(300, 50);
            this.label14.TabIndex = 47;
            this.label14.Text = "ユーザーが日付や時刻を選択できるようにするための、グラフィカルなカレンダーを表示します。";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("游明朝 Demibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 46;
            this.label1.Text = "DateTimePicker";
            // 
            // birthDayPicker
            // 
            this.birthDayPicker.Location = new System.Drawing.Point(91, 151);
            this.birthDayPicker.Name = "birthDayPicker";
            this.birthDayPicker.Size = new System.Drawing.Size(200, 19);
            this.birthDayPicker.TabIndex = 51;
            this.birthDayPicker.CloseUp += new System.EventHandler(this.BirthDayClosedUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 12);
            this.label4.TabIndex = 52;
            this.label4.Text = "生年月日を入力してください";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 12);
            this.label6.TabIndex = 53;
            this.label6.Text = "あなたの年齢は";
            // 
            // ageCalced
            // 
            this.ageCalced.AutoSize = true;
            this.ageCalced.Location = new System.Drawing.Point(173, 192);
            this.ageCalced.Name = "ageCalced";
            this.ageCalced.Size = new System.Drawing.Size(11, 12);
            this.ageCalced.TabIndex = 54;
            this.ageCalced.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 12);
            this.label8.TabIndex = 55;
            this.label8.Text = "才ですね";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.AliceBlue;
            this.label7.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(25, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(324, 36);
            this.label7.TabIndex = 56;
            this.label7.Text = "private void EventName(object sender, EventArgs e)\r\n        {\r\n";
            // 
            // eventText
            // 
            this.eventText.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.eventText.Location = new System.Drawing.Point(25, 288);
            this.eventText.Multiline = true;
            this.eventText.Name = "eventText";
            this.eventText.ReadOnly = true;
            this.eventText.Size = new System.Drawing.Size(330, 424);
            this.eventText.TabIndex = 57;
            this.eventText.Text = resources.GetString("eventText.Text");
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.AliceBlue;
            this.label9.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(25, 715);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(324, 23);
            this.label9.TabIndex = 58;
            this.label9.Text = "        }\r\n";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Reference.Properties.Resources._1757;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(335, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 21);
            this.button2.TabIndex = 59;
            this.toolTip1.SetToolTip(this.button2, "クリップボードにコピー");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CopyClicked);
            // 
            // DateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.eventText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ageCalced);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.birthDayPicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DateTimePicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "コモンコントロール/DateTimePicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker birthDayPicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ageCalced;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox eventText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}