using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_2.Creatures;

namespace Lab_2.Suitcase_rooms
{
    public class Pool : Place
    {
        private List<Creature> Kelpies { get; set; }
        public Pool(string name) : base(name)
        {
            Kelpies = new List<Creature>();
        }
        public override bool GetCapacity()
        {
            bool hasPlace = true;
            Kelpies.Capacity = 1;
            if (Kelpies.Count >= Kelpies.Capacity) hasPlace = false;
            return hasPlace;
        }
        public override bool IsComposite()
        {
            return false;
        }
        public override bool CreatureIsHere(string creature_name)
        {
            return Kelpies.Exists(a => a.GiveName() == creature_name);
        }
        public override string AskVoiceConcrete(string name)
        {
            return Kelpies.Find(a => a.GiveName() == name).Voice();
        }
        public override bool GetCreatureRoom(string type)
        {
            bool hasRoom = false;
            if (type == "Kelpie" && GetCapacity() == true) hasRoom = true;
            return hasRoom;
        }
        public override void AddCreature(string type, string name)
        {
            Kelpies.Add(new Kelpie(name));
        }
    }
}
