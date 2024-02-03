using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Coin : Treasure
    {
        private int Value;

        public Coin(string name, int score = 0, int value = 0) : base(name, score, value)
        {
            Desc = name;
            this.Value = value;
        }

        private void UpdateTotalValue()
        {
            CollectionBoard.TotalValue = CollectionBoard.TotalValue + Value;
            Console.WriteLine($"Total Value is updated to: {CollectionBoard.TotalValue}");
        }
        public override void Display()
        {
            Console.Write($"Coin {Desc} is displayed\n");
        }
        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            UpdateTotalValue();
        }
    }
}
