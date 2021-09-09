using System;
using System.Collections.Generic;
using System.Text;

namespace LIstAndLinQ
{
    abstract class SampleClass // abstractメソッドを一つでも持っていれば、abstractクラス
    {
        
        int mp;
        

        public SampleClass(int hp)
        {
            this.Hp = hp; // 動きとしては、privateフィールドへアクセスする際と同様
        }


        public int Hp { get; set; }
        public int Mp { get => mp; set => mp = value; }

        public virtual void Horn()
        {
            Console.WriteLine("a");
        }

        public abstract void Tap(); 




    }
}
