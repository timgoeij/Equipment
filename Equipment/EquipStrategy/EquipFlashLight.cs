using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment
{
    public class EquipFlashLight : BaseStrategy
    {

        public EquipFlashLight(Player player, Inventory inventory)
            : base(player, inventory)
        {
            
        }

        public override void Equip()
        {
            if (inventory.FlashLight)
            {
                Console.WriteLine("where equip the flashlight? left hand: 1, right hand 2, head 3");

                string key = Console.ReadLine();

                //check if the key is 1 and equip the item to the left hand
                if (key == "1")
                {
                    if (player.LeftHandItem is Gun)
                    {
                        inventory.TempGun = (Gun)player.LeftHandItem;
                        switchItem(player.LeftHandItem, new FlashLight(player, inventory));
                    }
                    else
                    {
                        if (player.LeftHandItem != null)
                            switchItem(player.LeftHandItem, new FlashLight(player, inventory));
                        else
                            player.LeftHandItem = new FlashLight(player, inventory);
                    }
                }//check if the key is 2 and equip the item to the right hand
                else if (key == "2")
                {
                    if (player.RightHandItem is Gun)
                    {
                        inventory.TempGun = (Gun)player.RightHandItem;
                        switchItem(player.RightHandItem, new FlashLight(player, inventory));
                    }
                    else
                    {
                        if (player.RightHandItem != null)
                            switchItem(player.RightHandItem, new FlashLight(player, inventory));
                        else
                            player.RightHandItem = new FlashLight(player, inventory);
                    }
                }//check if the key is 3 and equip the item to the head
                else if (key == "3")
                {
                    if (player.HeadItem is Gun)
                    {
                        inventory.TempGun = (Gun)player.HeadItem;
                        switchItem(player.HeadItem, new FlashLight(player, inventory));
                    }
                    else
                    {
                        if (player.HeadItem != null)
                            switchItem(player.HeadItem, new FlashLight(player, inventory));
                        else
                            player.HeadItem = new FlashLight(player, inventory);
                    }
                }

                if (key == "1" || key == "2" || key == "3")
                {
                    Console.WriteLine("flashlight is equipped");
                    inventory.FlashLight = false;
                }
            }
            else
                Console.WriteLine("flashlight already equipped");
        }
    }
}