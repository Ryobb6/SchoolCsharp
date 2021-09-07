using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Reference
{
    public partial class Browser : Reference.BaseForm
    {
        public Browser()
        {
            InitializeComponent();
        }

        private void Browser_Load(object sender, EventArgs e)
        {
            this.webBrowser1.ScriptErrorsSuppressed = true; //JavaScript ErrorMEssageのダイアログを出さない処理です
            this.webBrowser1.Navigate("https://www.youtube.com/channel/UCXvs_p2ZD28_Pa67cyN4FzQ/featured");
        }
    }
}
