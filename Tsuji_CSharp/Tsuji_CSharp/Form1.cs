using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tsuji_CSharp
{
    public partial class Form1 : Form
    {
        List<User> userList; //ファイルから読み取ったユーザー情報を格納するリスト
        public Form1()
        {
            InitializeComponent();
            this.userList = new List<User>();
            // テキストデータfileを読み込むメソッド
            TextRead();
            // IDをcomboBoxに追加するメソッド
            AddSelectId();
        }


        /// <summary>
        /// テキストデータの読み込みメソッド
        /// (他クラスから呼び出すことはないので、privateメソッドとした)
        /// </summary>
        private void TextRead()
        {
            using(StreamReader file = new StreamReader(@"..\..\Testdata.txt"))
            {
                User user;
                while (!file.EndOfStream)
                {
                    //一行ずつデータを読み取り、string型の変数を作成し初期値として代入
                    string line = file.ReadLine();
                    // 文字列型変数の値をカンマで分割したものを初期値として代入
                    string[] data = line.Split(',');
                    user = new User(data[0], data[1], int.Parse(data[2]), data[3], data[4], data[5]);
                    //生成したuserインスタンス(各個人情報を持つ)を、
                    //このクラスのフィールドのリスト(userList)に追加
                    this.userList.Add(user);
                }
            }
        }


        /// <summary>
        /// コントロールselectIdBoxのItemsプロパティに
        /// Userインスタンスの変数idを追加
        /// (このクラスのフィールドのuserListを利用します)
        /// (他クラスから呼び出すことはないので、privateメソッドとした)
        /// </summary>        
        private void AddSelectId()
        {
            foreach(User user in this.userList)
            {
                this.selectIdBox.Items.Add(user.Id);
            }
        }


        /// <summary>
        /// UserID対応した情報を各TextBoxのTextプロパティに代入するイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewUserInfo(object sender, EventArgs e)
        {
            //selectBoxIdのTextプロパティとUser型Listの要素(インスタンス)のidの値が
            //一緒のインスタンスを   取得する。LINQのメソッドWhereとFirstメソッドを用いれば、
            //一つだけインスタンスを取得できる。

            // Whereは条件を満たすコレクションを返す
            var usersList2 = userList.Where(n => n.Id == (string)this.selectIdBox.SelectedItem);
           
            // 復習用コメント : First()について
            // そのコレクション(List)の中の先頭の要素(User型 インスタンス)を取得
            // (同じIDをもつユーザーがいないので、今回は先頭の要素しかないが...
            // 例えば、同じIDを持つユーザーが2人以上いた場合、
            // そのリストの中で、先頭の要素が返される

            User usersInfo = usersList2.First(); // 復習用コメント : 本来はエラー処理必要(...らしい) 

            //取得したインスタンスの値を対応したTextBoxのTextプロパティに代入する。
            this.nameText.Text = usersInfo.Name;
            this.ageText.Text = usersInfo.Age.ToString();
            this.adressText.Text = usersInfo.Address;
            this.telText.Text = usersInfo.PhoneNumber;
            this.mailText.Text = usersInfo.MailAddress;

        }
    }
}

