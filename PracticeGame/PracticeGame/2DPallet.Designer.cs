
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
            this.circleButton = new System.Windows.Forms.Button();
            this.rectangleButton = new System.Windows.Forms.Button();
            this.lineButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // colorSelect
            // 
            this.colorSelect.BackColor = System.Drawing.SystemColors.Highlight;
            this.colorSelect.Location = new System.Drawing.Point(310, 50);
            this.colorSelect.Name = "colorSelect";
            this.colorSelect.Size = new System.Drawing.Size(50, 46);
            this.colorSelect.TabIndex = 1;
            this.colorSelect.UseVisualStyleBackColor = false;
            this.colorSelect.Click += new System.EventHandler(this.ColorButtonClicked);
            // 
            // circleButton
            // 
            this.circleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circleButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.circleButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.circleButton.Location = new System.Drawing.Point(23, 36);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(77, 75);
            this.circleButton.TabIndex = 2;
            this.circleButton.Text = "Circle";
            this.circleButton.UseVisualStyleBackColor = false;
            this.circleButton.Click += new System.EventHandler(this.CircleClicked);
            // 
            // rectangleButton
            // 
            this.rectangleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rectangleButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rectangleButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rectangleButton.Location = new System.Drawing.Point(121, 36);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(77, 75);
            this.rectangleButton.TabIndex = 3;
            this.rectangleButton.Text = "Rectangle";
            this.rectangleButton.UseVisualStyleBackColor = false;
            this.rectangleButton.Click += new System.EventHandler(this.RectangleClicked);
            // 
            // lineButton
            // 
            this.lineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lineButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lineButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lineButton.Location = new System.Drawing.Point(218, 36);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(77, 75);
            this.lineButton.TabIndex = 4;
            this.lineButton.Text = "Line";
            this.lineButton.UseVisualStyleBackColor = false;
            this.lineButton.Click += new System.EventHandler(this.LineClicked);
            // 
            // PalletForm2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.lineButton);
            this.Controls.Add(this.rectangleButton);
            this.Controls.Add(this.circleButton);
            this.Controls.Add(this.colorSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PalletForm2D";
            this.Text = "2DPallet";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PalletForm2D_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button colorSelect;
        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.Button lineButton;
    }
}