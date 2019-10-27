using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Creatures
{
    public class Occamy : Creature
    {
        const double FoodQuantity = 1.03;
        public Occamy(string name) : base(name) { }
        public override string Voice() { return "Arrrgh"; }
    }
}
