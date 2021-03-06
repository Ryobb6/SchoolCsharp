using System;
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
    public partial class Label : Form
    {
        public Label()
        {
            InitializeComponent();
            // FormBorderStyleの設定でサイズ固定にする
            // FormBorderStyleは列挙型
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // 最大化の無効
            this.MaximizeBox = false;
        }

        private void ForExpLinkLabel(object sender, LinkLabelLinkClickedEventArgs e)
        {  
            // LinkClickedイベントを実装
            this.NormalLabel.Text = "LinkLabelをクリックしました";
        }
    }
}
