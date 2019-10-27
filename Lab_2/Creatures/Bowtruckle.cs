using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Creatures
{
    public class Bowtruckle : Creature
    {
        const double FoodQuantity = 2.43;
        public Bowtruckle(string name) : base(name) { }
        public override string Voice() { return "Squeee"; }
    }
}
