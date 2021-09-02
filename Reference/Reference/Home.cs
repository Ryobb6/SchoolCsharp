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
    }
}
