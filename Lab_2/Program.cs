using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_2.Suitcase_rooms;

namespace Lab_2
{
    class Program
    {    
        static void Main()
        {
            RoomsManagement management = new RoomsManagement();
            management.InitiateRooms();
            management.OpenMenu();
        }
    }
}
