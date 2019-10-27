using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Creatures
{
    public class Demiguise : Creature
    {
        const double FoodQuantity = 4.12;
        public Demiguise(string name) : base(name) { }
        public override string Voice() { return "\"Urff Urff\""; }
    }
}
