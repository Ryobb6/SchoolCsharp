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

        private void GithubSiteLoaded(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.Navigate("");
        }
    }
}
