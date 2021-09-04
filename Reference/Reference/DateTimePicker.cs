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
    public partial class DateTimePicker : Form
    {
        public DateTimePicker()
        {
            InitializeComponent();
            // FormBorderStyleの設定でサイズ固定にする
            // FormBorderStyleは列挙型
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // 最大化の無効
            this.MaximizeBox = false;
        }

        private void BirthDayClosedUp(object sender, EventArgs e)
        {  // 誕生日として選んだ日付から、年齢を計算します

            // 今日の日付の取得
            DateTime date = DateTime.Today;
            // DateTimeの日時をフォーマットを指定して文字列に変換するには、
            // ToStringメソッドの引数にフォーマットを指定
            string result = date.ToString("yyyyMMdd");
            // 数値へ変換
            int dateToday = int.Parse(result);

            // DateTimePickerで選んだ日付をフォーマット指定
            result = this.birthDayPicker.Value.ToString("yyyyMMdd");
            // 数値へ変換
            int dateSelectedDay = int.Parse(result);

            //yyyymmdd形式で表記した今日の日付から、
            //同じくyyyymmdd形式で表記した誕生日を
            //そのまま引き算し、10,000で割った解の
            //整数部分を現時点での年齢とすることができる
            int age = (dateToday - dateSelectedDay) / 10000;
            this.ageCalced.Text = age.ToString();

        }

        private void CopyClicked(object sender, EventArgs e)
        {
            //クリップボードにテキストボックスの文字列をコピーする
            string str = this.eventText.Text; // eventTextはイベントハンドラの処理を記載したTextBoxのインスタンス名です
            Clipboard.SetText(str);

        }

    }
}
