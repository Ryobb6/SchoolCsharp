using System;
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
    public partial class PalletForm2D : Form
    {
       
        // 描画タイプのプロパティ
        public int FigureType { get; set; }

        public Color GetColor()
        {
            return this.colorSelect.BackColor;
        }

        public PalletForm2D()
        {
            InitializeComponent();
            this.FigureType = 1;
        }
        /// <summary>
        /// 設定したカラーを保持します
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PalletForm2D_FormClosing(object sender, FormClosingEventArgs e)
        {
            // フォームが閉じられ前に呼ばれるイベントです→まだインスタンス破棄されていない
            // このイベントをキャンセルします→インスタンスは破棄されないままである

            e.Cancel = true;
            this.Visible = false;　// このフォームを非表示にします
        }

        private void ColorButtonClicked(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // 選択した色をボタンに設定する
                colorSelect.BackColor = colorDialog.Color;
            }

        }

        private void CircleClicked(object sender, EventArgs e)
        {
            this.FigureType = 1;
        }

        private void RectangleClicked(object sender, EventArgs e)
        {
            this.FigureType = 2;
        }

        private void LineClicked(object sender, EventArgs e)
        {
            this.FigureType = 3;
        }
    }
}
