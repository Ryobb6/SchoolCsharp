using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> phoneBook;

        public Form1()
        {
            InitializeComponent();
            this.phoneBook = new Dictionary<string, string>();
            this.phoneBook.Add("山田一郎", "080-0000-1212");
            this.phoneBook.Add("タケモトピアノ", "0120-307-0000");
            this.phoneBook.Add("ECL", "080-9339-1030");

            // 実行時点で、ListBox(nameList)にKeyだけ表示させる
            // nameList.ItemsプロパティでListインスタンスにキーをAddしていく

            foreach (KeyValuePair<string, string> data in phoneBook)
            {
                this.nameList.Items.Add(data.Key);
            }

        }

        private void NameSelected(object sender, EventArgs e)
        {
            // 選択した名前に対応する電話番号を表示する
            string name = this.nameList.Text;
            this.phoneNumber.Text = this.phoneBook[name];
            
        }
    }
}
