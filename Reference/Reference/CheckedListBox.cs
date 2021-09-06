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
    public partial class CheckedListBox : Form
    {
        public CheckedListBox()
        {
            InitializeComponent();
            // FormBorderStyleの設定でサイズ固定にする
            // FormBorderStyleは列挙型
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // 最大化の無効
            this.MaximizeBox = false;
        }

        private void CopyClicked(object sender, EventArgs e)
        {
            //クリップボードにテキストボックスの文字列をコピーする
            string str = this.eventText.Text; // eventTextはイベントハンドラの処理を記載したTextBoxのインスタンス名です
            Clipboard.SetText(str);
        }

        private void CheckingItem(object sender, EventArgs e)
        {// ボタンのClickイベントが呼ばれます
            // もし、テキストが入っていれば、文字を消去します。
            if(this.addTextBox.Text.Length != 0)
            {
                this.addTextBox.Clear();
            }
            // 追加する文字列を用意
            string str = null;
            // チェックされた項目のリストから文字列を取得
            foreach(string language in this.checkedLikeLang.CheckedItems)
            {
                str += "、" + language;
            }

            // 文字列に追加する項目(チェックされた項目がない場合)
            if(str == null)
            {
                str = "この中には無い";
            }
            this.addTextBox.Text += "私が興味を持っている言語は" 
                + str + "です";
        }
    }
}
