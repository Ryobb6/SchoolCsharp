﻿
namespace PracticeGame
{
    partial class PalletForm2D
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
            this.colorSelect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // colorSelect
            // 
            this.colorSelect.Location = new System.Drawing.Point(322, 12);
            this.colorSelect.Name = "colorSelect";
            this.colorSelect.Size = new System.Drawing.Size(50, 46);
            this.colorSelect.TabIndex = 1;
            this.colorSelect.UseVisualStyleBackColor = true;
            this.colorSelect.Click += new System.EventHandler(this.ColorButtonClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 75);
            this.button1.TabIndex = 2;
            this.button1.Text = "Circle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CircleClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 75);
            this.button2.TabIndex = 3;
            this.button2.Text = "Rectangle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.RectangleClicked);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(218, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 75);
            this.button3.TabIndex = 4;
            this.button3.Text = "Line";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.LineClicked);
            // 
            // PalletForm2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.colorSelect);
            this.Name = "PalletForm2D";
            this.Text = "2DPallet";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PalletForm2D_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button colorSelect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}