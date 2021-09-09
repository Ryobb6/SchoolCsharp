using System;
using System.Collections.Generic;
using System.Text;

namespace LIstAndLinQ
{
    class SampleChildClass : SampleClass
    {
        
        public SampleChildClass(string name, int hp) : base(hp)
        {
            this.Name = name;
        }

        public SampleChildClass() : this("隆",2)
        {
            
            //規定値を決めて自身のコンストラクタを呼ぶ
            //引数無しのコンストラクタは、引数として何も持ってこれない
        }

        public string Name { get;}

        public override void Tap()
        {
            Console.WriteLine("c");
        }

        public override void Horn()
        {
            base.Horn(); // 親クラスのHorn()を呼び出す実装
            Console.WriteLine("d");
        }
    }
}
