using System;
using System.Collections.Generic;
using System.Text;

namespace KartGame
{
    class Kart
    {
        public int weight;
        public int speed;

        // アクセルを踏むメソッド
        public void Force()
        {
            Console.WriteLine("加速or減速");
        }

        // クラクションを鳴らす
        public virtual void Horn()
        {
            Console.WriteLine("ブッブー");

        }

    }
}
