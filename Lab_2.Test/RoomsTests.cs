using System;
using Lab_2.Suitcase_rooms;
using Lab_2.Creatures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab_2.Test
{
    [TestClass]
    public class CommonRoomsTests
    {
        private Place room = new CommonRoom("Enter");

        [TestMethod]
        public void AddRoom_newRoom_ReturnRoomIsAdded()
        {
            var expected = new Pool("pool");
            bool isAdded = room.Add(expected);
            Assert.IsTrue(isAdded);
        }

        [TestMethod]
        public void RemoveRoom_selectedRoom_ReturnRoomNotExist()
        {
            var notExpected = new Forest("");
            room.Add(notExpected);
            bool exists = room.Remove(notExpected);
            Assert.IsFalse(exists);
        }

        [TestMethod]
        public void GetRoom_roomsName_ReturnExpectedRoom()
        {
            var expectedRoom = new Forest("forest");
            room.Add(expectedRoom);
            var foundRoom = room.GetRoom("forest");
            Assert.AreEqual(expectedRoom, foundRoom);
        }

        [TestMethod]
        public void GetTree_rooms_ReturnRoomsScheme()
        {
            room.Add(new Field("field"));
            string expectedScheme = "Enter(field)";
            string actual = room.GetTree();
            Assert.AreEqual(expectedScheme, actual);
        }

        [TestMethod]
        public void AddCreature_nameAndType_ReturnCreatureAdded()
        {
            room.Add(new Forest("forest"));
            room.AddCreature("Demiguise", "Vabjorn");
            bool creatureAdded = room.GetRoom("forest").CreatureIsHere("Vabjorn");
            Assert.IsTrue(creatureAdded);
        }

        [TestMethod]
        public void GetName_roomsName_ReturnRoomWithExpectedName()
        {
            room.Add(new CommonRoom("newRoom"));
            string expectedName = "newRoom";
            string found = room.GetRoom("newRoom").GetName();
            Assert.AreEqual(expectedName, found);
        }

        [TestMethod]
        public void IsComposite_ReturnTrueStatement()
        {
            room.Add(new CommonRoom("new"));
            bool isComposite = room.GetRoom("new").IsComposite();
            Assert.IsTrue(isComposite);
        }

        [TestMethod]
        public void IsComposite_ReturnFalseStatement()
        {
            room.Add(new Forest("new"));
            bool isComposite = room.GetRoom("new").IsComposite();
            Assert.IsFalse(isComposite);
        }

        [TestMethod]
        public void AskVoiceConcrete_creatureName_ReturnConcreteCreatureVoice()
        {
            room.Add(new Forest("forest"));
            room.AddCreature("Demiguise", "Vabjorn");
            string expectedVoice = "\"Urff Urff\"";
            string actualVoice = room.AskVoiceConcrete("Vabjorn");
            Assert.AreEqual(expectedVoice, actualVoice);
        }
    }
}
