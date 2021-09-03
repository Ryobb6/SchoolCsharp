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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Home = new Home(); // Form1は自動生成されるので、その際Homeを初期化しておく
        }

       
        public Home Home { get; set; }

        private void From1Load(object sender, EventArgs e)
        {
            // FormBorderStyleの設定でサイズ固定にする
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void FormClicked(object sender, EventArgs e)
        {
            // Form1をクリックしたら、Home画面が開きます
            Home.Show();
            // 自分自身のインスタンスをHomeへセット
            Home.Form1 = this;
            // 同時にForm1を閉じます(インスタンスは破棄されない。)
            this.Hide();
        }

      
    }
}
