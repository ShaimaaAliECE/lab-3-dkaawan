﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Axe : Tool
    {
        public Axe(string name, int score = 0, int value = 0) : base(name, score, value)
        {
            Desc = name;
        }

        public override void DoAction()
        {
            Console.WriteLine("Axe is Used");
        }
        public override void Display()
        {
            Console.Write($"Axe {Desc} is displayed\n");
        }
        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
        }
    }
}