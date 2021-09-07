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
            //JSONデータはJToken.Parseメソッドを使ってJTokenのインスタンスとすることができる
            JToken jt = JToken.Parse(this.jsonDataTextBox.Text);
            //JToken型のままでは値の取得ができないため、as演算子を使ってJValueにキャスト
            JValue jv = jt as JValue;
            //プロパティ「Value」で値を取得する。(プロパティ「Value」の型はObject型)
            resultTextBox.Text = jv.Value.ToString();//テキストをセットする場合はToStringメソッドで文字列を取得する必要がある。
        }
    }

}
