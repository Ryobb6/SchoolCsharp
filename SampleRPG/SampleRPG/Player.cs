using System;
using System.Collections.Generic;
using System.Text;

namespace SampleRPG
{
    class Player
    {

        private string name;
        private int hp;
        private int mp;

        public Player(string name, int hp)
        {
            this.name = name;
            this.hp = hp;

        }

        // プロパティ
        public int Hp
        {
            set
            {
                this.hp = value;
                if (this.hp < 0)
                {
                    this.hp = 0;
                }
            }
            get
            {
                return this.hp; 
            }

        }

        public void Attack()
        {
            Console.WriteLine(this.name + "は攻撃した");
        }

        static void Recover(Player player)
        {
            player.hp = 100;
        }

        // HP回復(ref演算子利用)
        
        static void RecoverHp(ref int hp)
        {
            hp = 100;
        }

        // MP回復(out演算子利用)
        static void RecoverMp(out int mp)
        {
            mp = 100;
        }


        public void Defence()
        {
            Console.WriteLine(this.name + "は防御した");
        }

    }
}
