using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsuji_CSharp
{
    class User
    {
        private string id;
        private string name;
        private int age;　// インスタンス生成時、実引数内で変換を行う
        private string address;
        private string phoneNumber;
        private string mailAddress;

        public User(string id, string name, int age, string address,string phoneNumber, string mailaddress)
        {
            // プロパティを使用して初期値をセット
            Id = id;
            Name = name;
            Age = age;
            Address = address;
            PhoneNumber = phoneNumber;
            MailAddress = mailaddress;
        }

        // コードが長くなるため、1行で記載
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string MailAddress { get => mailAddress; set => mailAddress = value; }

    }
}
