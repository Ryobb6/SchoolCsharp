﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reference
{
    public partial class CheckBox : Form
    {
        public CheckBox()
        {
            InitializeComponent();
            // FormBorderStyleの設定でサイズ固定にする
            // FormBorderStyleは列挙型
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // 最大化の無効
            this.MaximizeBox = false;
        }

        private void BoxChecked(object sender, EventArgs e)
        {
            this.register.Text = "有料会員に登録されました";
        }
    }
}
