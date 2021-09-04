﻿using System;
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
        /// <summary>
        /// Home画面が表示された際に、大きさの固定と、最大化をfalseへ設定します。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HomeLoaded(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
           
        }
        /// <summary>
        /// Buttonの説明フォームインスタンスを初期化し、表示します
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Button button = new Button();
            button.Show();
        }
        /// <summary>
        /// CheckBoxの説明フォームインスタンスを初期化し、表示します
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExpCheckBoxClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Show();
        }
        /// <summary>
        /// CheckedListBoxの説明フォームインスタンスを初期化し、表示します
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EcpCheckedListBox(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckedListBox checkedListBox = new CheckedListBox();
            checkedListBox.Show();

        }
        /// <summary>
        /// ConboBoxの説明フォームインスタンスを初期化し、表示します
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExpConboBoxClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ComboBox comboBox = new ComboBox();
            comboBox.Show();

        }
        /// <summary>
        /// DateTimePickerの説明フォームインスタンスを初期化し、表示します
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExpDateTimePickerClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DateTimePicker dateTimePicker = new DateTimePicker();
            dateTimePicker.Show();

        }
        /// <summary>
        /// Label(LinkLabelの説明も記載している)の説明フォームインスタンスを初期化し、表示します
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExpLabelClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {// LinkedLabelの説明もまとめた
            Label label = new Label();
            label.Show();

        }

        /// <summary>
        /// ListBoxの説明フォームインスタンスを初期化し、表示します
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExpListBox(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListBox listBox = new ListBox();
            listBox.Show();
        }
        /// <summary>
        /// ListViewの説明フォームをインスタンス化を初期化し、表示します
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExpListView(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListView listView = new ListView();
            listView.Show();
        }
        /// <summary>
        /// MaskedTextBoxの説明フォームをインスタンス化を初期化し、表示します
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExpMaskedTextBox(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MaskedTextBox maskedTextBox = new MaskedTextBox();
            maskedTextBox.Show();
        }
        /// <summary>
        /// MonthCalenderの説明フォームをインスタンス化を初期化し、表示します
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExpMonthCalender(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MonthCalendar monthCalendar = new MonthCalendar();
            monthCalendar.Show();
        }
        /// <summary>
        /// NotifyIconの説明フォームをインスタンス化を初期化し、表示します
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotifyIcon(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Show();
        }
        /// <summary>
        /// NumericUpDownの説明フォームをインスタンス化を初期化し、表示します
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExpNumericUpDown(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NumericUpDown numericUpDown = new NumericUpDown();
            numericUpDown.Show();
        }
        /// <summary>
        /// NumericUpDownの説明フォームをインスタンス化を初期化し、表示します
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExpPictureBox(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        /// <summary>
        /// ProgressBarの説明フォームをインスタンス化を初期化し、表示します
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExpProgressBar(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        /// <summary>
        /// RadioButtonの説明フォームをインスタンス化を初期化し、表示します
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExpRadioButton(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        /// <summary>
        /// ToolBoxの説明フォームをインスタンス化を初期化し、表示します
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExpToolBox(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        /// <summary>
        /// ToolTipの説明フォームをインスタンス化を初期化し、表示します
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExpToolTip(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        /// <summary>
        /// TreeViewの説明フォームをインスタンス化を初期化し、表示します
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExpTreeView(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        /// <summary>
        /// WebBrowserの説明フォームをインスタンス化を初期化し、表示します
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExpWebBrowser(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
