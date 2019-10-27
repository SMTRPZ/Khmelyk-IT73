using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_2.Creatures;
using Lab_2.Suitcase_rooms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab_2.Test
{
    [TestClass]
    public class CreatureRoomsTests
    {
        [TestMethod]
        public void GetCapacity_ReturnHasPlace()
        {
            Forest forest = new Forest("");
            forest.AddCreature("", "");
            forest.AddCreature("", "");
            forest.AddCreature("", "");
            forest.AddCreature("", "");
            bool hasPlace = forest.GetCapacity();
            Assert.IsTrue(hasPlace);
        }

        [TestMethod]
        public void GetCapacity_ReturnHasNoPlace()
        {
            Forest forest = new Forest("");
            forest.AddCreature("", "");
            forest.AddCreature("", "");
            forest.AddCreature("", "");
            forest.AddCreature("", "");
            forest.AddCreature("", "");
            bool hasPlace = forest.GetCapacity();
            Assert.IsFalse(hasPlace);
        }

        [TestMethod]
        public void GetCreatureRoom_CreatureType_ReturnIsAppropriateRoom()
        {
            Pool pool = new Pool("");
            bool isAppropriate = pool.GetCreatureRoom("Kelpie");
            Assert.IsTrue(isAppropriate);
        }

        [TestMethod]
        public void GetCreatureRoom_CreatureType_ReturnIsNotAppropriateRoom()
        {
            Pool pool = new Pool("");
            bool isAppropriate = pool.GetCreatureRoom("Demiguise");
            Assert.IsFalse(isAppropriate);
        }
    }
}
