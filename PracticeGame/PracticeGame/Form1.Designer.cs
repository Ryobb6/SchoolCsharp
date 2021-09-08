
namespace PracticeGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.view3D = new System.Windows.Forms.Panel();
            this.pallet3D = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.view2D = new System.Windows.Forms.Panel();
            this.pallet2D = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.view3D.SuspendLayout();
            this.view2D.SuspendLayout();
            this.SuspendLayout();
            // 
            // view3D
            // 
            this.view3D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.view3D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.view3D.Controls.Add(this.pallet3D);
            this.view3D.Controls.Add(this.label1);
            this.view3D.Location = new System.Drawing.Point(22, 52);
            this.view3D.Name = "view3D";
            this.view3D.Size = new System.Drawing.Size(914, 510);
            this.view3D.TabIndex = 1;
            this.view3D.Visible = false;
            this.view3D.Paint += new System.Windows.Forms.PaintEventHandler(this.Draw3D);
            this.view3D.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MousePressed3D);
            this.view3D.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseDragged3D);
            this.view3D.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseButtonUp3D);
            // 
            // pallet3D
            // 
            this.pallet3D.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pallet3D.Location = new System.Drawing.Point(807, 7);
            this.pallet3D.Name = "pallet3D";
            this.pallet3D.Size = new System.Drawing.Size(75, 23);
            this.pallet3D.TabIndex = 3;
            this.pallet3D.Text = "3DPallet";
            this.pallet3D.UseVisualStyleBackColor = true;
            this.pallet3D.Click += new System.EventHandler(this.Plt3DClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "3DView";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Change3DView";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonClicled);
            // 
            // view2D
            // 
            this.view2D.AllowDrop = true;
            this.view2D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.view2D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.view2D.Controls.Add(this.pallet2D);
            this.view2D.Controls.Add(this.label2);
            this.view2D.Location = new System.Drawing.Point(22, 52);
            this.view2D.Name = "view2D";
            this.view2D.Size = new System.Drawing.Size(914, 510);
            this.view2D.TabIndex = 0;
            this.view2D.Paint += new System.Windows.Forms.PaintEventHandler(this.Draw2D);
            this.view2D.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MousePressed);
            this.view2D.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseDragged);
            this.view2D.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseButtonUp);
            // 
            // pallet2D
            // 
            this.pallet2D.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pallet2D.Location = new System.Drawing.Point(807, 7);
            this.pallet2D.Name = "pallet2D";
            this.pallet2D.Size = new System.Drawing.Size(75, 23);
            this.pallet2D.TabIndex = 2;
            this.pallet2D.Text = "2DPallet";
            this.pallet2D.UseVisualStyleBackColor = true;
            this.pallet2D.Click += new System.EventHandler(this.Plt2DClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "2DView";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(948, 588);
            this.Controls.Add(this.view2D);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.view3D);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "EasyDraw";
            this.view3D.ResumeLayout(false);
            this.view3D.PerformLayout();
            this.view2D.ResumeLayout(false);
            this.view2D.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button pallet3D;
        private System.Windows.Forms.Button pallet2D;
        protected System.Windows.Forms.Panel view2D;
        protected System.Windows.Forms.Panel view3D;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

