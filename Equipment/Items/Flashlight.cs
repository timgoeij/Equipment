using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment
{
    public class FlashLight : Item
    {
        
        private bool on;

        public FlashLight(Player player, Inventory inventory) : base(player, inventory)
        {
            on = false;
        }

        public override void Update()
        {
            string key;

            //check if the flashlight is on/off and check of the key is equals to o and set the flashlight on/off
            if (on)
            {
                Console.WriteLine("what to do with the flashlight: press o to set the flaslight off else press two times enter");
                key = Console.ReadLine();

                if (key == "o")
                {
                    on = false;
                    Console.WriteLine("flashlight is off");
                }
                else
                    Console.WriteLine("flashlight is still on");
            }
            else
            {
                Console.WriteLine("what to do with the flashlight: press o to set the flaslight on else press two times enter");
                key = Console.ReadLine();

                if (key == "o")
                {
                    on = true;
                    Console.WriteLine("flashlight is on");
                }
                else
                    Console.WriteLine("flashlight is still off");
            }
        }
    }
}
