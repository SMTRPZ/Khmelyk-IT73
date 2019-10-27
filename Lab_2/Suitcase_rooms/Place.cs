using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_2.Creatures;

namespace Lab_2
{
    public abstract class Place
    {
        protected string Name { get; set; }
        public Place Parent { get; set; }
        public static List<string> creatureVoices;
        public virtual bool Add(Place p) { return false; }
        public virtual bool Remove(Place p) { return true; }
        public string GetName() { return Name; }
        public virtual bool IsComposite() { return true; }
        public virtual Place GetRoom(string name) { throw new NotImplementedException(); }
        public virtual string GetTree() { return GetName(); }
        public virtual void AddCreature(string type, string name) { throw new NotImplementedException(); }
        public virtual string AskVoiceConcrete(string name) { throw new NotImplementedException(); }
        public virtual bool GetCreatureRoom(string type) { return false; }
        public virtual bool GetCapacity() { throw new NotImplementedException(); }
        public virtual bool CreatureIsHere(string creature_name) { return false; }
        public Place(string name) { Name = name; }
    }
}
