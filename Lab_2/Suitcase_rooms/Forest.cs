using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_2.Creatures;

namespace Lab_2.Suitcase_rooms
{
    public class Forest : Place
    {
        private List<Creature> Creatures { get; set; }
        public Forest(string name) : base(name)
        {
            Creatures = new List<Creature>();
        }
        public override bool GetCapacity()
        {
            bool hasPlace = true;
            Creatures.Capacity = 5;
            if (Creatures.Count >= Creatures.Capacity) hasPlace = false;
            return hasPlace;
        }
        public override bool IsComposite()
        {
            return false;
        }
        public override bool CreatureIsHere(string creature_name)
        {
            return Creatures.Exists(a => a.GiveName() == creature_name);
        }
        public override string AskVoiceConcrete(string name)
        {
            return Creatures.Find(a => a.GiveName() == name).Voice();
        }
        public override bool GetCreatureRoom(string type)
        {
            bool hasRoom = false;
            if ((type == "Demiguise" || type == "Bowtruckle") && GetCapacity() == true) hasRoom = true;
            return hasRoom;
        }
        public override void AddCreature(string type, string name)
        {
            Creatures.Add(new Demiguise(name));
        }
    }
}
