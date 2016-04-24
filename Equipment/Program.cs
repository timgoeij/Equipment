using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            while (true)
            {
                Console.WriteLine("to equip the gun press g");
                Console.WriteLine("to equip the ammo clip press a");
                Console.WriteLine("to equip the hat press h");
                Console.WriteLine("to equip the flashlight press f");
                Console.WriteLine("to equip the rock press r");
                Console.WriteLine("");
                Console.WriteLine("press after each command enter to confirm");

                player.Update();
                Console.WriteLine("");
            }
        }
    }
}
