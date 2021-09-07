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
    public partial class PalletForm3D : Form
    {
        public PalletForm3D()
        {
            InitializeComponent();
        }

        private void PalletForm3D_FormClosing(object sender, FormClosingEventArgs e)
        {
            // フォームが閉じられ前に呼ばれるイベントです→まだインスタンス破棄されていない
            // このイベントをキャンセルします→インスタンスは破棄されないままである
            e.Cancel = true;
            this.Visible = false;　// このフォームを非表示にします
        }

        private void ColorButtonClicked(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                // 選択した色をボタンに設定する
                colorSelect.BackColor = colorDialog.Color;
            }

        }
    }
}
