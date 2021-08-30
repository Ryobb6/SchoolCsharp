using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        // クリックされたらClickイベントが発生する
        // イベントタグにてClickイベントにHelloButtonClickedイベントハンドラを追加している
        // そうすると、Form1へ自動でイベントハンドラメソッドが追加される

        private void HelloButtonClicked(object sender, EventArgs e)
        {
            this.helloLabel.Text = "Hello, world";
        }
    }
}
