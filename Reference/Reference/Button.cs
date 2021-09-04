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
    public partial class Button : Form
    {
        public Button()
        {
            InitializeComponent();
            // 共通処理
            // FormBorderStyleの設定でサイズ固定にする
            // FormBorderStyleは列挙型
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // 最大化の無効
            this.MaximizeBox = false;
        }

       

        private void Button1Clicked(object sender, EventArgs e)
        {
            string str = this.button1.Text;

            switch (str)
            {// C#のswitch文ではbreak文の省略(フォロースルー)は禁止です
                case "答えをみる":
                    // changeLabelはこのラベルのインスタンス変数名です
                    this.changeLabel.Text = "ロムスカ・パロ・ウル・ラピュタです";
                    // button1はボタンのインスタンス変数名です
                    this.button1.Text = "バルス";
                    break;
                case "バルス":
                    this.changeLabel.Text = "目がーーーッ!!!";
                    this.button1.Text = "戻る";
                    break;
                case "戻る":
                    this.changeLabel.Text = "ムスカ大佐の本名は何でしょう？";
                    this.button1.Text = "答えをみる";
                    break;
                    //defaultは省略可能
            }  
        }

        private void CopyClicked(object sender, EventArgs e)
        {
            //クリップボードにテキストボックスの文字列をコピーする
            string str = this.eventText.Text; // eventTextはイベントハンドラの処理を記載したTextBoxのインスタンス名です
            Clipboard.SetText(str);

        }
    }
}
