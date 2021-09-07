using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Reference
{
    public partial class ListBox : Reference.BaseCommonControle
    {
        public ListBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ボタンを押すと追加できるようにします
            String str = this.siteBox.Text;
            if(str.Length != 0)
            {
                this.siteListBox.Items.Add(str);
            }
            
        }

        private void siteBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Enterを押すと、ボタンを押さなくても追加できます
            string str = this.siteBox.Text;
            if (str.Length != 0)
            {// e.KeyCharはASCII文字を戻り値としてかえすので、
             // 比較する際は、ASCII文字で比較
             // Keysは列挙型
                Keys a = Keys.Enter;
                char ent = (char)Keys.Enter;
                if (e.KeyChar  == ent)
                {
                    Console.WriteLine(a+" "+ent);
                    this.siteListBox.Items.Add(str);
                }
            }
        }
    }
}
