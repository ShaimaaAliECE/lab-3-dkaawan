using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal abstract class Tool : Collectable
    {
        public Tool(string name, int score = 0, int value = 0) : base(name, score, value)
        {
            Desc = name;
        }

        public abstract void DoAction();

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            DoAction();
        }
    }
}
