using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment
{
    public class Rock : Item
    {
        public Rock(Player player, Inventory inventory) : base(player, inventory)
        {

        }

        public override void Update()
        {
            Console.WriteLine("throwing the rock press t else press twice enter");

            string key = Console.ReadLine();

            //check if the key is equals to t
            if (key == "t")
            {
                Console.WriteLine("the rock is thrown away");

                //check which hand has the rock and unequip the rock from that hand

                if (player.LeftHandItem is Rock)
                    player.LeftHandItem = null;

                if (player.RightHandItem is Rock)
                    player.RightHandItem = null;
            }
        }
    }
}
