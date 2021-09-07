using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnExecuteBtnClicked(object sender, EventArgs e)
        {
            JToken jt = JToken.Parse(jsonDataTextBox.Text);
            JValue jv = jt as JValue;
            resultTextBox.Text = jv.Value.ToString();

        }
    }
}
