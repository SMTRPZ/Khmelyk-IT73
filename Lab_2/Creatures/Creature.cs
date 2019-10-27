using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Creatures
{
    public abstract class Creature
    {
        protected string name;

        public Creature(string name) { this.name = name; }
        public virtual string Voice() { return ""; }
        public virtual string GiveName() { return name; }
    }
}
