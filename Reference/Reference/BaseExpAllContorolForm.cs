using System;
using System.Windows.Forms;

namespace Reference
{
    public partial class BaseExpAllContorolForm : Reference.BaseExplainForm
    {

        public BaseExpAllContorolForm()
        {
            InitializeComponent();
        }

        private void CopyClicked(object sender, EventArgs e)
        {
            //クリップボードにテキストボックスの文字列をコピーする
            string str = this.eventText.Text; // eventTextはイベントハンドラの処理を記載したTextBoxのインスタンス名です
            Clipboard.SetText(str);
        }
    }
}
