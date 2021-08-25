using System;
using System.Collections.Generic;
using System.Text;

namespace SampleRPG
{
    class Player
    {

        private string name;
        private int hp;

        public Player(string name, int hp)
        {
            this.name = name;
            this.hp = hp;
        }

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
        public void Defence()
        {
            Console.WriteLine(this.name + "は防御した");
        }

    }
}
