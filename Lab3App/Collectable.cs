using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal abstract class Collectable : Displayable
    {
        public CollectionBoard Brd;
        protected String Desc;

        public Collectable(String name, int score = 0, int value = 0)
        {
            Desc = name;
        }

        public virtual void AddMe(List<Collectable> list)
        {
            Console.WriteLine($"{Desc} Collected, Congrats!!!!");
        }

        public abstract void Display();
    }
}