using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Diamond : Treasure
    {
        public Diamond(String name, int score = 0, int value = 0) : base(name, score, value)
        {
            Desc = name;
        }

        public override void Display()
        {
            Console.Write($"Diamond{Desc} is displayed\n");
        }
    }
}
