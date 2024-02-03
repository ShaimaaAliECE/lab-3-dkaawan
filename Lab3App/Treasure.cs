using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal abstract class Treasure : Collectable
    {
        private int score;

        public Treasure(String name, int score = 0, int value = 0) : base(name, score, value)
        {
            Desc = name;
            this.score = score;
        }

        private void UpdateTotalScore()
        {
            CollectionBoard.TotalScore = CollectionBoard.TotalScore + score;
            Console.WriteLine($"Total Score is updated to: {CollectionBoard.TotalScore}");
        }
        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            UpdateTotalScore();
        }
    }
}