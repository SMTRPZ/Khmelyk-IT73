using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_2.Creatures;
namespace Lab_2.Suitcase_rooms
{
    public class Field : Place
    {
        private List<Creature> Occamies { get; set; }
        public Field(string name) : base(name)
        {
            Occamies = new List<Creature>();
        }
        public override bool GetCapacity()
        {
            bool hasPlace = true;
            Occamies.Capacity = 4;
            if (Occamies.Count >= Occamies.Capacity) hasPlace = false;
            return hasPlace;
        }
        public override bool IsComposite()
        {
            return false;

        }
        public override bool CreatureIsHere(string creature_name)
        {
            return Occamies.Exists(a => a.GiveName() == creature_name);
        }
        public override string AskVoiceConcrete(string name)
        {
            return Occamies.Find(a => a.GiveName() == name).Voice();
        }
        public override bool GetCreatureRoom(string type)
        {
            bool hasRoom = false;
            if (type == "Occamy" && GetCapacity() == true) hasRoom = true;
            return hasRoom;
        }
        public override void AddCreature(string type, string name)
        {
            Occamies.Add(new Occamy(name));
        }
    }
}
