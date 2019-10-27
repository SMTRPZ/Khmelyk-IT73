using System;
using System.Collections.Generic;
using Lab_2.Creatures;
using Lab_2.Suitcase_rooms;

namespace Lab_2.Suitcase_rooms
{
    public class RoomsManagement
    {
        private Place MainRoom { get; set; }
        public RoomsManagement()
        {
            MainRoom = new CommonRoom("Entrance");
        }

        private void AddRoom(string type, string r_name, string n_name)
        {
            Place room = MainRoom.GetRoom(r_name);
            switch (type)
            {
                case "Room":
                    room.Add(new CommonRoom(n_name));
                    break;
                case "Forest":
                    room.Add(new Forest(n_name));
                    break;
                case "Pool":
                    room.Add(new Pool(n_name));
                    break;
                case "Field":
                    room.Add(new Field(n_name));
                    break;
            }
        }
        private void RemoveRoom()
        {
            Console.WriteLine("Write the name of room you want to remove: ");
            string name = Console.ReadLine();
            Place removal = MainRoom.GetRoom(name);
            removal.Parent.Remove(removal);
            Console.WriteLine($"{name} was removed");
        }
        private void ShowTree()
        {
            string scheme = MainRoom.GetTree();
            Console.WriteLine(scheme);

        }
        private void AskVoiceConcrete()
        {
            Console.WriteLine("Write the name of creature youre looking for: ");
            string creature = Console.ReadLine();
            string voice = MainRoom.AskVoiceConcrete(creature);
            Console.WriteLine(voice);
        }
        // -----------------------------------------------
        public void InitiateRooms()
        {
            MainRoom.Add(new CommonRoom("Dormitory"));
            AddRoom("Room", "Dormitory", "Lab");
            AddRoom("Field", "Lab", "Occamy`s home");
            AddRoom("Room", "Lab", "Bedroom");
            AddRoom("Forest", "Bedroom", "Demiguise`s home");
            AddRoom("Room", "Dormitory", "Inventory");
            AddRoom("Room", "Inventory", "Garage");
            AddRoom("Forest", "Dormitory", "Bowtruckle safehouse");
            MainRoom.AddCreature("Demiguise", "trololo");
        }
        private void MenuAddRoom()
        {
            Console.WriteLine("Write the type of room: ");
            string type = Console.ReadLine();
            Console.WriteLine("Write the place where to add room: ");
            string room = Console.ReadLine();
            Console.WriteLine("Write the name of room: ");
            string name = Console.ReadLine();
            AddRoom(type, room, name);
            Console.WriteLine($"In the {room} was added {type} named {name}");
        }
        private void MenuAddCreature()
        {
            Console.WriteLine("Write the type of creature: ");
            string type = Console.ReadLine();
            Console.WriteLine("Write the name of creature: ");
            string name = Console.ReadLine();
            MainRoom.AddCreature(type, name);
            Console.WriteLine($"{type} named {name} was placed into the room!");
        }

        public void OpenMenu()
        {
            Console.WriteLine("Welcome to the main controlling panel. What would you like to do?\n" +
                "Press 1 to add a room\n" +
                "Press 2 to remove room\n" +
                "Press 3 to add creature\n" +
                "Press 4 to show rooms map\n" +
                "Press 5 to ask concrete creature for voice");
            var option = Console.ReadKey().Key;
            switch (option)
            {
                case ConsoleKey.D1:
                    MenuAddRoom();
                    Console.ReadKey();
                    break;
                case ConsoleKey.D2:
                    RemoveRoom();
                    Console.ReadKey();
                    break;
                case ConsoleKey.D3:
                    MenuAddCreature();
                    Console.ReadKey();
                    break;
                case ConsoleKey.D4:
                    ShowTree();
                    Console.ReadKey();
                    break;
                case ConsoleKey.D5:
                    AskVoiceConcrete();
                    Console.ReadKey();
                    break;
            }
            OpenMenu();
        }
    }
}
