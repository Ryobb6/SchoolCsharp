using System;
using System.Collections.Generic;
using System.Linq;

namespace LIstAndLinQ
{
    class Program
    {
        static Dictionary<string, string> phoneBook;
        static void Main(string[] args)
        {
            int[] hp = { 550, 420, 600, 80, 200 };
            List<int> newHp = new List<int>();

            newHp.Add(220);
            newHp.Insert(0, 500);

            Stack<float> sta = new Stack<float>();

            KeyValuePair<string, string> aaa = new KeyValuePair<string, string>();

            
            ReadFormFile();
            public void ReadFormFile()
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(@"aaa.text"))
                {
                    while (!file.EndOfStream)
                    {
                        string line = file.ReadLine();
                        string[] data = line.Split(',');
                        this.phoneBook.Add(data[0], data[1]);
                    }
                }
            }

            var numHp = hp.Select(n => n - 100);

            foreach(int n in numHp)
            {
                Console.WriteLine(n);
            }

            foreach(int n in newHp)
            {
                Console.WriteLine(n);
            }

            SampleChildClass sampleChildClass = new SampleChildClass("たつや", 4);
            int a = sampleChildClass.Hp;
            Console.WriteLine(a + sampleChildClass.Name);

            string[,] strs = { { "a", "b" }, { "c", "d" } };

            foreach(string str in strs)
            {
                Console.WriteLine(str);
            }

            string[,] ab = new string[4,4];
            ab[0, 0] = "abc";

            foreach(string str in ab)
            {
                Console.WriteLine(str);
            }

        }
    }
}
