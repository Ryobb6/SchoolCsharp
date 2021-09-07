﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeGame
{
    
    public partial class Form1 : Form
    {
        Point startPos, endPos;
        private PalletForm2D palletForm2D;
        private PalletForm3D palletForm3D;

        public Form1()
        {
            InitializeComponent();
            this.palletForm2D = new PalletForm2D();
            this.palletForm3D = new PalletForm3D();
        }

        //プロパティ(使わないかも.. →後で削除)
        public PalletForm2D PalletForm2D { get; set; }
        public PalletForm3D PalletForm3D { get; set; }

        //sender はイベントを送信したオブジェクトです。
        //イベントを送信したのがどのボタンなのかどのテキストボックスなのかわからないので sender で区別します。
              

        private void ButtonClicled(object sender, EventArgs e)
        {
            string str = this.button1.Text;
            if(str == "Change3DView")
            {
                this.button1.Text = "Change2DView";
                this.view3D.Visible = true;
                this.view2D.Visible = false;
            }
            else
            {
                this.button1.Text = "Change3DView";
                this.view3D.Visible = false;
                this.view2D.Visible = true;
            }
        }

        private void Draw2D(object sender, PaintEventArgs e)
        { // PanelObjectのPaintを呼んでいます
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //this.view2D.DubbleBuffered = true;
            int type = this.palletForm2D.FigureType;
            Color color = Color.Orange;
            int penSize = 3;

            if(type == 1)
            {
                SolidBrush brush = new SolidBrush(color);
                int width = this.endPos.X - this.startPos.X;
                int height = this.endPos.Y - this.startPos.Y;
                e.Graphics.FillEllipse(brush, this.startPos.X, this.startPos.Y, width, height);
            }
            else if(type == 2)
            {
                SolidBrush brush = new SolidBrush(color);
                
                int width = this.endPos.X - this.startPos.X;
                int height = this.endPos.Y - this.startPos.Y;
                e.Graphics.FillRectangle(brush, this.startPos.X, this.startPos.Y, width, height);
            }
            else if(type == 3)
            {
                Pen p = new Pen(color, penSize);
                e.Graphics.DrawLine(p, this.startPos.X, this.startPos.Y, this.endPos.X, this.endPos.Y);
            }

        }

        private void Plt2DClicked(object sender, EventArgs e)
        {
            palletForm2D.Show();
        }

        private void MousePressed(object sender, MouseEventArgs e)
        {
            this.startPos = new Point(e.X, e.Y);
        }

        private void MouseDragged(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if(this.palletForm2D.FigureType == 1 || this.palletForm2D.FigureType == 3)
                {
                    this.endPos = new Point(e.X, e.Y);
                    this.view2D.Invalidate();
                }
                else if(this.palletForm2D.FigureType == 2)
                {
                    if(e.X <= this.startPos.X && e.Y <= this.startPos.Y)
                    {
                        this.endPos = new Point(this.startPos.X, this.startPos.Y);
                        this.startPos = new Point(e.X, e.Y);
                    }else if (e.X <= this.startPos.X && e.Y >= this.startPos.Y)
                    {
                        this.endPos = new Point(this.startPos.X, e.Y);
                        this.startPos = new Point(e.X, this.startPos.Y);

                    }else if(e.X >= this.startPos.X && e.Y <= this.startPos.Y)
                    {
                        this.endPos = new Point(e.X, this.startPos.Y);
                        this.startPos = new Point(this.startPos.X, e.Y);
                    }else if(e.X >= this.startPos.X && e.Y >= this.startPos.Y)
                    {
                        this.endPos = new Point(e.X, e.Y);
                    }
                }
            }
        }

        private void MouseButtonUp(object sender, MouseEventArgs e)
        {
            if (this.palletForm2D.FigureType == 2)
            {
 
                    this.view2D.Invalidate();
                
            }
        }

        private void Plt3DClicked(object sender, EventArgs e)
        {
            palletForm3D.Show();
        }
    }
}
