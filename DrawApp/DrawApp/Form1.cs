using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawFigures(object sender, PaintEventArgs e)
        {
            // 円を描画する
            SolidBrush brush = new SolidBrush(Color.Purple);
            e.Graphics.FillEllipse(brush, 0, 0, 200, 200);
        }
    }
}
