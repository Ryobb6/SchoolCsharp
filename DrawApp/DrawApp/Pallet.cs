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
    public partial class Pallet : Form
    {
        int figureType; // 図形の種類

        public int GetFigureType() // 図形の種類取得
        {
            return figureType;
        }

        public int GetPenSize()
        {
            int size;
            if (int.TryParse(this.penSizeBox.Text, out size))
            {
                return size;
            }
            else
            {
                return 1;
            }
        }

        public Color GetColor()
        {
            return colorButton.BackColor;
        }

        public Pallet()
        {
            InitializeComponent();
            this.figureType = 1;
        }

        private void CircleButtonCliked(object sender, EventArgs e)
        {
            this.figureType = 1;
        }

        private void RectButtonClicked(object sender, EventArgs e)
        {
            this.figureType = 2;
        }

        private void LineButtonClicked(object sender, EventArgs e)
        {
            this.figureType = 3;
        }

        private void ColorButtonClicked(object sender, EventArgs e)
        {
            // カラーダイアログの表示
            ColorDialog colorDialog = new ColorDialog();

            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                // 選択した色をボタンに設定する
                colorButton.BackColor = colorDialog.Color;
            }

        }
    }
}
