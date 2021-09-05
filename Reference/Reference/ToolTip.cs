using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Reference
{
    public partial class ToolTip : Reference.BaseCommonControle
    {
        public ToolTip()
        {
            InitializeComponent();
        }

        private void QestClicked(object sender, EventArgs e)
        {
            this.ToolTipLabel.Text = "有料会員に登録されました";
        }
    }
}
