using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Reference
{
    public partial class InfoForEngineer : Reference.BaseExplainForm
    {
        public InfoForEngineer()
        {
            InitializeComponent();
          

        }

        private void InfoForEngineer_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true; //JavaScript ErrorMEssageのダイアログを出さない処理です
            webBrowser1.Navigate("https://style.potepan.com/articles/31067.html");
        }

        private void CopyClicked(object sender, EventArgs e)
        {
            //クリップボードにGithubLinkの文字列をコピーする
            string str = this.GithubLink.Text;
            Clipboard.SetText(str);
        }

        private void CopyClicked2(object sender, EventArgs e)
        {
            //クリップボードに参考サイトLinkの文字列をコピーする
            string str = this.RefSiteLink.Text;
            Clipboard.SetText(str);
        }
    }
}
