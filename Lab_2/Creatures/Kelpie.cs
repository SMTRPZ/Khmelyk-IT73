using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Creatures
{
    public class Kelpie : Creature
    {
        const double FoodQuantity = 11.8;
        public Kelpie(string name) : base(name) { }
        public override string Voice() { return "Roaar"; }
    }
}
