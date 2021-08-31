using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherChecker
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> cityNames;

        public Form1()
        {
            InitializeComponent();

            this.cityNames = new Dictionary<string, string>();

            this.cityNames.Add("東京都", "3");
            this.cityNames.Add("大阪府", "1");
            this.cityNames.Add("愛知県", "2");
            this.cityNames.Add("福岡県", "10");

            foreach(KeyValuePair<string, string> data in this.cityNames)
            {
                areaBox.Items.Add(data.Key);
            }
        }
                
        private void CitySelected(object sender, EventArgs e)
        {
            //天気情報サービスにアクセスする
            // areaBox.Text は、表示しているテキストを読み込むプロパティ
            string cityCode = cityNames[areaBox.Text];
            string url = "https://and-idea.sbcr.jp/sp/90261/weatherCheck.php?city=" + cityCode;
            HttpClient client = new HttpClient();
            string result = client.GetStringAsync(url).Result;

            // 天気情報からアイコンンおURLを取り出す
            JObject jobj = JObject.Parse(result);
            string todayWeatherIcon = (string)((jobj["url"] as JValue).Value);
            weatherIcon.ImageLocation = todayWeatherIcon;

        }

        private void ExitMenuClicked(object sender, EventArgs e)
        {
            this.Close(); // フォームを閉じる
        }
    }
}
