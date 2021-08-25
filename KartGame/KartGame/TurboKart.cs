using System;
using System.Collections.Generic;
using System.Text;

namespace KartGame
{
    class TurboKart : Kart
    {
        public void Turbo()
        {
            Console.WriteLine("ブースト");
        }

        // Hornメソッドをオーバーライドする
        public override void Horn()
        {
            Console.WriteLine("ビービー");
        }

    }
}
