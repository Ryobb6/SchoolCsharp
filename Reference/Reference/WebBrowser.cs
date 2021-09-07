using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Reference
{
    public partial class WebBrowser : Reference.BaseCommonControle
    {
        public WebBrowser()
        {
            InitializeComponent();
        }

        private void ShowBrowser(object sender, EventArgs e)
        {
            Browser browser = new Browser();
            browser.Show();

        }
    }
}
