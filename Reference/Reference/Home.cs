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

    public partial class Home : Form
    {
        
        public Home()
        {
            InitializeComponent();
            
        }

        public Form1 Form1{ get; set; }

        private void HomeClosing(object sender, FormClosingEventArgs e)
        {
            
            // 新しくForm1インスタンスは破棄していないので、プロパティでインスタンスを参照し、Form1もClose
            Form1.Close();
                           
        }

        private void ButtonLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Button button = new Button();
            button.Show();
        }

        private void ExpCheckBoxClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Show();
        }

        private void HomeLoaded(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void EcpCheckedListBox(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckedListBox checkedListBox = new CheckedListBox();
            checkedListBox.Show();

        }
    }
}
