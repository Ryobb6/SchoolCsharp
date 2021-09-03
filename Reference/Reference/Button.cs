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
        }

        private void CMNButtonClicked(object sender, EventArgs e)
        {
            this.helloLabel.Text = "文字が変わります";
        }
    }
}
