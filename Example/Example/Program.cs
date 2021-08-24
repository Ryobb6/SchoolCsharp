using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // C#において、Javaと異なる基本的な点のまとめメソッド


            // stringのsは小文字が推奨
            string name;
            name = "きたむら";

            // 定数はconst
            const int num = 3;
            Console.WriteLine(num);

            // stringも==で判定可能
            if(name == "きたむら")
            {
                Console.WriteLine(name);
            }

            // switch文
            // <フォロースルー>
            // Javaでは許されたbreak無しでのフォロースルーが許されない。(バグの元という判断)
            // 要するに、必ずbreak;文を全てのcaseおよび、defalutの末尾につけなければならない。

            // <条件式>
            // C#のswtich文では,条件式の評価結果に整数(int型)以外に文字列(string型)も利用できる
            
            String str = "りんご";
            switch (str)
            {
                case "りんご": //strが「りんご」の時に実行する
                    Console.WriteLine("赤色です。"); //コンソール画面に「赤色です」と出力する。
                    break;  //switch文から抜ける
                case "バナナ": //strが「バナナ」の時に実行する
                    Console.WriteLine("黄色です"); //コンソール画面に「黄色です」と出力する。
                    break; //switch文から抜ける
                default:    //strが上記以外の場合に実行する
                    Console.WriteLine("何色かわかりません。"); //コンソール画面に「何色かわかりません。」と出力する。
                    break; //switch文から抜ける
            }


            // while文練習(Javaと一緒)
            int sum = 0;
            while (true)
            {
                sum++;

                if(sum > 500) // numが500を超えたらbreakでループを抜ける
                {
                    Console.WriteLine(sum); // sum == 501がコンソールに表示される
                    break;
                }

            }

            // 多次元配列の初期化
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 } };

            // 配列の要素数 .Length　(文字列、コレクションにも適用化)
            float[] weights = { 45.0f, 46.0f, 49.5f, 60.3f };
            Console.WriteLine(weights.Length);

            // 拡張for文 = foreach
            foreach(float weight in weights)
            {
                Console.WriteLine(weight);
            }




        }
    }
}
