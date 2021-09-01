
namespace DrawApp
{
    partial class Pallet
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
            this.circleButton = new System.Windows.Forms.Button();
            this.rectangleButton = new System.Windows.Forms.Button();
            this.lineButton = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.penSizeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // circleButton
            // 
            this.circleButton.Location = new System.Drawing.Point(46, 27);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(158, 142);
            this.circleButton.TabIndex = 0;
            this.circleButton.Text = "Circle";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.CircleButtonCliked);
            // 
            // rectangleButton
            // 
            this.rectangleButton.Location = new System.Drawing.Point(223, 27);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(158, 142);
            this.rectangleButton.TabIndex = 1;
            this.rectangleButton.Text = "Rectangle";
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.MouseCaptureChanged += new System.EventHandler(this.RectButtonClicked);
            // 
            // lineButton
            // 
            this.lineButton.Location = new System.Drawing.Point(397, 27);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(158, 142);
            this.lineButton.TabIndex = 2;
            this.lineButton.Text = "Line";
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.Click += new System.EventHandler(this.LineButtonClicked);
            // 
            // colorButton
            // 
            this.colorButton.BackColor = System.Drawing.SystemColors.WindowText;
            this.colorButton.Location = new System.Drawing.Point(597, 63);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(109, 23);
            this.colorButton.TabIndex = 3;
            this.colorButton.UseVisualStyleBackColor = false;
            this.colorButton.Click += new System.EventHandler(this.ColorButtonClicked);
            // 
            // penSizeBox
            // 
            this.penSizeBox.Location = new System.Drawing.Point(597, 119);
            this.penSizeBox.Name = "penSizeBox";
            this.penSizeBox.Size = new System.Drawing.Size(109, 22);
            this.penSizeBox.TabIndex = 4;
            this.penSizeBox.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(597, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(597, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "pensize";
            // 
            // Pallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 195);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.penSizeBox);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.lineButton);
            this.Controls.Add(this.rectangleButton);
            this.Controls.Add(this.circleButton);
            this.Name = "Pallet";
            this.Text = "Pallet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.Button lineButton;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.TextBox penSizeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}