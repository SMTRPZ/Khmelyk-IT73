using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_2.Creatures;

namespace Lab_2.Suitcase_rooms
{
    public class CommonRoom : Place
    {
        private List<Place> InnerPlaces { get; set; }
        public CommonRoom(string name) : base(name)
        {
            InnerPlaces = new List<Place>();
        }
        public override bool Add(Place p)
        {
            InnerPlaces.Add(p);
            p.Parent = this;

            return InnerPlaces.Exists(a => a == p);
        }

        public override bool Remove(Place p)
        {
            InnerPlaces.Remove(p);

            return InnerPlaces.Exists(a => a == p);
        }

        public override Place GetRoom(string name)
        {
            Place res = null;
        
            if (InnerPlaces.Exists(a => a.GetName() == name))
            {
                res = InnerPlaces.Find(a => a.GetName() == name);
            }
            else
            {
                foreach (Place place in InnerPlaces.Where(a => a.IsComposite() == true))
                {
                    res = place.GetRoom(name);
                }
            }
            return res;
        }
        
        public override string GetTree()
        {
            int i = 0;
            string res = "" + GetName() + "(";

            foreach(Place place in InnerPlaces)
            {
                res += place.GetTree();
                if(i != this.InnerPlaces.Count - 1)
                {
                    res += "+";
                }
                i++;
            }
            return res + ")";
        }
        public override void AddCreature(string type, string name)
        {
            Place creatureRoom = null;

            creatureRoom = InnerPlaces.Find(a => a.GetCreatureRoom(type) == true);
            if (creatureRoom == null)
            {
                foreach (Place room in InnerPlaces.Where(a => a.IsComposite() == true))
                {
                    room.AddCreature(type, name);
                }
            }
            else
            {
                creatureRoom.AddCreature(type, name);
            }
        }
        public override string AskVoiceConcrete(string creatureName)
        {
            Place creatureRoom = null;
            string voice = "";
            creatureRoom = InnerPlaces.Find(a => a.CreatureIsHere(creatureName) == true);

            if (creatureRoom == null)
            {
              foreach(Place composite in InnerPlaces.Where(a => a.IsComposite() == true))
                {
                    composite.AskVoiceConcrete(creatureName);
                }
            }
            else
            {
                voice = creatureRoom.AskVoiceConcrete(creatureName);
            }
            return voice;
        }
    }
}
